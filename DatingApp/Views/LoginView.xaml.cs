using DatingAppLibrary.Interfaces;
using System.Security;
using System.Windows.Controls;

namespace DatingApp.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl, IHavePassword
    {
        public LoginView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get-only property to get the SecurePassword from the PasswordField PasswordBox.
        /// </summary>
        public SecureString SecurePassword => PasswordField.SecurePassword;
    }
}
