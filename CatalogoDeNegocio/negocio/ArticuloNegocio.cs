using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            ConexionDatos conexion = new ConexionDatos();
            try
            {
                conexion.setearConsulta("");
                conexion.ejecutarLectura();

                while (conexion.Lector.Read())
                {
                    Articulo backup = new Articulo(1,"","",1,1,1,"");
                        //(String)conexion.Lector['Codigo'],
                        //(String)conexion.Lector['Nombre'],
                        //(String)conexion.Lector['Descripcion'],
                        //(int)conexion.Lector['idMarca'],
                        //(int)conexion.Lector['idCategoria'],
                        //(float)conexion.Lector['Precio'],
                        //(String)conexion.Lector['ImagenUrl']);

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
