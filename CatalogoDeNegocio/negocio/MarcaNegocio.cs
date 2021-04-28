using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            ConexionDatos nuevaConexion = new ConexionDatos();
            try
            {
                nuevaConexion.setearConsulta("SELECT  Id, Descripcion FROM MARCAS");
                nuevaConexion.ejecutarLectura();

                while (nuevaConexion.Lector.Read())
                {
                    Marca backup = new Marca((String)nuevaConexion.Lector["Descripcion"]);
                    lista.Add(backup);
                }
                return lista;
            }
            catch (Exception ex){
                throw ex;
            }
            finally {
                nuevaConexion.cerrarConexion();
            }
        }
    }
}
