using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Medico : Persona
    {
        private int puntosDeExperiencia;
        public Medico(string nombre, int edad, string nacion, int sueldo, int puntosDeExperiencia) : base(nombre, edad, nacion, sueldo)
        {
            this.puntosDeExperiencia = puntosDeExperiencia;
        }

        public int PuntosDeExperiencia { get => puntosDeExperiencia; set => puntosDeExperiencia = value; }

        public void Evaluar(Jugador jugador)
        {
            // Evaluar jugador
        }

        public void Curar(Jugador jugador)
        {
            // Curar jugador
        }
    }
}
