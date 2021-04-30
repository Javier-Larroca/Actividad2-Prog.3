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
        private MarcaNegocio marca = new MarcaNegocio();
        private CategoriaNegocio categoria = new CategoriaNegocio();
        //Declaro esta variable Articulo como atributo de la clase para el form_closing
        private Articulo articuloAgregado;
        public agregarArticulo()
        {
            InitializeComponent();
        }

        private void agregarArticulo_Load(object sender, EventArgs e)
        {
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
            try
            {
                pBMarca.Load(img);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede acceder a la imagen. Contactese con Soporte");
                throw;
            } 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si articuloAgregado(Declarado como atributo de clase) es NULL, osea no se envio a BBDD, pregunta si esta seguro, caso contrario sale.
            if(articuloAgregado == null)
            {
                if ((MessageBox.Show("Si cancela el alta se perderán todos los datos", "Cancelar alta de articulo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.Cancel)
                    e.Cancel = true;
            }
            //Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio agregoArticulo = new ArticuloNegocio();
            articuloAgregado = new Articulo(codigoArt.Text, nombre.Text, descripcion.Text, (Marca)cBMarcas.SelectedItem, (Categoria)cBCategorias.SelectedItem, Convert.ToDecimal(Precio.Text), tBUrlImage.Text);
            try
            {
                if (agregoArticulo.agregar(articuloAgregado))
                {
                    MessageBox.Show("Se añadió correctamente el articulo: " + articuloAgregado.Nombre, "ALTA DE ARTICULO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Hubo un error al intentar agregar el articulo en el sistema.");

                }
            }
            catch (Exception)
            {

                
                MessageBox.Show("ERROR AL ENVIAR ARTICULO A LA BASE DE DATOS. LLAME A SOPORTE");
                throw;
            }
        }

        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {  
                if (((e.KeyChar < 48 && e.KeyChar != 46)|| e.KeyChar > 57) && e.KeyChar != 8)
                    e.Handled = true;  
        }

        private void tBUrlImage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tBUrlImage.Text != "")
            {
                RecargarImg(tBUrlImage.Text);
            }
        }
    }
}
