using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scientificdll
{
    public class Class2:Interface1
    {
        public Double power(Double num1, Double num2)
        {
            //return (num1 ^ num2);
            return Math.Pow(num1, num2);
        }
        public Double sin_s(Double num1)
        {
            Double num = num1 * (Math.PI / 180);
            return Math.Sin(num);
        }

        public Double cosine(Double num1)
        {
            Double num = num1 * (Math.PI / 180);
            return Math.Cos(num);
        }

        public Double tangent(Double num1)
        {
            Double num = num1 * (Math.PI / 180);
            return Math.Tan(num);
        }

        public Double nlogarithm(Double num1)//ln
        {

            return (Math.Log(num1));
        }

        public Double logarithm(Double num1)//log
        {

            return (Math.Log10(num1));
        }

        public Double invert(Double num1)
        {
            return 1 / num1;
        }
        public Double percentage(Double num1)
        {
            return num1 / 100;
        }

    }
}
