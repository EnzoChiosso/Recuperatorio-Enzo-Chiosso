using Actividad_3.Entidades;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base de un paralelogramo: ");
            if (!int.TryParse(Console.ReadLine(), out int Base) || Base <= 0)
            {
                Console.WriteLine("Base mal ingresada, el numero no es entero o es negativo");
                return;
            }
            Console.Write("Ingrese la altura de un paralelogramo: ");
            if (!int.TryParse(Console.ReadLine(), out int Altura) || Altura <= 0)
            {
                Console.WriteLine("Altura mal ingresada, el numero no es entero o es negativo");
                return;
            }
            Console.Write("Ingrese el lado de un paralelogramo: ");
            if (!int.TryParse(Console.ReadLine(), out int Lado) || Lado <= 0)
            {
                Console.WriteLine("Lado mal ingresado, el numero no es entero o es negativo");
                return;
            }
            paralelogramo p = new paralelogramo(Base, Altura, Lado);
            Console.WriteLine(p.GetInfo());
        }
    }
}
