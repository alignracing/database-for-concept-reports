using database_for_concept_reports.Models;

namespace database_for_concept_reports
{
    public class ConceptTag
    {
        public ConceptTag(){}

        public int ConceptId { get; set; }
        public Concept Concept { get; set; }
 
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}