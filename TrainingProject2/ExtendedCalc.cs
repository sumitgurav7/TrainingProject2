using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject2
{
    internal static class ExtendedCalc
    {
        public static float MultiplicationOfNumbers(this Calculator calc)
        {
            return calc.Num1 * calc.Num2;
        }

        public static float DivisionOfNumbers(this Calculator calc) => calc.Num1 / calc.Num2;
    }
}
