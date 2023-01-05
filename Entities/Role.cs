

using System.ComponentModel.DataAnnotations;

namespace PBL_Interaction.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }

        public User User { get; set; }
    }
}