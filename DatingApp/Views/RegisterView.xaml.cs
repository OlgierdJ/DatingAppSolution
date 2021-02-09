using DatingApp.ViewModels;
using DatingAppLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
