using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class SolveEquation
    {
        public SolveEquation()
        {

        }

        public double[] parameterABC = new double[3];

        double a;
        double b;
        double c;
        double solutionX1;
        double solutionX2;

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
        public double SolutionX1
        {
            get
            {
                return solutionX1;
            }
            set
            {
                solutionX1 = value;
            }
        }
        public double SolutionX2
        {
            get
            {
                return solutionX2;
            }
            set
            {
                solutionX2 = value;
            }
        }

        public bool ReadInParameter()
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
            return convertOK;
        }
        public bool SolveQuadraticEquations()
        {
            a = parameterABC[0];
            b = parameterABC[1];
            c = parameterABC[2];

            try
            {
                solutionX1 = ((-b) + Math.Sqrt((b * b) + (4 * a * c))) / (2 * a);
                solutionX2 = ((-b) - Math.Sqrt((b * b) + (4 * a * c))) / (2 * a);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
