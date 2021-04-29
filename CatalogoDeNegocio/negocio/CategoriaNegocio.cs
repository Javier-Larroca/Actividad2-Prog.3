using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            ConexionDatos nuevaConexion = new ConexionDatos();
            try
            {
                nuevaConexion.setearConsulta("SELECT  Id, Descripcion FROM CATEGORIAS");
                nuevaConexion.ejecutarLectura();

                while (nuevaConexion.Lector.Read())
                {
                    //Creacion de lista, cargando los objetos de la misma directamente con el constructor de la clase.
                    lista.Add(new Categoria((int)nuevaConexion.Lector["Id"], (String)nuevaConexion.Lector["Descripcion"]));
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nuevaConexion.cerrarConexion();
            }
        }
    }
}
