using ModernDesign.Core;
using ModernDesign.MVVM.View;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel: ObservableObject
    {
        public RelayCommand HomeViewCommand{ get; set; }
        public RelayCommand DiscoverViewCommand{ get; set; }
        public HomeViewModel HomeVM { get; set; }
        public DiscoverViewModel DiscoverVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoverVM = new DiscoverViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            DiscoverViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoverVM;
            });
        }
    }
}
