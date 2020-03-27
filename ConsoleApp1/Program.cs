using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var programList = new ListClass();
            var programArray = new ArrayClass();
            var programString = new StringClass();
            var programClass = new TutClass();
            var programStringBuilder = new StringBuilderClass();
            var Person = new Person();
            //var summary = programString.SummarizeText("Test Test Test Test TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT.");
            //programStringBuilder.Excercise1();
            //programClass.StaticCheck();
            var mod = new ProgramMod();
            ProgramMod.Test();
            /*Excercise1();*/
            //Console.WriteLine(summary);
            //Person.firstName = "john";
            //Person.lastName = "doe";
            //Person.Introduce();
            // Console.WriteLine(Person);
            // programString.Excercise1();
            //programArray.Excercise1();
            //programArray.Excercise1();
            //programList.List();
            //program.Excercise1();
            // program.Excercise2();
        }


        private static void Excercise1()
        {
            var nums = new int[5] { 1, 2, 3, 4, 5 };
            var c = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (i % 3 == 0)
                    c++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3", c);
        }

        private static void Excercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }
        private static void Exercise3()
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}
