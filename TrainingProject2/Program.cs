using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject2
{
    class Program
    {
        enum choices {Addition = 1, Substraction, Multiplication, Dividion}
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to calculator app");
            Console.WriteLine(" Enter 1 for Addition \n Enter 2 for Substraction \n Enter 3 for Multiplication \n Enter 4 for Division");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Your Selected choice is" + Enum.GetName(typeof(choices), choice) + "\n");
            Console.WriteLine("Enter First Number");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Number");
            float num2 = float.Parse(Console.ReadLine());

            Calculator calc = new Calculator(num1, num2);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition is : "+calc.additionOfNumbers());
                    break;

                case 2:
                    Console.WriteLine("Substraction is : " + calc.substractionOfNumbers());
                    break;

                case 3:
                    Console.WriteLine("Multiplication is : " + calc.MultiplicationOfNumbers());
                    break;

                case 4:
                    Console.WriteLine("Division is : " + calc.DivisionOfNumbers());
                    break;

                default:
                    Console.WriteLine("please enter proper choice");
                    break;
                    
            }

            Console.ReadKey();
        }
    }
}
