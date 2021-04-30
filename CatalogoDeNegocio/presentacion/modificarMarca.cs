using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class modificarMarca : Form
    {
        private Marca marca1 = new Marca();
        
        public modificarMarca()
        {
            InitializeComponent();
        }

        public modificarMarca(Marca marca)
        {
            InitializeComponent();
            tBAMarca.Text = marca.Nombre;
            marca1.Nombre = marca.Nombre;
            marca1.CodigoMarca = marca.CodigoMarca;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (tBAMarca.Text != "")
            {
                Marca marca = new Marca(marca1.CodigoMarca,tBAMarca.Text);
                MarcaNegocio marcaN = new MarcaNegocio();
                marcaN.modificar(marca);

                Close();
            }
            else
            {
                //Dispose();
                MessageBox.Show("Debe ingresar un nombre correcto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
