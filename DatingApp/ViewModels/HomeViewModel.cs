using DatingApp.ValueConverters;
using DatingAppLibrary.Models.Enums;
using DatingAppLibrary.WebAPI;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public BaseViewModel SelectedSubViewModel 
        {
            get 
            {
                return _selectedSubViewModel;  
            }
            set 
            { 
                _selectedSubViewModel = value;
                OnPropertyChanged(nameof(SelectedSubViewModel));
            }
        }
        public ApplicationView CurrentSubView
        {
            get
            {
                return _currentSubView;
            }
            set
            {
                _currentSubView = value;
                SelectedSubViewModel = _currentSubView.ToViewModel(_context);
                OnPropertyChanged(nameof(CurrentSubView));
            }
        }

        public HomeViewModel(MainViewModel Context)
        {
            _context = Context;
            CurrentSubView = ApplicationView.Chat;
        }

        private readonly MainViewModel _context;
        private BaseViewModel _selectedSubViewModel;
        private ApplicationView _currentSubView;
    }
}
