using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUDP;

namespace Controlador
{
    class Controlador
    {

        private UDPSocket socket;
        private byte id;
        private byte clockLocal;
        private byte clockExterno;
        private bool trabalhando;
        private bool esperando;

        private List<int> deferidos;

        int[] ports;

        public Controlador(byte id)
        {
            this.id = id;
            this.clockLocal = 0;
            this.clockExterno = 0;
            socket = new UDPSocket(MensagemRecebida, 6000 + id);

            switch(id)
            {
                case 1:
                    ports = new int[] { 6000, 6002, 6003 };
                    break;
                case 2:
                    ports = new int[] { 6000, 6001, 6003 };
                    break;
                case 3:
                    ports = new int[] { 6000, 6001, 6002 };
                    break;
            }

            trabalhando = false;
            esperando = false;

            deferidos = new List<int>();

        }

        private void MensagemRecebida(byte[] buffer, int size, string ip, int port)
        {
            if (buffer[0] == 0)
            {

                this.clockExterno = buffer[2];
                int idRecebido = buffer[1];

                if (this.clockLocal < this.clockExterno)
                {
                    this.clockLocal = this.clockExterno;
                }

                if (trabalhando)
                {
                    deferidos.Add(idRecebido);
                }
                else
                {
                    if (!esperando)
                    {
                        EnviarReply(6000 + idRecebido);
                    }
                    else
                    {
                        if (this.clockLocal < this.clockExterno)
                        {
                            deferidos.Add(idRecebido);
                        }
                        else
                        {
                            if (this.clockLocal > this.clockExterno)
                            {
                                EnviarReply(6000 + idRecebido);
                            }
                            else
                            {
                                if (this.id < idRecebido)
                                {
                                    deferidos.Add(idRecebido);
                                }
                                else
                                {
                                    EnviarReply(6000 + idRecebido);
                                }
                            }
                        }
                    }
                }
            }
            else
            {

            }
        }

        private void EnviarRequest(byte[] bytes, int[] ports)
        {
            foreach (int port in ports)
            {
                socket.Send(bytes, "127.0.0.1", port);
            }
        }

        private void EnviarReply(int port)
        {
            socket.Send(new byte[] { 1 }, "127.0.0.1", port);
        }

        public void SolicitarControle()
        {

            if (this.clockLocal <= this.clockExterno)
            {
                this.clockLocal = (byte) (this.clockExterno + 1);
            }

            byte[] request = new byte[] { 0, this.id, this.clockLocal };

            EnviarRequest(request, ports);
        }

        public void LiberarControle()
        {
            if (trabalhando)
            {
                foreach (int deferido in deferidos)
                {
                    EnviarReply(deferido);
                }
                deferidos.RemoveAll(deferido => true);
            }
        }

        public void Andar()
        {
            if (trabalhando)
            {
                socket.Send(new byte[] { 1 }, "127.0.0.1", 6000);
            }
        }

        public void Parar()
        {
            if (trabalhando)
            {
                socket.Send(new byte[] { 0 }, "127.0.0.1", 6000);
            }
        }

    }
}
