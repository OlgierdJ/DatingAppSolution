using DatingApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DatingApp.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private readonly MainViewModel _context;
        public UpdateViewCommand(MainViewModel mainContext)
        {
            _context = mainContext;
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "LoginView")
            {
                _context.SelectedViewModel = new LoginViewModel(_context);
            }
            else if (parameter.ToString() == "RegisterView")
            {
                _context.SelectedViewModel = new RegisterViewModel(_context);
            }
            else if (parameter.ToString() == "HomeView")
            {
                _context.SelectedViewModel = new HomeViewModel(_context);
            }
        }
    }
}
