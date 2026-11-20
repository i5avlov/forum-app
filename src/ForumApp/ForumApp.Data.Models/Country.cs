using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)] 
        public string Name { get; set; } = null!;

        public IEnumerable<ApplicationUser> Users { get; set; } = new List<ApplicationUser>(); 
    }
}
