using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instanceA = Singleton.getInstance();
            Singleton instanceB = Singleton.getInstance();

            String message = instanceA.Equals(instanceB) ? "These instance are the same one" : "These instance are different items";
            Console.WriteLine(message);

            AnotherSingleton instanceC = AnotherSingleton.getInstance();
            AnotherSingleton instanceD = AnotherSingleton.getInstance();

            message = instanceC.Equals(instanceD) ? "These instance are the same one" : "These instance are different items";
            Console.WriteLine(message);
            Console.Read();
        }
    }

    public class Singleton
    {
        private static Singleton instance;

        private Singleton()
        { }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }   
    }

    public class AnotherSingleton
    {
        private static readonly AnotherSingleton instance=new AnotherSingleton();

        private AnotherSingleton()
        { }

        public static AnotherSingleton getInstance()
        {
            return instance;
        }
    }
}
