using System;
namespace Adapter
{
    public interface Product
    {

        String getName();

        double getPrice();

        String productType();

        void processProduct();

        bool isProcessed();

    }
}
