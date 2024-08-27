namespace Recuperatorio_Enzo_Chiosso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base de un paralelogramo: ");
            if (!int.TryParse(Console.ReadLine (), out int Base) || Base <0 )
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
            double perimetro = 2 * (Base + Lado);
            double superficie = Base * Altura;

            Console.WriteLine($"La base del paralelogramo es: {Base}");
            Console.WriteLine($"La altura del paralelogramo es: {Altura}");
            Console.WriteLine($"El lado del paralelogramo es: {Lado}");
            Console.WriteLine($"El perimetro del paralelogramo es: {perimetro}");
            Console.WriteLine($"La superficie del paralelogramo es: {superficie}");
        }
    }
}
