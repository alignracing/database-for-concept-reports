using System.Collections.Generic;
using database_for_concept_reports.Models;

namespace database_for_concept_reports

{
    public class Tag
    {
        public Tag(){}
        public Tag(string name)
        {
            Name = name;
            //TODO: Ask Abuy why???
            //ConceptTags = new List<ConceptTag>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ConceptTag> ConceptTags { get; set; }
    }
}