using System;
namespace Adapter
{
    public class LegacyProductService
    {
        public LegacyProductPOJO findLegacyProduct()
        {
            return new LegacyProductPOJO().buildDefault();
        }
    }
}
