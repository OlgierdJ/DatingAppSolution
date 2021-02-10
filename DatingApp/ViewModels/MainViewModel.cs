using DatingApp.ValueConverters;
using DatingAppLibrary.Models;
using DatingAppLibrary.Models.DataModels;
using DatingAppLibrary.Models.Enums;
using DatingAppLibrary.WebAPI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    //Maybe rename mainviewmodel to WindowViewModel or appviewmodel cause makes more sense for when you are logged in to be in the "main" of the program.
    public class MainViewModel : BaseViewModel
    {
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public ApplicationView CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value;
                SelectedViewModel = _currentView.ToViewModel(this);
                //Dont know if im going to use this propertychanged yet but it doesnt hurt anybody.
                OnPropertyChanged(nameof(CurrentView));
            }
        }
        public User CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
                //If there is a user then login.
                if (_currentUser != null)
                {
                    CurrentView = ApplicationView.Home;
                }
                //Else stay or logout.
                else
                {
                    if (CurrentView != ApplicationView.Login)
                    {
                        CurrentView = ApplicationView.Login;
                    }
                }
                OnPropertyChanged(nameof(CurrentUser));
            }
        }

        public MainViewModel()
        {
            CurrentView = ApplicationView.Login;
        }

        private BaseViewModel _selectedViewModel;
        private ApplicationView _currentView;
        private User _currentUser;

    }
}
