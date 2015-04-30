using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class Factory
    {
        public AbstractProduct generateInstance(ProductType type)
        {
            switch (type)
            {
                case ProductType.ProductA:
                    return new ProductA();

                case ProductType.ProductB:
                    return new ProductB();
                default:
                    return null;
            }
        }

    }

    public enum ProductType
    {
        ProductA, ProductB
    }
}
