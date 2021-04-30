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
    public partial class agregarArticulo : Form
    {
        public agregarArticulo()
        {
            InitializeComponent();
        }

        private void agregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cBMarcas.DataSource = marca.listar();
                cBCategorias.DataSource = categoria.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        private void RecargarImg(string img)
        {
            pBMarca.Load(img);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estas Seguro? Perderás los datos", "Saliendo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articuloAgregado;
        }
    }
}
