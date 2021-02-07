using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private MainViewModel _mainContext;
        public HomeViewModel(MainViewModel MainContext)
        {
            _mainContext = MainContext;
        }

        public ICommand UpdateViewCommand
        {
            get
            {
                return _mainContext.UpdateViewCommand;
            }
        }
    }
}
