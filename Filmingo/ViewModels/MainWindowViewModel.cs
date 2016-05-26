using Prism.Mvvm;

namespace Filmingo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Filmingo";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
