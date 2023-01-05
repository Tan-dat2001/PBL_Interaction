using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL_Interaction.Entities
{
    public class Shipper
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(56)]
        public string Name { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string Hometown { get; set; }
        public int Phone { get; set; }
        public int CMND { get; set; }   

        public User User { get; set; }
    }
}