using System;

namespace UnitTestingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

           var answer = calc.Add(4, 8, 4);

            Console.WriteLine(answer);
        }
    }
}
