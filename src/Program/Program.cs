using Exercises;

namespace Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa el ancho del rectángulo que deseas imprimir en consola: ");
            int widthEntered = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, ingresa el largo del rectángulo que deseas imprimir en consola: ");
            int lengthEntered = Convert.ToInt32(Console.ReadLine());
            
            RectangleExercise rectangle1 = new RectangleExercise(widthEntered, lengthEntered);

            Console.WriteLine($"Ok, vamos a dibujar el rectángulo: \n{rectangle1.PrintRectangle()}");          
        }
    }
}
