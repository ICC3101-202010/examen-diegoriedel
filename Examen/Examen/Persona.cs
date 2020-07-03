using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string nacion;
        private int sueldo;

        public Persona(string nombre, int edad, string nacion, int sueldo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacion = nacion;
            this.sueldo = sueldo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nacion { get => nacion; set => nacion = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }
    }
}
