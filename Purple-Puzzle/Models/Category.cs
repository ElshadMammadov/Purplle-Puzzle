namespace Purple_Puzzle.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}
  