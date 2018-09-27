using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLGramtoOunces
{
    public class Class1
    {

        public double ConvertToOunces(double grams)
        {
            double oz = grams * 0.035274;
            return oz;
        }
        public  double ConvertToGrams(double oz)
        {
            double grams = oz * 28.34952;
            return grams;
        }

    }
}
