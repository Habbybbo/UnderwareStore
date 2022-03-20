using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnderwareStore.Infrastructure.Data
{
    public class Item
    {
        [Key]
        public int Id { get; init; }

        [Required]
        [StringLength(30)]
        public string Barcode { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        public int? Size { get; set; }

        public string? SizeInternational { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string Matter { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [ForeignKey(nameof(Seller))]
        public Guid SellerId { get; init; }

        public Seller Seller { get; init; }
    }
}
