using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwareStore.Infrastructure.Data
{
    public class Cart
    {
        public Cart()
        {
            TottalPrice = Items.Sum(x => x.Price);
        }
        public Guid Id { get; set; } = Guid.NewGuid();

        public IList<Item> Items { get; set; } = new List<Item>();

        public decimal TottalPrice { get; set; }
    }
}
