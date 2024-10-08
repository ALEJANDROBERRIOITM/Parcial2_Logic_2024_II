using System;

internal class Program
{
    public static void Main(string[] args)
    {
        //Desarrollar el juego “Adivina el número” en un programa de C#. El juego es muy sencillo,
        //consiste en adivinar un número ℕ aleatorio que el sistema escoge de un determinado rango
        //y lo guarda en memoria sin ser revelado.

        // valores de entrada

        Random random = new Random();
        bool jugar = true;

        while (jugar)
        {
            int cantidadJugadores = 0;

            // Solicitar el número de jugadores en el juego

            while (cantidadJugadores < 2 || cantidadJugadores > 4)
            {
                Console.Write("Ingrese el número de jugadores (2 a 4): ");
                cantidadJugadores = int.Parse(Console.ReadLine());
            }
            // Generar el cambio de número aleatorio según los jugadores

            int numeroAleatorio = GenerarNumeroAleatorio(cantidadJugadores, random);
            bool ganador = false;
            int Turno = 0;

            Console.Clear();
            Console.WriteLine($"¡Bienvenidos al juego! El número ha sido seleccionado entre 0 y 100 {ObtenerRango(cantidadJugadores)}.");

            while (!ganador)

            {
                Console.WriteLine($"\nTurno del jugador {turno + 1}:");
                Console.Write("Ingrese su número: ");
                int intento = int.Parse(Console.ReadLine());

                if (intento > numeroAleatorio)
                {
                    Console.WriteLine("MENOR");
                }
                else if (intento < numeroAleatorio)
                {
                    Console.WriteLine("MAYOR");
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO!");
                    ganador = true;
                }

                // Cambiar de turno del juego
                Turno = (Turno + 1) % cantidadJugadores;
            }

            // Preguntar si quieren jugar de nuevo

            Console.WriteLine("\n¿Desean jugar de nuevo? (s/n)");
            char respuesta = Console.ReadKey().KeyChar;
            jugar = (respuesta == 's' || respuesta == 'S');
            Console.Clear();
        }
    }

    static int GenerarNumeroAleatorio(int cantidadJugadores, Random random)
    {
        int rangoMaximo = ObtenerRango(cantidadJugadores);
        return random.Next(0, rangoMaximo + 1);
    }

    static int ObtenerRango(int cantidadJugadores)
    {
        switch (cantidadJugadores)
        {
            case 2:
                return 50;
            case 3:
                return 100;
            case 4:
                return 200;
            default:
                return 0; // No debería llegar aquí



        }
    }
}
