using System;
using System.Collections.Generic;
using System.Text;

namespace TAR4
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
   sealed class Cat : Animal
    {
        public void Purr()
        {
            Console.WriteLine("Purr..");
        }
    }
}
