using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class Cat : Animal, iPet
    {
        private string name;

        public Cat(string n) : base(4)
        {
            this.name = n;
        }

        public override void eat()
        {
            Console.WriteLine(name + " is eating...");
        }

        public string getName()
        {
            return name;
        }

        public void play()
        {
            Console.WriteLine(name + " is playing...");
        }

        public void setName(string n)
        {
            this.name = n;
        }
    }
}