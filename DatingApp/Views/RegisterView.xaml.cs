using DatingAppLibrary.Interfaces;
using System;
using System.Security;
using System.Windows.Controls;

namespace DatingApp.Views
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class RegisterView : UserControl, IHavePassword
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        public SecureString SecurePassword
        {
            get
            {
                if (PasswordField.Password == PasswordConfirmationField.Password)
                {
                    return PasswordField.SecurePassword;
                }
                throw new Exception("Passwords do not match.");
            }
        }
    }
}
