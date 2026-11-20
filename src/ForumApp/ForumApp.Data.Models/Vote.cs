using ForumApp.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Data.Models
{ 
    public class Vote
    {
        // Composite key: CommentId + VoterUserId 

        [Required]
        public int CommentId { get; set; }

        [Required]
        public string VoterUserId { get; set; } = null!; 

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required] 
        public VoteType VoteType { get; set; } = VoteType.Positive; 

        [Required]
        [ForeignKey(nameof(CommentId))] 
        public Comment Comment { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(VoterUserId))] 
        public ApplicationUser VoterUser { get; set; } = null!; 
    }
}
