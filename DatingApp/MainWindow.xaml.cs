using DatingApp.ViewModels;
using System.Windows;

namespace DatingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*note to self: what the fuck is a poco object?...*/
        /*GOALS
         * 
         * Create dating app like shopping site haha xd.
         * Jokes aside i have no clue as to how a dating app looks due to never using one.
         * 
         * ~Use Entity Framework
         * ~Do best practices as far as possible
         * ~Don't steal finished products
         * ~Solo
         * 
         * *****->User->
         * **->First actions
         * ***1. Should be able to register.
         * ***2. Should be able to log in.
         * ***3. Should be able to alter their security details (Username, Password, Email)
         * ***4. Should be able to create/alter their profile.
         * **->Second actions
         * ***4. Should be able to view other user profiles (Name, Sex, Age, Sexual Orientation) 
         * ****Note: viewer and viewee need to have ages in their respective counterparts age range.*
         * ***5. Should be able to start a chat with the viewed person.
         * ***6. Should be able to disable their profile.
         */
        public MainViewModel Context
        {
            get
            {
                return _context;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Context;
        }
        private readonly MainViewModel _context = new MainViewModel();
    }
}
