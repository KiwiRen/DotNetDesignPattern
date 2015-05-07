using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(new BuilderA());
            director.createProduct();

            director = new Director(new BuilderB());
            director.createProduct();

            Console.Read();

        }
    }

    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
    }

    public class BuilderA : IBuilder
    {
        public void BuildPartA()
        {
            Console.WriteLine("Builder A build the partA");
        }

        public void BuildPartB()
        {
            Console.WriteLine("Builder A build the partB");
        }
    }

    public class BuilderB : IBuilder
    {
        public void BuildPartA()
        {
            Console.WriteLine("Builder B build the partA");
        }

        public void BuildPartB()
        {
            Console.WriteLine("Builder B build the partB");
        }
    }

    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void createProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    
    }
}
