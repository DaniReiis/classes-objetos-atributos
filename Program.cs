using System.Globalization;
using System;
using classes;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Operacoes x, y, maiorArea;
            x = new Operacoes();
            y = new Operacoes();
            maiorArea = new Operacoes();

            Console.WriteLine("Entre com as medidas do trinângulo X:");
            x.A = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do trinângulo Y:");
            y.A = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            double xp = x.Perimeto(x.A, x.B, x.C);
            double areaX = x.Area(x.A, x.B, x.C);

            double yp = x.Perimeto(y.A, y.B, y.C);
            double areaY = x.Area(y.A, y.B, y.C);

            Console.WriteLine("Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));


            Console.WriteLine("Maior área é " + maiorArea.MaiorArea(areaX, areaY).ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}