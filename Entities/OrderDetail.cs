using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL_Interaction.Entities
{
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Order Order { get; set; }

        public Book Book { get; set; }
    }
}