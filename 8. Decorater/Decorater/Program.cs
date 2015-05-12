using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorater
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct product = new ConcreateProduct();
            product.showProductMessage();

            IProduct newProduct = new DecoraterA(product);
            newProduct.showProductMessage();
            Console.Read();
        }
    }

    public interface IProduct
    {
        void showProductMessage();
    }

    public class ConcreateProduct : IProduct
    {
        public void showProductMessage()
        { 
            Console.WriteLine("This is the original concreate product");
        }
    }

    public abstract class Decorater:IProduct
    {
        public IProduct concreateProduct;
        public Decorater(IProduct product)
        {
            concreateProduct = product;
        }

        public abstract void showProductMessage();
    }

    public class DecoraterA : Decorater
    {
        public DecoraterA(IProduct product):base(product)
        {
        }

        public override void showProductMessage()
        {
            concreateProduct.showProductMessage();
            Console.WriteLine("DecoraterA add a new attribute to product");
        }
    }
}
