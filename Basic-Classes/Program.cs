using System;
using Basic_Classes.Math;
using Basic_Classes.Person;

namespace Basic_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var greg = new Person1();
            greg.FirstName = "Greg";
            greg.LastName = "Smith";
            greg.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
