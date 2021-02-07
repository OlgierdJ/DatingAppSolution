using DatingAppLibrary.Commands;
using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running.
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion
        public LoginViewModel(MainViewModel context)
        {
            this._context = context;
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
            RegisterCommand = new RelayCommand(()=> {  _context.SelectedViewModel = new RegisterViewModel(context); });
        }

        private MainViewModel _context;

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {

                var username = this.Username;

                // IMPORTANT: Never store unsecure password in variable like this
                var password = (parameter as IHavePassword).SecurePassword.Unsecure();
            });
        }
    }
}
