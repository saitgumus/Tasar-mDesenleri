using System;
namespace Adapter
{
    public class ProductService
    {
        public ProductService()
        {
        }

        public void processProduct(Product product)
        {
            product.processProduct();
        }
    }
}
