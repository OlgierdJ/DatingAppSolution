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
