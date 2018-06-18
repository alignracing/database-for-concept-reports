using database_for_concept_reports.Models;

namespace database_for_concept_reports
{
    public class ConceptTag
    {
        public ConceptTag(){}
        public ConceptTag(Concept concept, Tag tag)
        {
            Concept = concept;
            Tag = tag;
        }

        public int ConceptId { get; set; }
        public Concept Concept { get; set; }
 
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}