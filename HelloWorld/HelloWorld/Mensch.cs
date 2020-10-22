using System;
using System.Collections.Generic;
using System.Text;

namespace Programm
{
    class Mensch
    {
        private string name;
        private double groesse;
        private double gewicht;
        public string Name 
        {
            get { return name; }
            set { name = value; }
        } 

        public double Groesse
        {
            get 
            { 
                return groesse; 
            }
            set 
            { 
                groesse = value;
            }
        }
        public double Gewicht
        {
            get 
            { 
                return gewicht; 
            }
            set 
            { 
                gewicht = value; 
            }
        }

        public double BmiBerechnen()
        {
            double bmi = 0;
            bmi = gewicht / ((groesse / 100) * (groesse / 100));
            return bmi;
        }

    }
}
