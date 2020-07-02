using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Arquero : Jugador, IJugarAlArco
    {
        public Arquero(string nombre, int edad, string nacion, int sueldo, int puntosDeAtaque, int puntosDeDefenza, int numeroDePolera) : base(nombre, edad, nacion, sueldo, puntosDeAtaque, puntosDeDefenza, numeroDePolera)
        {
        }

        void IJugarAlArco.JugarAlArco()
        {
            // Juega al arco
        }
    }
}
