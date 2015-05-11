using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget objectA = new NormalTarget();
            objectA.ProcessRequest();
            //Adapter class is used to convert the old method to new specification
            ITarget objectB = new Adapter();
            objectB.ProcessRequest();

            Console.Read();
        }
    }

    public interface ITarget
    {
        void ProcessRequest();
    }

    public class NormalTarget:ITarget
    {

        public void ProcessRequest()
        {
            Console.WriteLine("This is used to process normal request");
            
        }
    }

    public class Adapter :Adaptee,ITarget
    {
        public void ProcessRequest()
        {
            base.ProcessOldRequest();
        }
    }

    public class Adaptee
    {
        public void ProcessOldRequest()
        {
            Console.WriteLine("This is used to process old request");

        }  
    }
}
