using DatingAppLibrary.Commands;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private MainViewModel _context;
        public RegisterViewModel(MainViewModel Context)
        {
            _context = Context;
            BackCommand = new RelayCommand(() => { _context.SelectedViewModel = new LoginViewModel(_context); });
            RegisterUserCommand = new RelayCommand(() => { _context.SelectedViewModel = new LoginViewModel(_context); });
        }

        public ICommand BackCommand { get; set; }
        public ICommand RegisterUserCommand { get; set; }

    }
}
