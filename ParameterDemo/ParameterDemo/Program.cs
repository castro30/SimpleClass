using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterDemo
{
    class Calculator
    {
        public void AddandSubtract(int num1,int num2, out int sum, out int diff)
        {
            sum = num1 + num2;
            diff = num1 - num2;
        }
    }
    class ParametersDemo
    {
        static void Main(string[] args)
        {
            int thesum, thediff;
            Calculator objectCal = new Calculator();
            objectCal.AddandSubtract(20, 10, out thesum, out thediff);

            Console.WriteLine("{0},{1}", thesum, thediff);
            Console.ReadKey();

        }
    }
}
