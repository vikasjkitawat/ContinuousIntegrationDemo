using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuousIntegrationDemo.Commons
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
