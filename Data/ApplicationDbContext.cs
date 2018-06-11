using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using database_for_concept_reports.Models;

namespace database_for_concept_reports.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConceptTag>()
            .HasKey(t => new { t.ConceptId, t.TagId });

            modelBuilder.Entity<ConceptTag>()
            .HasOne(pt => pt.Concept)
            .WithMany(p => p.ConceptTags)
            .HasForeignKey(pt => pt.ConceptId);

            modelBuilder.Entity<ConceptTag>()
            .HasOne(pt => pt.Tag)
            .WithMany(t => t.ConceptTags)
            .HasForeignKey(pt => pt.TagId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Concept> Concepts { get; set; }
    }
}
