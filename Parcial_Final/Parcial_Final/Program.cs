internal class Program
{
    private static void Main(string[] args)
    {
        // Solicitar dimensiones de la matriz
        Console.Write("Ingrese el número de filas (N): ");
        int filas = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el número de columnas (M): ");
        int columnas = int.Parse(Console.ReadLine());

        // Crear y llenar la matriz con números aleatorios
        int[,] matriz = CrearMatriz(filas, columnas);

        // Definir posición inicial y número base
        int x = 0, y = 0;
        matriz[x, y] = 0; // Inicializar la posición (0,0) en cero

        // Variable para acumular los valores sumados
        int total = 0;

        // Bucle principal del juego
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            MostrarMatriz(matriz, x, y, total);

            // Leer entrada del usuario
            ConsoleKey tecla = Console.ReadKey().Key;

            // Manejar movimiento o salida
            switch (tecla)
            {
                case ConsoleKey.UpArrow:
                    if (x > 0)
                    {
                        total += matriz[x - 1, y]; // Sumar valor al acumulador
                        matriz[x - 1, y] = 0;     // Poner la celda a cero
                        x--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (x < filas - 1)
                    {
                        total += matriz[x + 1, y];
                        matriz[x + 1, y] = 0;
                        x++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (y > 0)
                    {
                        total += matriz[x, y - 1];
                        matriz[x, y - 1] = 0;
                        y--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (y < columnas - 1)
                    {
                        total += matriz[x, y + 1];
                        matriz[x, y + 1] = 0;
                        y++;
                    }
                    break;
                case ConsoleKey.Escape:
                    continuar = false; // Salir del programa
                    break;
            }
        }

       

    }
}