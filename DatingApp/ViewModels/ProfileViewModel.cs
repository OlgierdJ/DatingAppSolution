using DatingAppLibrary.Commands;
using DatingAppLibrary.Models.DataModels;
using DatingAppLibrary.Models.Enums;
using DatingAppLibrary.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<Gender> Genders
        {
            get
            {
                return Enum.GetValues(typeof(Gender))
                    .Cast<Gender>();
            }
        }
        public ICommand SaveCommand { get; set; }
        public bool SaveIsRunning { get; set; }
        public ProfileViewModel(MainViewModel context)
        {
            _context = context;
            SaveCommand = new RelayParameterizedCommand(async (parameter) => await SaveProfile(parameter));
        }
        public async Task SaveProfile(object parameter)
        {
            await RunCommand(() => this.SaveIsRunning, async () =>
            {
                try
                {
                    DatingAPIConnection api = new DatingAPIConnection();
                    Profile profile = new Profile()
                    {
                        UserRefID=_context.CurrentUser.ID,
                        FirstName = FirstName,
                        LastName = LastName,
                        Age = Age,
                        Gender = Gender
                    };
                    //If user doesnt have a profile create one.
                    if (_context.CurrentUser.UserProfile == null)
                    {
                       profile = await api.CreateProfileAsync(profile);
                    }
                    //if user does have a profile update instead.
                    else
                    {
                        profile.ID = _context.CurrentUser.UserProfile.ID;
                        profile = await api.UpdateProfileAsync(profile);
                    }
                    //If success then change currentuser objects profile else dont.
                    if (profile != null)
                    {
                        _context.CurrentUser.UserProfile = profile;
                    }
                    User test = _context.CurrentUser;
                }
                catch (Exception) { }
            });
        }

        private MainViewModel _context;
    }
}
