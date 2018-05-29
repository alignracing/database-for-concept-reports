using database_for_concept_reports.Data;
using database_for_concept_reports.Models;
using Microsoft.AspNetCore.Identity;

namespace database_for_concept_reports.Data
{
    public static class ApplicationDbInitializer
    {
        public static void Initialize(ApplicationDbContext dbContext, UserManager<ApplicationUser> um, bool development)
        {
            if (!development)
            {
                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
                return;
            }
            
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            string gibberish = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsumhas been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

            for (int i = 1; i <= 20; i++){
                dbContext.Concepts.Add(new Concept("Concept "+i, i, 12, true, gibberish, gibberish, gibberish));
            }

            dbContext.SaveChanges();
        }
    }
}