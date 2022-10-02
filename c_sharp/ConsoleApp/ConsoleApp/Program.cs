using ConsoleApp.entity;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        const string BIRTH_DAY = "08/12/1993";

        static void Main(string[] args)
        {
            // numberTypes();
            // stringType()
            // ConsoleClass();
            // ConsoleColors();
            // CastingImplicitExplicit();
            // parseIntFromString();
            // StringManipulation();
            // printConst();
            // sumOfTwoNumber();
            //ObjectsPlaygroud();
            arrays();
        }

        static void numberTypes()
        {
            int num1 = 12;
            int num2 = 23;
            int sum = num1 + num2;
            Console.WriteLine("num1 is" + num1);
            Console.WriteLine(num1 + "+" + num2 + "=" + sum);

            int num3, num4, num5;

            double d1 = 3.145;
            double d2 = 32.534;
            double dDiv = d1 / d2;
            Console.WriteLine("d1 / d2 is " + dDiv);


            float f1 = 3.145f;
            float f2 = 32.534f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            double dDivFloat = d1 / f2;
            Console.WriteLine("d1/f2 is " + dDivFloat);
        }


        static void stringType()
        {
            string myName = "Gal";
            Console.WriteLine("My name is  " + myName.ToUpper());
        }


        static void ConsoleClass()
        {
            // Print in the same line
            Console.Write("Gal");
            Console.Write(" Rabin");

            // Print new line
            Console.WriteLine("Gal Rabin");
            Console.WriteLine("Miryam Rabin");

            // ReadKey
            Console.WriteLine(Console.ReadKey());

            // Read single char ascii
            int read = Console.Read();
            Console.WriteLine("Read: " + read);

            // Read line
            string readLine = Console.ReadLine();
            Console.WriteLine("ReadLine: " + readLine);
        }

        static void ConsoleColors()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Gray;

            Console.Clear();
            Console.WriteLine("Hello");

            Console.ReadKey();
            Console.ResetColor();

            Console.WriteLine("Hello");
        }

        static void CastingImplicitExplicit()
        {
            double d1 = 3.154;
            int n1;

            // Explicit
            n1 = (int)d1;


            // Implicit
            float f1 = 3.212f;
            double d2 = f1;

            // Type conversion
            string myDouble = d1.ToString();
            string myFloat = f1.ToString();
        }

        static void parseIntFromString()
        {
            string num1 = "11";
            string num2 = "12";
            int sum = int.Parse(num1) + int.Parse(num2);

            Console.WriteLine("num1 + num2 is " + sum);
        }

        static void assignmentOne()
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int
            float f1 = float.Parse(stringForFloat);
            int n1 = int.Parse(stringForInt);
        }

        static void StringManipulation()
        {
            // concatenation
            string messagePartOne = "Gal";
            string messagePartTwo = "Rabin";
            Console.WriteLine(messagePartOne + messagePartTwo);

            // Formatting
            string sentenceOne = String.Format("{0} {1}", messagePartOne, messagePartTwo);
            Console.WriteLine(sentenceOne);
            Console.WriteLine("{0} {1}", "Gal", "Rabin");

            // Interpolation
            Console.WriteLine($"{messagePartOne} {messagePartTwo}");

            // Verbatim
            Console.WriteLine(@"
It should take the string as is \n


This should be after two line seprators
");
        }

        static void printConst()
        {
            Console.WriteLine(BIRTH_DAY);
        }

        static void sumOfTwoNumber()
        {
            int num1, num2;
            Console.WriteLine("Please enter first number:");
            try
            {
                num1 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw;
            }

            Console.WriteLine("Please enter second number:");
            try
            {
                num2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                throw;
            }


            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        private static void ObjectsPlaygroud()
        {
            User user = new User("Gal", "Rabin", "galrabin@gmail.com");
            Console.WriteLine($"User {user}");
        }

        private static void arrays()
        {
            int[] samples = new int[10];
            samples[0] = 1;
            samples[2] = 1;

            int[] samplesOther = { 1, 2, 3 };

            int[] sampleanotherOne = new int[] { 1, 2, 3 };

            Console.WriteLine($"The length of {sampleanotherOne.Length}");



            foreach (int k in samples)
            {
                Console.WriteLine($" Hello {k}");
            }
        }
    }
}
