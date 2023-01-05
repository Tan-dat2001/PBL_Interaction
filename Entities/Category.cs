using System.ComponentModel.DataAnnotations;

namespace PBL_Interaction.Entities
{
    public class Category
    {
        [Key] //khóa chính
        public int Id { get; set; }
        [Required]
        [MaxLength(32)] //ràng buộc dữ liệu (32 kí tự)
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } // 1 category cos nhieu sach
    }
}