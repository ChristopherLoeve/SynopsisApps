namespace Synopsis.Models
{
    public class MovieCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MovieCategory()
        {

        }

        public MovieCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id}: {Name}";
        }
    }
}
