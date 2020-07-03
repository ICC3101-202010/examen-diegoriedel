using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Partido
    {
        private Equipo equipo1;
        private Equipo equipo2;
        private int duracion;
        private int golesEquipo1 = 0;
        private int golesEquipo2 = 0;
        private string tipoDePartido;

        public Partido(Equipo equipo1, Equipo equipo2, int duracion, string tipoDePartido)
        {
            if (equipo1.TipoDeEquipo != equipo2.TipoDeEquipo)
            {
                throw new ArgumentException("No puede haber un partido de diferentes tipos de equipo.");
            }
            else
            {

                equipo1.Entrenador.OnAvisarCambioDeJugador += Entrenador_OnAvisarCambioDeJugador;
                equipo2.Entrenador.OnAvisarCambioDeJugador += Entrenador_OnAvisarCambioDeJugador;

                this.equipo1 = equipo1;
                this.equipo2 = equipo2;
                this.duracion = duracion;
                this.tipoDePartido = tipoDePartido;
            }
        }

        public int Duracion { get => duracion; set => duracion = value; }
        public string TipoDePartido { get => tipoDePartido; set => tipoDePartido = value; }

        public string EquiposQueSeEnfrentan()
        {
            return $"{equipo1.Nombre} V/S {equipo2.Nombre}";
        }

        public string Resultado()
        {
            return $"{equipo1.Nombre}: {golesEquipo1} -- {equipo2.Nombre}: {golesEquipo2}";
        }

        public void JugarPartido()
        {
            // equipo1.Jugadores[0].JugarEnLaCancha()
        }

        private void Entrenador_OnAvisarCambioDeJugador(object sender, AvisarCambioDeJugadorEventArgs e)
        {
            Console.WriteLine($"Sale {e.jugadorViejo.Nombre} -- Entra {e.jugadorNuevo.Nombre}");
        }
    }
}
