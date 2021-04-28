using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public String CodigoArticulo{ get; set; }
        public String Nombre { get; set; }
        public String Descripcion{ get; set; }
        public  Marca Marca{ get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public String UrlImagen { get; set; }

        public Articulo(String codigo, String nombre, String descripcion, int idMarca, int cat, decimal precio, String imagen)
        {
            CodigoArticulo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            UrlImagen = imagen;
        }
        public Articulo()
        {

        }

        //Funciones
    }
}
