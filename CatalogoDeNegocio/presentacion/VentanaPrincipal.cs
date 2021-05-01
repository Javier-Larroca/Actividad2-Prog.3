﻿using System;
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
        private Articulo articuloSeleccionado;
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
                dGVArticulos.MultiSelect = false;

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
            try
            {
                pBArticulo.Load(img);
            }
            catch
            {
                pBArticulo.Image = pBArticulo.ErrorImage;
            }
                
           
        }

        private void dGVArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)dGVArticulos.CurrentRow.DataBoundItem;
            
                RecargarImg(seleccionado.UrlImagen);
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            formArticulo agrArticulo = new formArticulo();
            agrArticulo.ShowDialog();

            cargarGrillaArticulos();
        }

        private void modificarArticulo_Click(object sender, EventArgs e)
        {
            if (dGVArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el articulo a modificar");

            }
            else
            {
                //Agrego esta variable para guardar la posición del articulo modificado y al volver a la grilla que este seleccionado
                //Por ahora es la unica solución que tuve, debe existir otra forma mas modular seguro
                int posArticuloModificado = dGVArticulos.CurrentRow.Index;
                formArticulo modifArticulo = new formArticulo(articuloSeleccionado = (Articulo)dGVArticulos.CurrentRow.DataBoundItem);
                modifArticulo.ShowDialog();
                cargarGrillaArticulos();
                //  FALTA DESARROLLLAR PARA FILTRAR SI MODIFICA O CANCELA LA MODIFICACION   
                    dGVArticulos.CurrentCell = null;
                    dGVArticulos.Rows[posArticuloModificado].DefaultCellStyle.SelectionBackColor = Color.Green;
                    dGVArticulos.Rows[posArticuloModificado].Selected = true;
                 
                
            }
        }

        private void eliminarArticulo_Click(object sender, EventArgs e)
        {
            if (dGVArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el articulo a eliminar");

            }
            else
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el articulo " + dGVArticulos.CurrentRow.DataBoundItem.ToString() + "?", "Eliminar Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        ArticuloNegocio eliminar = new ArticuloNegocio();
                        if (eliminar.eliminarArticulo(articuloSeleccionado = (Articulo)dGVArticulos.CurrentRow.DataBoundItem))
                            MessageBox.Show("Se elimino correctamente el articulo " + articuloSeleccionado.Nombre);
                        cargarGrillaArticulos();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
    }
}
