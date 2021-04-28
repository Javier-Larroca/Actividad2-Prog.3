using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        public String Nombre{ get; set; }
        public int CodigoCategoria{ get; set; }


        public Categoria(String nombre)
        {
            Nombre = nombre;

        }

        public Categoria (String nombre, int id)
        {
            Nombre = nombre;
            CodigoCategoria = id;
        }

        public Categoria(int id)
        {
            CodigoCategoria = id;
        }
        //Funciones
    }
}
