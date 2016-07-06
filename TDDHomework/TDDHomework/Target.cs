using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomework
{
    internal class Target
    {
        private IList<Product> products;

        internal Target(IList<Product> products)
        {
            this.products = products;
        }

        public IEnumerable<int> SubTotal(int groupSize, string columnName)
        {
            var result = products
                            .Select((product, index) => new { product, index })
                            .GroupBy(g => g.index / groupSize, x => x.product)
                            .Select(x => x.Sum(y => (int)y.GetType().GetProperty(columnName).GetValue(y)))
                            .ToArray();
            return result;
        }
    }
}
