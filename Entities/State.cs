//thể hiện trạng thái hoạt động hay ko
using System.ComponentModel.DataAnnotations;

namespace PBL_Interaction.Entities
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(32)]
        public int Name { get; set; }

        public Book Book { get; set; }
        public User User { get; set; }
    }
}