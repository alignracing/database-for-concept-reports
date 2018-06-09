using System;
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
        }

        public int Id { get; set; }

        public String Title { get; set; }

        [DisplayName("ResponsiblePerson")]
        public int ResponsiblePerson { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }

        public bool? AdheresToRules { get; set; }

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