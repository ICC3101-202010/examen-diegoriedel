using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Equipo
    {
        List<Jugador> jugadores = new List<Jugador>();
        Entrenador entrenador;
        Medico medico;
        string nombre;
        string tipoDeEquipo;

        public Equipo(List<Jugador> jugadores, Entrenador entrenador, Medico medico, string nombre, string tipoDeEquipo)
        {
            if (jugadores.Count != 15)
            {
                throw new ArgumentException("Solo se pueden tener equipos con 15 jugadores.");
            }
            else
            {
                if (tipoDeEquipo == "Nacional")
                {
                    foreach (Jugador jugador in jugadores)
                    {
                        if (jugadores[0].Nacion != jugador.Nacion)
                        {
                            throw new ArgumentException("No se pueden tener jugadores de diferentes naciones en un equipo nacional.");
                        }
                    }
                }

                foreach (Jugador jugador in jugadores)
                {
                    jugador.OnLesion += entrenador.Jugador_OnLesion;
                }

                entrenador.OnCambioDeJugadores += this.Entrenador_OnCambioDeJugadores;

                this.jugadores = jugadores;
                this.entrenador = entrenador;
                this.medico = medico;
                this.nombre = nombre;
                this.tipoDeEquipo = tipoDeEquipo;
            }
        }

        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string TipoDeEquipo { get => tipoDeEquipo; set => tipoDeEquipo = value; }

        private void Entrenador_OnCambioDeJugadores(object sender, CambioDeJugadoresEventArgs e)
        {
            jugadores.Remove(e.jugadorViejo);
            jugadores.Add(e.jugadorNuevo);
        }
    }
}
