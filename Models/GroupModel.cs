namespace database_for_concept_reports

{
    public class Group
    {
        public Group(){}
        public Group(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}