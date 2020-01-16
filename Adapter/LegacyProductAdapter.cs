using System;
namespace Adapter
{

    public class LegacyProductAdapter: Product
    {

    private bool processed;
    private LegacyProductPOJO legacyProductPOJO;

    public LegacyProductAdapter(LegacyProductPOJO legacyProductPOJO)
    {
        this.legacyProductPOJO = legacyProductPOJO;
    }

    public String getName()
    {
        return legacyProductPOJO.getA01();
    }

    public double getPrice()
    {
        return Convert.ToDouble(legacyProductPOJO.getA02());
    }

    public String productType()
    {
        return legacyProductPOJO.getA03();
    }

    
    public void processProduct()
    {
        Console.WriteLine("Processing product..");
        processed = true;
    }

    
    public bool isProcessed()
    {
        return processed;
    }

}

}
