using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Spider spider = new Spider();
            Cat cat = new Cat("Garfield");
            Fish fish = new Fish();

            spider.eat();
            spider.walk();
            Console.ReadLine();

            cat.eat();
            cat.play();
            cat.walk();
            Console.ReadLine();

            fish.setName("Nemo");
            fish.eat();
            fish.play();
            fish.walk();
            Console.ReadLine();
        }
    }
}
