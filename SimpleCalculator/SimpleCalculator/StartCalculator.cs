using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class StartCalculator
    {
        private double Num1 { get; set; }
        private double Num2 { get; set; }

        private double Total { get; set; }
        private int Choice { get; set; }

        private Boolean isValid = true;
        string num1;
        string num2;

        public void getInputs()
        {
            Console.WriteLine("Enter 2 numbers:");
            num1 = Console.ReadLine();
            num2 = Console.ReadLine();

            if (Validation.IsAllDigits(num1) == true && Validation.IsAllDigits(num2) == true)
            {
                Num1 = double.Parse(num1);
                Num2 = double.Parse(num2);
            }
            else
            {
                Console.WriteLine("Invalid entry, try again.");
                getInputs();
            }
        }
        public void Calculator()
        {
            try
            {
                do
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1: Add");
                    Console.WriteLine("2: Subtract");
                    Console.WriteLine("3: Multiply");
                    Console.WriteLine("4: Divide");
                    Console.WriteLine("5: Quit");

                    Choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------");


                    switch (Choice)
                    {
                        case 1:
                            Addition addition = new Addition();
                            Total = addition.addNumbers(Num1, Num2);
                            Console.WriteLine($"Answer: {Num1} + {Num2} = {Total}\n");
                            isValid = true;
                            break;
                        case 2:
                            Subtract subtraction = new Subtract();
                            Total = subtraction.subtractNumbers(Num1, Num2);
                            Console.WriteLine($"Answer: {Num1} - {Num2} = {Total}\n");
                            isValid = true;
                            break;
                        case 3:
                            Multiply multiplication = new Multiply();
                            Total = multiplication.multiplyNumbers(Num1, Num2);
                            Console.WriteLine($"Answer: {Num1} x {Num2} = {Total}\n");
                            isValid = true;
                            break;
                        case 4:
                            Divide division = new Divide();
                            Total = division.divideNumbers(Num1, Num2);
                            Console.WriteLine($"Answer: {Num1} / {Num2} = {Total}\n");
                            isValid = true;
                            break;
                        case 5:
                            Console.WriteLine("Quit");
                            break;
                        default:
                            Console.WriteLine("Invalid choice\n");
                            isValid = false;
                            break;
                    }
                } while (isValid != true);
            }
            catch (Exception)
            {
                Console.WriteLine("Error occurred!");
                Calculator();
            }

        }
    }
}