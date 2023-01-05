using System.ComponentModel.DataAnnotations;

namespace PBL_Interaction.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        public int Name { get; set; }

        public Order Order { get; set; }

        
    }
}