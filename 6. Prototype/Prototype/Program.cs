using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreatePrototype objectA = new ConcreatePrototype();
            objectA.state = "A: Processing";
            //This clone is deep clone 
            ConcreatePrototype objectB = (ConcreatePrototype)objectA.Clone();
            Console.WriteLine(objectB.state);
            //the change of Object b will not affect objectA
            objectB.state = "B: Pending";
            Console.WriteLine(objectB.state);
            Console.WriteLine(objectA.state);
            //Shadow Copy
            ConcreatePrototype objectC = objectA;
            Console.WriteLine(objectC.state);
            objectC.state = "C:Pending";
            //the change of objectC will affect objectA
            Console.WriteLine(objectC.state);
            Console.WriteLine(objectA.state);
            Console.Read();

       
        }
    }

    public class ConcreatePrototype : ICloneable
    {
        private string _state;
        public string state
        {
            get { return _state; }
            set { _state = value; }
        }

        public ConcreatePrototype()
        {
            state = "Initialize";
        }

        public object Clone()
        { 
            ConcreatePrototype prototype = new ConcreatePrototype();
            prototype.state = this.state;

            return prototype;
        }
    }


}
