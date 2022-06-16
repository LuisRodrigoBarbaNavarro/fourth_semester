using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class Spider : Animal
    {
        public Spider() : base(8) 
        {
        }

        public override void eat()
        {
           Console.WriteLine("It is eating..."); 
        }
    }
}