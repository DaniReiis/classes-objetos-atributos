using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Operacoes
    {

        public double A;
        public double B; 
        public double C;

        public double Perimeto(double A, double B, double C)
        {
            return (A + B + C) / 2;
        }

        public double Area(double A, double B, double C)
        {
            double p = Perimeto(A, B, C);
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public double MaiorArea(double areaX, double areaY)
        {
            if (areaX > areaY)
            {
                return areaX;
            }
            else
            {
                return areaY;
            }
        }
    }
}
