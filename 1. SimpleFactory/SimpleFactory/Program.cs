using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            AbstractProduct productA = factory.generateInstance(ProductType.ProductA);
            productA.showMessage();
            AbstractProduct productB = factory.generateInstance(ProductType.ProductB);
            productB.showMessage();

            Console.Read();
        }
    }
}
