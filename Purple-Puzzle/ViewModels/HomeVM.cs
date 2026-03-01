using Purple_Puzzle.Models;

namespace Purple_Puzzle.ViewModels
{
    public class HomeVM
    {
        public List<Work> Works { get; set; }
        public List<Category> Categories { get; set; }
        public List<Slider> Sliders { get; set; }
        public SliderImage SliderImage { get; set; }
    }
}
