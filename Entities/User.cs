using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL_Interaction.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public int Name { get; set; }
        public string Password  { get; set; }
        public string Email { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        [ForeignKey("State")]
        public int StateId { get; set; }    
        public State State { get; set;}
        public Role Role { get; set; }

        public Shipper Shipper { get; set; }    
        public ICollection<Order> Orders { get; set; }
    }
}