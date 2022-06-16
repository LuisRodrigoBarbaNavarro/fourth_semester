using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public abstract class Animal
    {
        protected int legs;

        protected Animal(int legs)
        {
            this.legs = legs;
        }

        public abstract void eat();

        public void walk()
        {
            Console.WriteLine("It has... " + legs + " legs");
        }
    }
}