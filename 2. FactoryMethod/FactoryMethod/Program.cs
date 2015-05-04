using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the product instance by choosing the specific factory and user don't need to know the name of product
            IFactory factory = new FactoryA();
            AbstractProduct productA = factory.createInstance();
            productA.showMessage();

            factory = new FactoryB();
            AbstractProduct productB = factory.createInstance();
            productB.showMessage();

            Console.Read();
        }
    }

    public interface IFactory
    {
        AbstractProduct createInstance();
    }

    public abstract class AbstractProduct
    {
        public virtual void showMessage()
        {
            Console.WriteLine("This is abstract product");
        }
    }

    public class ProductA : AbstractProduct
    {
        public override void showMessage()
        {
            Console.WriteLine("This is productA");
        }
    }

    public class ProductB : AbstractProduct
    {
        public override void showMessage()
        {
            Console.WriteLine("This is productB");
        }
    }

    public class FactoryA : IFactory
    {
        public AbstractProduct createInstance()
        {
            AbstractProduct product = new ProductA();
            return product;
        }
    }

    public class FactoryB : IFactory
    {
        public AbstractProduct createInstance()
        {
            AbstractProduct product = new ProductB();
            return product;
        }
    }
}
