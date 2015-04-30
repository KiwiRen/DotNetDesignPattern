using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class AbstractProduct
    {
        public virtual void showMessage()
        {
            Console.WriteLine("This is the base class");
        }
    }
}
