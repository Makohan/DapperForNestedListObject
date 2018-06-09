using System.Data.Entity;
using TryDapper.Models.Entities;

namespace TryDapper.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }

        public MyDbContext() : base("MyContext")
        {
        }
    }
}