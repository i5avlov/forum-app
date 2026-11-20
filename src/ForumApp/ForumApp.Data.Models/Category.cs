using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)] 
        public string Name { get; set; } = null!;

        [MaxLength(1000)] 
        public string? Description { get; set; } 

        public IEnumerable<Discussion> Discussions { get; set; } = new List<Discussion>(); 
    }
}
