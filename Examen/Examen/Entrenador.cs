using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Entrenador : Persona
    {
        int puntosDeTactica;
        public event EventHandler<AvisarCambioDeJugadorEventArgs> OnAvisarCambioDeJugador;
        public event EventHandler<CambioDeJugadoresEventArgs> OnCambioDeJugadores;

        public Entrenador(string nombre, int edad, string nacion, int sueldo, int puntosDeTactica) : base(nombre, edad, nacion, sueldo)
        {
            this.puntosDeTactica = puntosDeTactica;
        }

        public int PuntosDeTactica { get => puntosDeTactica; set => puntosDeTactica = value; }

        private void CambiarJugador(Jugador jugadorViejo)
        {
            Jugador jugadorNuevo = new Jugador("Nuevo Jugador", 20, "Chilena", 12000, 12, 10, 4);

            // Avisar cambio de jugador
            if (OnAvisarCambioDeJugador != null)
            {
                AvisarCambioDeJugadorEventArgs avisarCambioDeJugadorEventArgs = new AvisarCambioDeJugadorEventArgs();
                avisarCambioDeJugadorEventArgs.jugadorNuevo = jugadorNuevo;
                avisarCambioDeJugadorEventArgs.jugadorViejo = jugadorViejo;
                OnAvisarCambioDeJugador(this, avisarCambioDeJugadorEventArgs);
            }

            // Cambiar jugador
            if (OnCambioDeJugadores != null)
            {
                CambioDeJugadoresEventArgs cambioDeJugadoresEventArgs = new CambioDeJugadoresEventArgs();
                cambioDeJugadoresEventArgs.jugadorNuevo = jugadorNuevo;
                cambioDeJugadoresEventArgs.jugadorViejo = jugadorViejo;
                OnCambioDeJugadores(this, cambioDeJugadoresEventArgs);
            }
        }

        public void Jugador_OnLesion(object sender, LesionEventArgs e)
        {
            CambiarJugador(e.jugador);
        }
    }
}
