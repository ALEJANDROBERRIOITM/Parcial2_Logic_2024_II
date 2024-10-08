using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {

        //Sistema de evaluación de notas de estudiantes:
        //El programa permite ingresar las notas de varios estudiantes, calcular su promedio
        //y luego clasificar a cada estudiante en diferentes categorías de desempeño académico.
        //Al final, se le pregunta al usuario si quiere ingresar otro grupo de estudiantes.
        {
            while (true)
            {
                List<double> promedios = new List<double>();
                List<string> nombres = new List<string>();

                while (true)
                {
                    Console.Write("Ingrese el nombre del estudiante (o 'fin' para terminar): ");
                    string nombre = Console.ReadLine();

                    if (nombre.ToLower() == "fin")
                        break;

                    nombres.Add(nombre);
                    List<double> notas = new List<double>();

                    while (true)
                    {
                        Console.Write($"Ingrese una nota para {nombre} (0.0 - 5.0, o 'fin' para terminar): ");
                        string entradaNota = Console.ReadLine();

                        if (entradaNota.ToLower() == "fin")
                            break;

                        if (double.TryParse(entradaNota, out double nota) && nota >= 0.0 && nota <= 5.0)
                        {
                            notas.Add(nota);
                        }
                        else
                        {
                            Console.WriteLine("La nota debe estar entre 0.0 y 5.0");
                        }
                    }

                    if (notas.Count > 0)
                    {
                        double promedio = CalcularPromedio(notas);
                        promedios.Add(promedio);
                        string categoria = ClasificarEstudiante(promedio);
                        Console.WriteLine($"{nombre} tiene un promedio de {promedio:F2} y está en la categoría {categoria}.");
                    }
                }

                