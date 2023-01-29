using System;
using VSIXProject1.Commands;
using VSIXProject1.Core;

namespace VSIXProject1.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

		public RelayCommand HomeViewCommand { get; set; }
		public RelayCommand DocumentingViewCommand { get; set; }

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

		public HomeViewModel HomeView { get; set; }
        public DocumentingViewModel DocumentView { get; set; }
        public MainViewModel()
		{
			HomeView = new HomeViewModel();
			DocumentView = new DocumentingViewModel();
			CurrentView = HomeView;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = HomeView;
			});

            DocumentingViewCommand = new RelayCommand(o =>
            {
                CurrentView = DocumentView;
            });
        }
	}
}
