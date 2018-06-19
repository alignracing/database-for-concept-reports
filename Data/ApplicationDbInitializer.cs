using System.Collections.Generic;
using System.Linq;
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

            dbContext.Groups.AddRange(new List<Group>{
                new Group("Powertrain"),
                new Group("Suspension"),
                new Group("Frame")});

            dbContext.SaveChanges();

            var groups = dbContext.Groups.ToList();

            string gibberish = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsumhas been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

            var concepts = new List<Concept>();

            for (int i = 1; i <= 5; i++){
                var concept = new Concept("Concept report ", 12, gibberish, gibberish, gibberish);
                concept.Group = groups[0];
                concepts.Add(concept);
            }

            var tags = new List<Tag>();
            
            tags.AddRange(new List<Tag>{
                new Tag("Petrol"),
                new Tag("Important"),
                new Tag("In progress")
            });

            dbContext.Tags.AddRange(tags);
            dbContext.Concepts.AddRange(concepts);

            // dbContext.AddRange(
            //     new ConceptTag { Concept = concepts[0], Tag = tags[0] },
            //     new ConceptTag { Concept = concepts[0], Tag = tags[1] },
            //     new ConceptTag { Concept = concepts[0], Tag = tags[2] },
            //     new ConceptTag { Concept = concepts[3], Tag = tags[0] },
            //     new ConceptTag { Concept = concepts[4], Tag = tags[0] }
            // );

            var concepTags = new List<ConceptTag>();
            concepTags.AddRange(new List<ConceptTag>{
                new ConceptTag(concepts[0], tags[0]),
                new ConceptTag(concepts[0], tags[1]),
                new ConceptTag(concepts[0], tags[2])
            });

            dbContext.AddRange(concepTags);
            
            dbContext.SaveChanges();
        }
    }
}