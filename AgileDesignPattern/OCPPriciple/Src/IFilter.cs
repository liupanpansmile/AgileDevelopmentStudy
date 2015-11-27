using System.Collections.Generic;
using System.Linq;

namespace OCPPriciple
{
    interface IFilter
    {
        IList<IProduct> Filter(IList<IProduct> productList, ISpecification specification);
    }

    public class ProductFilter : IFilter
    {
        public IList<IProduct> Filter(IList<IProduct> productList, ISpecification specification)
        {
            if (productList == null || specification == null)
                return null;

            return productList.Where(product => specification.IsMatched(product)).ToList();
        }
    }
}
