using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class ProductA:AbstractProduct
    {
        public override void showMessage()
        {
            Console.WriteLine("This is the Product A");
        }
    }
}
