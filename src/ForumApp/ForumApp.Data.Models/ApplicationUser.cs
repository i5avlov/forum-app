using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForumApp.Data.Models
{
    public class ApplicationUser : IdentityUser 
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; } = null!;

        [Required]
        public DateOnly Birthdate { get; set; }

        [Required]
        public int CountryId { get; set; } 

        [Required]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [InverseProperty("AuthorUser")] 
        public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();

        [InverseProperty("VoterUser")] 
        public IEnumerable<Vote> Votes { get; set; } = new List<Vote>();

        [InverseProperty("OpenerUser")]
        public IEnumerable<Discussion> OpenDiscussions { get; set; } = new List<Discussion>(); 
    }
}
