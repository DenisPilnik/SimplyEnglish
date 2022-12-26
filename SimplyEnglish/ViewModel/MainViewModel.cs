using GalaSoft.MvvmLight;

namespace SimplyEnglish.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string Title { get; set; }
        public MainViewModel()
        {
            Title = "Study English";
        }
    }
}