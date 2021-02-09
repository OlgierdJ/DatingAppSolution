using DatingApp.ValueConverters;
using DatingAppLibrary.Models.Enums;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly MainViewModel _mainContext;
        private BaseViewModel _selectedSubViewModel;
        private ApplicationView _currentSubView;

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
                SelectedSubViewModel = _currentSubView.ToViewModel(_mainContext);
                OnPropertyChanged(nameof(CurrentSubView));
            }
        }
        public HomeViewModel(MainViewModel MainContext)
        {
            _mainContext = MainContext;
            CurrentSubView = ApplicationView.Chat;
        }
    }
}
