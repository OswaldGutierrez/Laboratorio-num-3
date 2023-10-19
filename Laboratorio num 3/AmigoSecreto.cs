using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_num_3
{
    internal class AmigoSecreto
    {
        public int CantidadDeJugadores { get; set; }

        public DateTime FechaDeInicio { get; set; }

        public DateTime FechaDeDescubrimiento { get; set; }

        public int NumeroDeEndulzadas { get; set; }

        public int FrecuenciaDeEndulzadas { get; set; }

        public double ValorDeEndulzadas { get; set; }

        public double ValorDeRegalo { get; set; }

        public Jugador[] Jugadores { get; set; }



        public AmigoSecreto(int cantidadJugadores, DateTime fechaInicio, DateTime fechaFin, int numeroEndulzadas, int frecuenciaEndulzadasDias, double valorEndulzada, double valorRegalo)
        {
            CantidadDeJugadores = cantidadJugadores;
            FechaDeInicio = fechaInicio;
            FechaDeDescubrimiento = fechaFin;
            NumeroDeEndulzadas = numeroEndulzadas;
            FrecuenciaDeEndulzadas = frecuenciaEndulzadasDias;
            ValorDeEndulzadas = valorEndulzada;
            ValorDeRegalo = valorRegalo;
            Jugadores = new Jugador[cantidadJugadores];
        }







        public void AsignarJugadores(Jugador[] jugadores)
        {
            if (jugadores.Length == CantidadDeJugadores)
            {
                Jugadores = jugadores;
            }
            else
            {
                Console.WriteLine("La cantidad de jugadores no coincide con la cantidad especificada en el juego.");
            }
        }

        public void AsignarAmigosSecretos()
        {
            //if (Jugadores == null || Jugadores.Length != CantidadDeJugadores)
            //{
            //    Console.WriteLine("No se han asignado jugadores al juego.");
            //    return;
            //}

            //Random rand = new Random();
            //List<int> indicesDisponibles = new List<int>();

            //for (int i = 0; i < CantidadDeJugadores; i++)
            //{
            //    indicesDisponibles.Add(i);
            //}

            //for (int i = 0; i < CantidadDeJugadores; i++)
            //{
            //    int jugadorActual = i;
            //    int indiceAmigoSecreto;

            //    do
            //    {
            //        // Elegir un índice al azar de la lista de índices disponibles
            //        int randomIndex = rand.Next(indicesDisponibles.Count);
            //        indiceAmigoSecreto = indicesDisponibles[randomIndex];
            //    } while (indiceAmigoSecreto == jugadorActual);

            //    // Eliminar el índice utilizado de la lista
            //    indicesDisponibles.RemoveAt(indicesDisponibles.IndexOf(indiceAmigoSecreto));

            //    // Asignar el amigo secreto al jugador
            //    Jugador jugadorActualObj = Jugadores[jugadorActual];
            //    Jugador amigoSecretoObj = Jugadores[indiceAmigoSecreto];
            //    jugadorActualObj.setAmigoSecreto(amigoSecretoObj.nom());

            //    // Simular el envío de mensajes de correo electrónico
            //    //if (EnviarCorreoElectronico(jugadorActualObj, amigoSecretoObj))
            //    //{
            //    //    Console.WriteLine($"Mensaje de correo electrónico enviado a {jugadorActualObj.getNombre()} informando que su amigo secreto es {amigoSecretoObj.getNombre()}.");
            //    //}
            //}


            // Shuffle aleatorio de los jugadores para asignar amigos secretos
            List<Jugador> jugadoresDesordenados = new List<Jugador>(Jugadores);
            Random rng = new Random();

            int n = jugadoresDesordenados.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Jugador temp = jugadoresDesordenados[k];
                jugadoresDesordenados[k] = jugadoresDesordenados[n];
                jugadoresDesordenados[n] = temp;
            }

            // Asignar amigos secretos y enviar correos electrónicos
            for (int i = 0; i < jugadoresDesordenados.Count; i++)
            {
                Jugador jugadorActual = jugadoresDesordenados[i];
                Jugador amigoSecreto = jugadoresDesordenados[(i + 1) % jugadoresDesordenados.Count];

                jugadorActual.AmigoSecreto = amigoSecreto.ToString();

                // Simular el envío de un correo electrónico
                //EnviarCorreoElectronico(jugadorActual, amigoSecreto);
            }

        }


        public void ImprimirInformacionJuego()
        {
            MessageBox.Show($"Fecha de Inicio: {FechaDeInicio}\n" +
                            $"Fecha de Fin: {FechaDeDescubrimiento}\n" +
                            $"Número de Endulzadas: {NumeroDeEndulzadas}\n" +
                            $"Frecuencia de Endulzadas en días: {FrecuenciaDeEndulzadas}\n" +
                            $"Valor de la Endulzada: {ValorDeEndulzadas:C}\n" +
                            $"Valor del Regalo: {ValorDeRegalo:C}");
        }



        public void ImprimirGustosJugadores()
        {
            foreach (Jugador jugador in Jugadores)
            {
                string mensaje = $"Jugador: {jugador.Nombre}\n" +
                                 $"Gusto Endulzada Ideal: {jugador.EndulzadaIdeal}\n" +
                                 $"Gusto Regalo Ideal: {jugador.RegaloIdeal}\n";

                MessageBox.Show(mensaje, "Gustos del Jugador");
            }
        }

        public int DiasHastaProximaEndulzada(DateTime fechaActual)
        {
            // Calcula la diferencia en días entre la fecha actual y la fecha de inicio del juego
            TimeSpan diferencia = FechaDeInicio - fechaActual;

            // Calcula el número de días restantes hasta la próxima endulzada
            int diasRestantes = (int)diferencia.TotalDays % FrecuenciaDeEndulzadas;

            if (diasRestantes < 0)
            {
                // Si es negativo, significa que ya pasó una endulzada, por lo que se calcula la próxima endulzada
                diasRestantes = FrecuenciaDeEndulzadas + diasRestantes;
            }

            return diasRestantes;
        }


        



    }
}
