using DatingAppLibrary.Commands;
using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.Enums;
using DatingAppLibrary.Security;
using DatingAppLibrary.WebAPI;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Username { get; set; }
        /// <summary>
        /// A flag indicating if the login command is running.
        /// </summary>
        public bool LoginIsRunning { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public LoginViewModel(MainViewModel context)
        {
            _context = context;
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
            RegisterCommand = new RelayCommand(() => { _context.CurrentView = ApplicationView.Register; });
        }

        /// <summary>
        /// Attempts to log the user in.
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password.</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                DatingAPIConnection api = new DatingAPIConnection();
                _context.CurrentUser = await api.Login(Username, (parameter as IHavePassword).SecurePassword.Unsecure());
            });
        }

        private readonly MainViewModel _context;
    }
}
