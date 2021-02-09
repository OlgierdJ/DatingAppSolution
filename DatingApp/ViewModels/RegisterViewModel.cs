using DatingAppLibrary.Commands;
using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using DatingAppLibrary.Models.Enums;
using DatingAppLibrary.Security;
using DatingAppLibrary.WebAPI;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public bool RegisterIsRunning { get; set; }
        public ICommand BackCommand { get; set; }
        public ICommand RegisterUserCommand { get; set; }
        public RegisterViewModel(MainViewModel Context)
        {
            _context = Context;
            //Really want to learn how to do a true back command with action history and such (like ctrl+z).
            BackCommand = new RelayCommand(() => { _context.CurrentView = ApplicationView.Login; });
            //Contact server to "createuser" -> throw error message if fails -> show success if not -> return to login.
            RegisterUserCommand = new RelayParameterizedCommand(async (parameter) => await RegisterUser(parameter));
        }

        /// <summary>
        /// Attempts to log the user in.
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password.</param>
        /// <returns></returns>
        public async Task RegisterUser(object parameter)
        {
            await RunCommand(() => this.RegisterIsRunning, async () =>
            {
                try
                {
                    DatingAPIConnection api = new DatingAPIConnection();
                    User registeringUser = new User()
                    {
                        Username = Username,
                        Password = (parameter as IHavePassword).SecurePassword.Unsecure(),
                        Email = Email
                    };
                    //Maybe do null check on each property or find some way to use required fields.
                   await api.CreateUserAsync(registeringUser);
                    _context.CurrentView = ApplicationView.Login;
                }
                catch (Exception) {  }
            });
        }


        private readonly MainViewModel _context;
    }
}
