using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class agregarMarca : Form
    {
        public agregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(tBAMarca.Text != "") {
                Marca marca = new Marca(tBAMarca.Text);
                MarcaNegocio marcaN = new MarcaNegocio();
                marcaN.agregar(marca);

                Close();
            }
            else
            {
                //Dispose();
                MessageBox.Show("Debe ingresar un nombre correcto.", "Alerta",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
