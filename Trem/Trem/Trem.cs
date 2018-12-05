using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibUDP;
using System.Diagnostics;

namespace Trem
{
    class Trem
    {
        private UDPSocket socket;

        public Trem()
        {
            socket = new UDPSocket(MensagemRecebida, 6000);
        }

        private void MensagemRecebida(byte[] buffer, int size, string ip, int port)
        {
            
        }

    }
}
