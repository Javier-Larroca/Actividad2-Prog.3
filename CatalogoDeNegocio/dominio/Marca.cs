using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Marca
    {
        public String Nombre { get; set; }
        public int CodigoMarca { get; set; }

        public Marca(String nombre)
        {
            Nombre = nombre;

        }

        public Marca(String nombre, int codigo)
        {
            Nombre = nombre;
            CodigoMarca = codigo;
        }

        public Marca(int codigo)
        {
            CodigoMarca = codigo;
        }

        public override string ToString()
        {
            return Nombre;
        }
        //Funciones
    }
}
