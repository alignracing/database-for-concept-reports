namespace database_for_concept_reports

{
    public class Category
    {
        public Category(){}
        public Category(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}