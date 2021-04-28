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
    public partial class VentanaPrincipal : Form
    {
        private List<Articulo> listaArticulos;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void ListarMarcas_Click(object sender, EventArgs e)
        {
            VistaMarcas nuevo = new VistaMarcas();
            nuevo.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            cargarGrillaArticulos();
        }

        private void cargarGrillaArticulos()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                listaArticulos = articuloNegocio.Listar();
                dGVArticulos.DataSource = listaArticulos;

                //dGVArticulos.Columns["CodigoArticulo"].Visible = false;
                //dGVArticulos.Columns["Nombre"].Visible = false;
                //dGVArticulos.Columns["Descripcion"].Visible = false;
                //dGVArticulos.Columns["Precio"].Visible = false;

                RecargarImg(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void RecargarImg(string img)
        {
            pBMarcas.Load(img);
        }
    }
}
