using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            IFactory factoryFamilyA = new FactoryFamilyA();
            ProductA productAFamilyA = factoryFamilyA.getProductAInstance();
            ProductB productBFamilyA = factoryFamilyA.getProductBInstance();

            productAFamilyA.showMessage();
            productBFamilyA.showMessage();

            IFactory factoryFamilyB = new FactoryFamilyB();
            ProductA productAFamilyB= factoryFamilyB.getProductAInstance();
            ProductB productBFamilyB = factoryFamilyB.getProductBInstance();

            productAFamilyB.showMessage();
            productBFamilyB.showMessage();

            Console.Read();
        }
    }

    public abstract class ProductA
    {
        public virtual void showMessage()
        {
            Console.WriteLine("This is the base class of Product A");
        }
    }

     public abstract class ProductB
    {
        public virtual void showMessage()
        {
            Console.WriteLine("This is the base class of Product B");
        }
    }

    public class ProductAFamilyA : ProductA
    {
        public override void showMessage()
        {
            Console.WriteLine("This is Product A in Family A");
        }
    }

    public class ProductBFamilyA : ProductB
    {
        public override void showMessage()
        {
            Console.WriteLine("This is Product B in Family A");
        }
    }

    public class ProductAFamilyB : ProductA
    {
        public override void showMessage()
        {
            Console.WriteLine("This is Product A in Family B");
        }
    }

    public class ProductBFamilyB : ProductB
    {
        public override void showMessage()
        {
            Console.WriteLine("This is Product B in Family B");
        }
    }

    public interface IFactory
    {
        ProductA getProductAInstance();
        ProductB getProductBInstance();
    }

    public class FactoryFamilyA : IFactory
    {
        public ProductA getProductAInstance()
        { 
            ProductA product = new ProductAFamilyA();
            return product;
        }

        public ProductB getProductBInstance()
        {
            ProductB product = new ProductBFamilyA();
            return product;
        }

    }

    public class FactoryFamilyB : IFactory
    {
        public ProductA getProductAInstance()
        {
            ProductA product = new ProductAFamilyB();
            return product;
        }

        public ProductB getProductBInstance()
        {
            ProductB product = new ProductBFamilyB();
            return product;
        }

    }
}
