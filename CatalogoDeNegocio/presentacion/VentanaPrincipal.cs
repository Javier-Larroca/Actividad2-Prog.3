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

        private void ListarCategorias_Click(object sender, EventArgs e)
        {
            VistaCategorias nuevo = new VistaCategorias();
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

                //Se ocultan las columnas que no queremos mostrar en la ventana principal.
                dGVArticulos.Columns["CodigoArticulo"].Visible = false;
                dGVArticulos.Columns["Descripcion"].Visible = false;
                dGVArticulos.Columns["Categoria"].Visible = false;
                dGVArticulos.Columns["UrlImagen"].Visible = false;

                //Se llama al atributo RecargarImg pasandole la posicion 0 de la lista para que este cargue la primer imagen del arreglo de Articulos.
                RecargarImg(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void RecargarImg(string img)
        {
            pBArticulo.Load(img);
        }

        private void dGVArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)dGVArticulos.CurrentRow.DataBoundItem;
            try
            {

                RecargarImg(seleccionado.UrlImagen);
            }
            catch 
            {
                //En caso de no poder encontrar o acceder a la URL del articulo, procedemos a cargar una imagen de error
                RecargarImg("https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Nuvola_apps_error.svg/1200px-Nuvola_apps_error.svg.png");
            }

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            agregarArticulo agrArticulo = new agregarArticulo();
            agrArticulo.ShowDialog();

            cargarGrillaArticulos();
        }
    }
}
