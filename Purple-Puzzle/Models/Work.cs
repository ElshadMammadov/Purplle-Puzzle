namespace Purple_Puzzle.Models
{
    public class Work : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
