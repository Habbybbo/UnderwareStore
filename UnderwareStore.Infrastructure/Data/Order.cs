using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnderwareStore.Infrastructure.Data
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [ForeignKey(nameof(Customer))]
        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey(nameof(Cart))]
        public Guid CartId { get; set; }

        public Cart Cart { get; set; }

        public bool Compleated { get; set; } = false;
    }
}