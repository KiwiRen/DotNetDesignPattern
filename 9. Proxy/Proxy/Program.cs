using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Proxy();

            subject.ProcessResponse();

            Console.Read();
        }
    }

    public interface ISubject
    {
        void ProcessResponse();
    }

    public class Subject:ISubject
    {
        public void ProcessResponse()
        {
            Console.WriteLine("Process Response");
        }
    }

    public class Proxy :ISubject
    {
        private Subject subject = new Subject();

        public void ProcessResponse()
        {
            Console.WriteLine("Pre-Process Response");
            subject.ProcessResponse();
            Console.WriteLine("Finish-Process Response");
        
        }
    
    }
}
