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
                        int groupId,
                        bool adhereToRules,
                        string explanation,
                        string discussion,
                        string conclusion)
        {
            Name = name;
            ResponsiblePerson = responsiblePerson;
            GroupId = groupId;
            AdhereToRules = adhereToRules;
            Explanation = explanation;
            Discussion = discussion;
            Conclusion = conclusion;
            DateCreated = DateTime.UtcNow;
        }

        public int Id { get; set; }

        [DisplayName("Name")]
        public String Name { get; set; }

        [DisplayName("ResponsiblePerson")]
        public int ResponsiblePerson { get; set; }

        [DisplayName("GroupId")]
        public int GroupId { get; set; }

        public Group Group { get; set; }

        [DisplayName("AdhereToRules")]
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

        //public string Category { get; set; }

        //public bool Active
        //public book chosen
        //add scoring category
    }
}