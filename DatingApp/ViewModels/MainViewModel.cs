using DatingAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }
        public MainViewModel() { }
        public MainViewModel(ICommand updateViewCommand)
        {
            UpdateViewCommand = updateViewCommand;
        }

        private List<User> _users;
        public List<User> Users {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }
    }
}
