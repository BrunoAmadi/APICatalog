using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalog.Models

{
    [Table("Products")]
    public class Product
    {

        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(80)]
        public string? Name { get; set; }

        [Required]
        [StringLength(300)]
        public string? Description { get; set; }

        [Column(TypeName = "decimal(10,4)")]
        public double Price { get; set; }

        [Required]
        [StringLength(300)]
        public string? UrlImage { get; set; }

        public float Stock { get; set; }
        public DateTime DataRegister { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
