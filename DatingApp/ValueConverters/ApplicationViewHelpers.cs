using DatingApp.ViewModels;
using DatingApp.Views;
using DatingAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Controls;

namespace DatingApp.ValueConverters
{
    /// <summary>
    /// Converts the <see cref="ApplicationView"/> to an actual view/page
    /// </summary>
    public static class ApplicationPageHelpers
    {
        /// <summary>
        /// Takes a <see cref="ApplicationView"/> and a view model, if any, and creates the desired page
        /// </summary>
        /// <param name="view"></param>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        public static UserControl ToBaseView(this ApplicationView view, object viewModel = null)
        {
            switch (view)
            {
                case ApplicationView.Login:
                    return new LoginView(viewModel as LoginViewModel);

                case ApplicationView.Register:
                    return new RegisterView(viewModel as RegisterViewModel);

                case ApplicationView.Chat:
                    return new ChatView(viewModel as ChatMessageListViewModel);

                case ApplicationView.Browse:
                    return new HomeView(viewModel as HomeViewModel);

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
        public static ApplicationView ToApplicationView(this UserControl view)
        {
            if (view is ChatView)
                return ApplicationView.Chat;

            if (view is LoginView)
                return ApplicationView.Login;

            if (view is RegisterView)
                return ApplicationView.Register;

            Debugger.Break();
            return default(ApplicationView);
        }
    }
}
