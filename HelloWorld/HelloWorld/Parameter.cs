using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class Parameter
    {
        public Parameter()
        {

        }

        public double[] parameterABC = new double[3];

        double a;
        double b;
        double c;

        public double A 
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public bool EinlesenDerParameter()
        {
            int i = 0;
            bool convertOK = false;

            while (!convertOK)
            {
                Console.WriteLine("Bitte geben sie eine Zahl {0} ein:", i);
                convertOK = double.TryParse(Console.ReadLine(), out parameterABC[i]);
                if (convertOK)
                {
                    i++;
                    convertOK = false;
                    if (i > 2) break;
                }
            }
            return true;
        }
        public bool LösenEinerQuadratischenGleichung()
        {
            double x11 = 0;
            double x12 = 0;
            double x13 = 0;
            double x14 = 0;
            double x15 = 0;
            double x16 = 0;
            double x17 = 0;

            a = parameterABC[0];
            b = parameterABC[1];
            c = parameterABC[2];

            x11 = 4 * a * c;
            x12 = b * b;
            x13 = Math.Sqrt(x11 + x12);

            x14 = -b + x13;
            x15 = -b - x13;
            x16 = x14 / (2 * a);
            x17 = x15 / (2 * a);

            Console.WriteLine("X1 = {0}", x16);
            Console.WriteLine("X2 = {0}", x17);

            return true;
        }
    }
}
