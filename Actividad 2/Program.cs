using System.Diagnostics.CodeAnalysis;

namespace Actividad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Base, Altura, Lado;
            double superficie = 0, perimetro = 0;
            double mayorPerimetro = 0;
            double promedioSuperficie = 0;
            double iteracion = 0;
            int contador = 1;


            do
            {
                do
                {
                    Console.Write("Ingrese la base de un paralelogramo: ");
                    if (!int.TryParse(Console.ReadLine(), out Base) || Base <= 0)
                    {
                        Console.WriteLine("Base mal ingresada, Reingresar...");
                    }
                    else
                    {
                        break;
                    }
                } while (Base <=0);
                do
                {
                    Console.Write("Ingrese la altura de un paralelogramo: ");
                    if (!int.TryParse(Console.ReadLine(), out Altura) || Altura <= 0)
                    {
                        Console.WriteLine("Altura mal ingresada, Reingresar...");
                    }
                    else
                    {
                        break;
                    }
                } while (Altura <=0);
                do
                {
                    Console.Write("Ingrese el lado de un paralelogramo: ");
                    if (!int.TryParse(Console.ReadLine(), out Lado) || Lado <= 0)
                    {
                        Console.WriteLine("Lado mal ingresado, Reingresar...");
                    }
                    else
                    {
                        break;
                    }
                } while (Lado <=0);
                perimetro = 2 * (Base + Lado);
                superficie = Base * Altura;
                Console.WriteLine($"El perimetro del paralelogramo es: {perimetro}");
                Console.WriteLine($"La superficie del paralelogramo es: {superficie}");
                contador = contador + contador - 1;
                promedioSuperficie = promedioSuperficie + superficie;
                if (perimetro > mayorPerimetro)
                {
                    mayorPerimetro = perimetro;
                    iteracion = contador;
                }
                Console.WriteLine("Deseas terminar el ciclo?");
                Console.Write("Escribe si para terminarlo o no para seguir: ");
                String Eleccion = Console.ReadLine();
                if (Eleccion == "si")
                {
                    break;
                }
            } while (Base >0 && Altura>0 && Lado>0);
            promedioSuperficie = promedioSuperficie / contador;
            Console.WriteLine($"El mayor perimetro es {mayorPerimetro} y fue ingresado en el ciclo {iteracion}");
            Console.WriteLine($"El promedio de las superficies es {promedioSuperficie}");
        }
    }
}
