using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class Fish : Animal, iPet
    {
        private string name;

        public Fish() : base(0)
        {
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
            Console.WriteLine("Fish don't walk...");
        }

        public void setName(string n)
        {
            this.name = n;
        }

        public new void walk()
        {
            Console.WriteLine("Fish don't walk... It has " + legs + " legs");
        }
    }
}