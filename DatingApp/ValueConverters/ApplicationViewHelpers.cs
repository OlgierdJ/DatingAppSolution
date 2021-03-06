﻿using DatingApp.ViewModels;
using DatingAppLibrary.Models.Enums;
using System.Diagnostics;

namespace DatingApp.ValueConverters
{
    /// <summary>
    /// Converts the <see cref="ApplicationView"/> to an actual view/page
    /// </summary>
    public static class ApplicationViewHelpers
    {
        /// <summary>
        /// Takes a <see cref="ApplicationView"/> and a view model, if any, and creates the desired page
        /// </summary>
        /// <param name="view"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public static BaseViewModel ToViewModel(this ApplicationView view, MainViewModel mainContext = null)
        {
            switch (view)
            {
                case ApplicationView.Login:
                    return new LoginViewModel(mainContext);
                case ApplicationView.Register:
                    return new RegisterViewModel(mainContext);
                case ApplicationView.Home:
                    return new HomeViewModel(mainContext);
                case ApplicationView.Profile:
                    return new ProfileViewModel(mainContext);
                case ApplicationView.Browse:
                    return new BrowseViewModel(mainContext);
                case ApplicationView.Chat:
                   return new ChatViewModel(mainContext);
                default:
                    Debugger.Break();
                    return null;
            }
        }

        /// <summary>
        /// Converts a <see cref="BaseView"/> to the specific <see cref="ApplicationView"/> that is for that type of page
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>
        public static ApplicationView ToApplicationView(this BaseViewModel viewModel)
        {
            if (viewModel is LoginViewModel)
                return ApplicationView.Login;
            if (viewModel is RegisterViewModel)
                return ApplicationView.Register;
            if (viewModel is HomeViewModel)
                return ApplicationView.Home;
            if (viewModel is ChatViewModel)
               return ApplicationView.Chat;
            Debugger.Break();
            return default(ApplicationView);
        }
    }
}
