using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomework
{
    public class Target
    {
        private IList<Product> products;

        internal Target(IList<Product> products)
        {
            this.products = products;
        }

        public IEnumerable<int> SubTotal(int groupSize, string columnName)
        {
            IEnumerable<int> result = new List<int>();
            return result;
        }
    }
}
