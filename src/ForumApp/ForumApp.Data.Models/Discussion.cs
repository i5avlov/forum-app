using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Data.Models
{
    public class Discussion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = null!;

        [MaxLength(2000)] 
        public string? Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public string OpenerUserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(OpenerUserId))] 
        public ApplicationUser OpenerUser { get; set; } = null!;

        public IEnumerable<Comment> Comments { get; set; } = new List<Comment>(); 
    }
}
