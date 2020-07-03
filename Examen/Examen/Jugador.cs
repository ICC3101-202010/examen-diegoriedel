using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Jugador : Persona
    {
        private int puntosDeAtaque;
        private int puntosDeDefenza;
        private int numeroDePolera;
        private bool lesionado = false;

        public event EventHandler<LesionEventArgs> OnLesion;

        public Jugador(string nombre, int edad, string nacion, int sueldo, int puntosDeAtaque, int puntosDeDefenza, int numeroDePolera) : base(nombre, edad, nacion, sueldo)
        {
            this.numeroDePolera = numeroDePolera;
            this.puntosDeDefenza = puntosDeDefenza;
            this.numeroDePolera = numeroDePolera;
        }

        public int PuntosDeAtaque { get => puntosDeAtaque; set => puntosDeAtaque = value; }
        public int PuntosDeDefenza { get => puntosDeDefenza; set => puntosDeDefenza = value; }
        public int NumeroDePolera { get => numeroDePolera; set => numeroDePolera = value; }
        public bool Lesionado { get => lesionado; set => lesionado = value; }

        public void JugarEnLaCancha()
        {
            // Juega en la cancha
        }

        public void Lesionarse()
        {
            if (OnLesion != null)
            {
                LesionEventArgs lesionEventArgs = new LesionEventArgs();
                lesionEventArgs.jugador = this;
                OnLesion(this, lesionEventArgs);
            }
        }
    }
}
