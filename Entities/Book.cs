using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL_Interaction.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        public int Price { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public string Author { get; set; }
        [ForeignKey("State")]
        public int StateId { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; } // 1 category nhieu sach
        public State State { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; }
    }
}