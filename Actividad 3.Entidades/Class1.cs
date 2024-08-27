using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Actividad_3.Entidades
{
    public struct paralelogramo
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int Lado { get; set; }
        public paralelogramo(int @base, int altura, int lado)
        {
            Base = @base;
            Altura = altura;
            Lado = lado;
        }
        public double GetPerimetro() => 2 * (Base + Lado);
        public double GetSuperficie() => Base * Altura;

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La base del paralelogramo es: {Base} ");
            sb.AppendLine($"La altura del paralelogramo es: {Altura} ");
            sb.AppendLine($"El lado del paralelogramo es: {Lado} ");
            sb.AppendLine($"El perimetro del paralelogramo es: {GetPerimetro()} ");
            sb.AppendLine($"La superficie del paralelogramo es: {GetSuperficie()} ");
            return sb.ToString();
        }
    }
}
