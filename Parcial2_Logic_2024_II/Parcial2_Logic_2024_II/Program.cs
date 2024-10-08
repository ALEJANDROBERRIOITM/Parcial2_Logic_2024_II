﻿using System;

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
            Console.WriteLine($"¡Bienvenidos al juego! El número ha sido seleccionado entre 0 y {ObtenerRango(cantidadJugadores)}.");

            while (!ganador)




        }
    }
}
