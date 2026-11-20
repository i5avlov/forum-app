using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(2000)] 
        public string Text { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [Required]
        public string AuthorUserId { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(AuthorUserId))] 
        public ApplicationUser AuthorUser { get; set; } = null!;

        [Required]
        public int DiscussionId { get; set; }

        [Required]
        [ForeignKey(nameof(DiscussionId))] 
        public Discussion Discussion { get; set; } = null!;

        public IEnumerable<Vote> Votes { get; set; } = new List<Vote>(); 
    }
}
