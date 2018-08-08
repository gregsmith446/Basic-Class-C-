using System;

namespace Basic_Classes.Person
{
    public class Person1
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is " + FirstName + " " + LastName);
        }
    }
}
