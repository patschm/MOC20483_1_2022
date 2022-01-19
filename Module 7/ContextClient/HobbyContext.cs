using Entities;
using Microsoft.EntityFrameworkCore;

namespace ContextClient
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions options) : base(options)
        {           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonHobby>().HasKey(p=>new { p.PersonId, p.HobbyId});
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
    }
}