using Classfy.Users.Domain.Author;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classfy.Users.Infra.Persistence.EF
{
    public class ClassfyUsersDbContext : DbContext
    {
        public ClassfyUsersDbContext(DbContextOptions<ClassfyUsersDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
