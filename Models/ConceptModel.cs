using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace database_for_concept_reports.Models
{
    public class Concept
    {
        public Concept(){}

        public Concept( string title,
                        int responsiblePerson,
                        int groupId,
                        string explanation,
                        string discussion,
                        string conclusion)
        {
            Title = title;
            ResponsiblePerson = responsiblePerson;
            GroupId = groupId;
            Explanation = explanation;
            Discussion = discussion;
            Conclusion = conclusion;

            DateCreated = DateTime.UtcNow;
            Active = true;
        }

        public int Id { get; set; }

        public String Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateModified { get; set; }

        public bool Active { get; set; }

        public int ResponsiblePerson { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    
        public ICollection<ConceptTag> ConceptTags  { get; } = new List<ConceptTag>();

        public bool? AdheresToRules { get; set; }

        public string Explanation { get; set; }

        public string Discussion { get; set; }

        public string Conclusion { get; set; }
    }
}