using System;
using System.Windows.Input;

namespace DatingAppLibrary.Commands
{
    /// <summary>
    /// A basic command that runs an Action.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// The action to run.
        /// </summary>
        private Action _handler;

        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value has changed.
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        /// <summary>
        /// Constructor that takes action to execute when <see cref="Execute(object)"/> runs.
        /// </summary>
        public RelayCommand(Action action)
        {
            _handler = action;
        }

        /// <summary>
        /// A relay command can always execute.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the commands Action.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _handler();
        }
    }
}
