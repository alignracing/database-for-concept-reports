using System;
using System.ComponentModel.DataAnnotations;

namespace database_for_concept_reports.Models
{
    public class Concept
    {
        public Concept(){}

        public Concept( string name,
                        int responsiblePerson,
                        int group,
                        bool adhereToRules,
                        string explanation,
                        string discussion,
                        string conclusion)
        {
            Name = name;
            ResponsiblePerson = responsiblePerson;
            Group = group;
            AdhereToRules = adhereToRules;
            Explanation = explanation;
            Discussion = discussion;
            Conclusion = conclusion;
            DateCreated = DateTime.UtcNow;
        }

        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public int ResponsiblePerson { get; set; }

        [Required]
        public int Group { get; set; }

        [Required]
        public bool AdhereToRules { get; set; }

        public string Explanation { get; set; }
        public string Discussion { get; set; }
        public string Conclusion { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}