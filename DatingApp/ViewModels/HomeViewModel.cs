using DatingApp.ValueConverters;
using DatingAppLibrary.Commands;
using DatingAppLibrary.Models.Enums;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public BaseViewModel SelectedSubViewModel
        {
            get
            {
                return _selectedSubViewModel;
            }
            set
            {
                _selectedSubViewModel = value;
                OnPropertyChanged(nameof(SelectedSubViewModel));
            }
        }
        public ApplicationView CurrentSubView
        {
            get
            {
                return _currentSubView;
            }
            set
            {
                _currentSubView = value;
                SelectedSubViewModel = _currentSubView.ToViewModel(_context);
                OnPropertyChanged(nameof(CurrentSubView));
            }
        }
        public ICommand LogoutCommand { get; set; }
        public ICommand BrowseCommand { get; set; }
        public ICommand ChatCommand { get; set; }
        public HomeViewModel(MainViewModel Context)
        {
            _context = Context;
            if (_context.CurrentUser.UserProfile == null)
            {
                CurrentSubView = ApplicationView.Login;
            }
            else
            {
                CurrentSubView = ApplicationView.Chat;
            }
            LogoutCommand = new RelayCommand(() => { _context.CurrentUser = null; });
            BrowseCommand = new RelayCommand(() => { CurrentSubView = ApplicationView.Browse; });
            ChatCommand = new RelayCommand(() => { CurrentSubView = ApplicationView.Chat; });
        }

        private readonly MainViewModel _context;
        private BaseViewModel _selectedSubViewModel;
        private ApplicationView _currentSubView;
    }
}
