using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Persona", 10, "Chilena", 10000, 12, 12, 12);
            Console.WriteLine(jugador.Nombre);
            Console.ReadLine();
        }
    }
}
