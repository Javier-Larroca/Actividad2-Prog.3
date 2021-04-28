using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            ConexionDatos conexion = new ConexionDatos();
            try
            {
                conexion.setearConsulta("Select * From Articulos");
                conexion.ejecutarLectura();

                while (conexion.Lector.Read())
                {
                    Articulo backup = new Articulo();

                    backup.CodigoArticulo = (String)conexion.Lector["Codigo"];
                    backup.Nombre = (String)conexion.Lector["Nombre"];
                    backup.Descripcion = (String)conexion.Lector["Descripcion"];
                    backup.Marca = new Marca((int)conexion.Lector["idMarca"]);
                    backup.Categoria = new Categoria((int)conexion.Lector["idCategoria"]);
                    backup.Precio = (decimal)conexion.Lector["Precio"];
                    backup.UrlImagen=(String)conexion.Lector["ImagenUrl"];

                    lista.Add(backup);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            ConexionDatos conexion = new ConexionDatos();
            try {
                string valores = "values(" + nuevo.CodigoArticulo + ", '" + nuevo.Descripcion + "', '" + nuevo.Marca + "', '" + nuevo.UrlImagen + "', " + nuevo.Categoria + ", 1)";
                conexion.setearConsulta("insert into Articulos (Codigo, Nombre, Descripcion, idMarca, idCategoria, UrlImagen, Precio" + valores);
                conexion.ejectutarAccion();

            }
            catch(Exception ex)
            {
                throw ex;

            }
            finally
            {

                conexion.cerrarConexion();
            }
        } 

        public void modificar()
        {

        }

        public void eliminar()
        {


        }
    }
}
