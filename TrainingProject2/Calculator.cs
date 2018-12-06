using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject2
{
   internal class Calculator
    {
        private float num1;
        private float num2;

        public Calculator(float num1, float num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public float Num1 { get => num1; set => num1 = value; }
        public float Num2 { get => num2; set => num2 = value; }


        public float additionOfNumbers()
        {
            return num1 + num2;
        }

        public float substractionOfNumbers()
        {
            return num1 - num2;
        }
    }
}
