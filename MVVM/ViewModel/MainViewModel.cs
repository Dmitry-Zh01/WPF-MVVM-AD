using System;
using ohb.Core;

namespace ohb.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
    	
    	public RelayCommand HomeViewCommand { get; set; }
    	public RelayCommand DViewCommand { get; set; }


    	public HomeViewModel HomeVM { get; set; }
    	public DViewModel DVM { get; set; }

              
        private object _currentView;

        public object CurrentView 
        {
            get { return _currentView; } 
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DVM = new DViewModel();
            
            CurrentView = HomeVM;
            

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DViewCommand = new RelayCommand(o =>
            {
                CurrentView = DVM;
            });
            
        }
    }
}
