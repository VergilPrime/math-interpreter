using System;

namespace math_interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            char oper = 'e';
            double number1 = 0.0;
            double number2 = 0.0;
            while (oper != 'e')
            {
                oper = Program.GetOper();
            }
            bool num1finished = false;
            while (!num1finished)
            {
                num1finished = Program.GetNumber1(oper, number1);
            }
            bool num2finished = false;
            while (!num2finished)
            {
                num2finished = Program.GetNumber2(oper, number2);
            }
            double answer = 0;
            switch (oper)
            {
                case '*':
                    answer = number1 * number2;
                    break;
                case '/':
                    answer = number1 / number2;
                    break;
                case '+':
                    answer = number1 + number2;
                    break;
                case '-':
                    answer = number1 - number2;
                    break;
            }
            Console.WriteLine("Your answer is " + answer + ".");
            Console.ReadLine();
        } // End Main

        private static char GetOper()
        {
            Console.WriteLine("What type of operation are we trying today?");
            Console.WriteLine("(You can enter things like Sum, +, /, or Multiply)");
            string operatorinput = Console.ReadLine();
            switch (operatorinput)
            {
                case "*":
                case "multiply":
                case "product":
                    return ('*');
                case "/":
                case "divide":
                case "quotient":
                    return ('/');
                case "+":
                case "add":
                case "sum":
                    return ('+');
                case "-":
                case "subtract":
                case "difference":
                    return ('-');
                default:
                    Console.WriteLine("What was that? I don't understand what " + operatorinput + "is.");
                    return ('e');
            } // End Switch
        }



        private static bool GetNumber1(char oper, double number1)
        {
            Console.WriteLine("Hello! What type of operation are we trying today?");
            Console.WriteLine("(You can enter things like Sum, +, /, or Multiply)");
            string operatorinput = Console.ReadLine();
            switch (oper)
            {
                case '*':
                    Console.Write("Good! Now what is the first number we're multiplying?");
                    break;
                case '/':
                    Console.Write("Good! Now what is the number we're dividing?");
                    break;
                case '+':
                    Console.Write("Good! Now what is the first number we're adding?");
                    break;
                case '-':
                    Console.Write("Good! Now what is the number being subracted from?");
                    break;
            }
            string inputnumber1 = Console.ReadLine();
            if (Double.TryParse(inputnumber1, out number1))
            {
                return true;
            }
            else
            {
                Console.WriteLine("That doesn't seem to be a valid number. Try again?");
                return false;
            }
        }

        private static bool GetNumber2(char oper, double number2)
        {
            Console.WriteLine("Hello! What type of operation are we trying today?");
            Console.WriteLine("(You can enter things like Sum, +, /, or Multiply)");
            string operatorinput = Console.ReadLine();
            switch (oper)
            {
                case '*':
                    Console.WriteLine("Good, and what nunber are we multiplying that by?");
                    break;
                case '/':
                    Console.WriteLine("Good, and what nunber are we dividing that by?");
                    break;
                case '+':
                    Console.WriteLine("Good, and what nunber are we adding that to?");
                    break;
                case '-':
                    Console.WriteLine("Good, and what nunber are we subtracting?");
                    break;
            }
            string inputnumber1 = Console.ReadLine();
            if (Double.TryParse(inputnumber1, out number2))
            {
                return true;
            }
            else
            {
                Console.WriteLine("That doesn't seem to be a valid number. Try again?");
                return false;
            }
        }
    }
}