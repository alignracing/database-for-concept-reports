using System;
using System.ComponentModel;
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

        [DisplayName("Name")]
        public String Name { get; set; }

        [DisplayName("Responsible Person")]
        public int ResponsiblePerson { get; set; }

        [DisplayName("Group")]
        public int Group { get; set; }

        [DisplayName("Adhere To Rules")]
        public bool AdhereToRules { get; set; }

        [DisplayName("Explanation")]
        public string Explanation { get; set; }

        [DisplayName("Discussion")]
        public string Discussion { get; set; }

        [DisplayName("Conclusion")]
        public string Conclusion { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateModified { get; set; }
    }
}