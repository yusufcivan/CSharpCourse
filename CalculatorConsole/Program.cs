using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            float answer;

            Console.WriteLine("Please Enter first number: \n");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter 2'nd Number: \n");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Choose Operand ( +, *, -, / ) : \n");
            answer = 0;
            operand = Console.ReadLine();
            foreach (var item in operand)
            {
                if (item == null)
                {
                    Console.WriteLine("Bir Islem Seçin");
                    break;
                }

                if (item == '+')
                {
                    answer = num1 + num2;
                }

                if (item == '-')
                {
                    answer = num1 - num2;
                }
                if (item == '*')
                {
                    answer = num1 * num2;
                }
                if(item == '/')
                {
                    answer = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Yanlış Bir Seçim Yaptınız");
                }
                
            }

            Console.WriteLine("Your Answer Is: \n " + num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
            Console.ReadLine();


            //switch (operand)
            //{
            //    case "+":
            //        answer = num1 + num2;
            //        break;
            //    case "-":
            //        answer = num1 - num2;
            //        break;
            //    case "*":
            //        answer = num1 * num2;
            //        break;
            //    case "/":
            //        answer = num1 / num2;
            //        break;
            //    default:
            //        answer = 0;
            //        break;
        }
        //Console.WriteLine("Your Answer Is: \n " + num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
        //Console.ReadLine();


    }
}

