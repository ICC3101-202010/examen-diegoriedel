using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Equipo
    {
        private List<Jugador> jugadores = new List<Jugador>();
        private Entrenador entrenador;
        private Medico medico;
        private string nombre;
        private string tipoDeEquipo;
        private string nacionalidad;

        public Equipo(Entrenador entrenador, Medico medico, string nombre, string tipoDeEquipo, string nacionalidad)
        {
            entrenador.OnCambioDeJugadores += this.Entrenador_OnCambioDeJugadores;
            this.entrenador = entrenador;
            this.medico = medico;
            this.nombre = nombre;

            this.tipoDeEquipo = tipoDeEquipo;
            this.nacionalidad = nacionalidad;
        }

        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public Entrenador Entrenador { get => entrenador; set => entrenador = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string TipoDeEquipo { get => tipoDeEquipo; set => tipoDeEquipo = value; }

        private void Entrenador_OnCambioDeJugadores(object sender, CambioDeJugadoresEventArgs e)
        {
            eliminarJugador(e.jugadorViejo);
            agregarJugador(e.jugadorNuevo);
        }

        public void agregarJugador(Jugador jugadorNuevo)
        {
            if (jugadores.Count < 15)
            {
                jugadorNuevo.OnLesion += this.entrenador.Jugador_OnLesion;
                if (tipoDeEquipo == "Nacional")
                {
                    if (jugadores.Count == 0)
                    {
                        jugadores.Add(jugadorNuevo);
                    }
                    else
                    {
                        if (jugadorNuevo.Nacion == this.nacionalidad)
                        {
                            jugadores.Add(jugadorNuevo);
                        }
                        else
                        {
                            Console.WriteLine("No se pueden tener juagdores de diferentes naciones en un equipo nacional");
                        }
                    }
                }
                else
                {
                    jugadores.Add(jugadorNuevo);
                }

            }
            else
            {
                Console.WriteLine("No puedes agregar mas de 15 jugadores al equipo");
            }
        }

        private void eliminarJugador(Jugador jugador)
        {
            jugadores.Remove(jugador);
        }
    }
}
