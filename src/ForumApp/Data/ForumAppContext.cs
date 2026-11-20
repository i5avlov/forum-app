using ForumApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data;

public class ForumAppContext : IdentityDbContext<IdentityUser> 
{
    public ForumAppContext() 
    {
    } 

    public ForumAppContext(DbContextOptions<ForumAppContext> options)
        : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; } 

    public DbSet<Category> Categories { get; set; } 

    public DbSet<Discussion> Discussions { get; set; } 

    public DbSet<Comment> Comments { get; set; } 

    public DbSet<Vote> Votes { get; set; } 

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Vote>(entity =>
        {
            entity.HasKey(v => new { v.CommentId, v.VoterUserId }); 
        }); 
    }
}
