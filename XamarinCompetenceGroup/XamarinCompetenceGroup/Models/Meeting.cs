using PropertyChanged;

namespace XamarinCompetenceGroup.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Meeting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
