using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL_Interaction.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Payment")]
        public int PaymentId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Note { get; set; }
        public int ShipperId { get; set; }
        public int StateId { get; set; }    

        public User User { get; set; }
        public Payment Payment { get; set; }
        public IList<OrderDetail> OrderDetails { get; set; } // quan he nhieu - nhieu
    }
}