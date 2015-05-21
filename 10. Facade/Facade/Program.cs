using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.display();
            Console.Read();
        }
    }

    public class Facade
    {
        public void display()
        {
            FunctionalityA fa = new FunctionalityA();
            FunctionalityB fb = new FunctionalityB();

            fa.display();
            fb.display();
        }
    }

    public class FunctionalityA
    {
        public void display()
        {
            Console.WriteLine("This is A");
        }
    }

    public class FunctionalityB
    { 
        public void display()
        {
            Console.WriteLine("This is B");
        }
    }
}
