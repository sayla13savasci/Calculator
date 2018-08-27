using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatordll2
{
    public class Class1:Interface1
    {


        public Double add(Double num1, Double num2)
        {
            return num1 + num2;
        }

        public Double sub(Double num1, Double num2)
        {
            return num1 - num2;
        }

        public Double multiplication(Double num1, Double num2)
        {
            return num1 * num2;
        }

        public Double division(Double num1, Double num2)
        {
            return num1 / num2;
        }

        public Double sqrt(Double num1)
        {
            return Math.Sqrt(num1);
        } 

    }
}
