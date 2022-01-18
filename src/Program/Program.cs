using Exercises;

namespace Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa el ancho del rectángulo que deseas imprimir en consola: ");
            int wideEntered = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor, ingresa el largo del rectángulo que deseas imprimir en consola: ");
            int largeEntered = Convert.ToInt32(Console.ReadLine());
            RectangleExercise rectangle1 = new RectangleExercise(wideEntered, largeEntered);
            Console.WriteLine($"Ok, vamos a dibujar el rectángulo: \n{rectangle1.PrintRectangle()}");          
        }
    }
}
