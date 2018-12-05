using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controlador
{
    public partial class Form1 : Form
    {

        Controlador controlador;

        public Form1()
        {
            InitializeComponent();
            btnAndar.Visible = false;
            btnIniciar.Visible = false;
            btnLiberar.Visible = false;
            btnParar.Visible = false;
        }

        private void btnSetId_Click(object sender, EventArgs e)
        {

            string txtId = inputId.Text;

            if (txtId.Equals("1") || txtId.Equals("2") || txtId.Equals("3"))
            {
                byte id = byte.Parse(txtId);
                controlador = new Controlador(id);
                btnAndar.Visible = true;
                btnIniciar.Visible = true;
                btnLiberar.Visible = true;
                btnParar.Visible = true;
                btnSetId.Visible = false;
                labelId.Visible = false;
                inputId.Visible = false;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            controlador.SolicitarControle();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            controlador.Parar();
        }

        private void btnAndar_Click(object sender, EventArgs e)
        {
            controlador.Andar();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            controlador.LiberarControle();
        }
    }
}
