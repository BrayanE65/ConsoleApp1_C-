using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Figura
    {
        public double CalcularAreaCirculo(double radio)
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }

        public double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            double area = baseRectangulo * alturaRectangulo;
            return area;
        }
    }
}
