using Microsoft.VisualBasic.CompilerServices;

namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        //While loop for Calulator to run until "Exit" selected
        while (true)
        {
            Console.Write("Welcome to Calculator. \n Please insert two Integer numbers. \n");
            
            Console.WriteLine("Please insert first int number : ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Please insert second int number : ");
            string num2 = Console.ReadLine();
            
            if (!int.TryParse(num1, out int number1)  || !int.TryParse(num2, out int number2) )
            {
                throw new Exception(" Argument of illegal type, int expected"); 
            }
            Console.WriteLine("Choose your mathematical operation :  \n Addition \n Subtraction \n Division \n Multiplication \n Exit ");
            string menuSeletion = Console.ReadLine().ToLower();

            switch (menuSeletion)
            {
                case ("addition"):
                    Console.WriteLine("Sum is : " + (number1 + number2));
                    break;
                case ("multiplication"):
                    Console.WriteLine("Multiplication is : " + (number1 * number2));
                    break;
                case ("subtraction"):
                    Console.WriteLine("Delta is : " + Math.Abs(number1 + number2));
                    break;
                case ("division"):
                    if (number2 == 0)
                    {
                        Console.WriteLine("Division by zero not permitted");
                        break;
                    }
                    Console.WriteLine("Division is : " + (number1 / number2));
                    break;
                case ("exit"):
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("No keyword!");
                    throw new Exception("Illegal Argument, expected keyword !");
            }
            Console.WriteLine("\n ********* \n \n ");
            
        }
    }
}