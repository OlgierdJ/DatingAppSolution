using System;
using System.Windows.Input;

namespace DatingAppLibrary.Commands
{
    /// <summary>
    /// A basic command that runs an parameterized Action.
    /// </summary>
    public class RelayParameterizedCommand : ICommand
    {
        /// <summary>
        /// The action to run.
        /// </summary>
        private Action<object> _handler;

        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value has changed.
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        /// <summary>
        /// Constructor that takes an parameterized action to execute when <see cref="Execute(object)"/> runs.
        /// </summary>
        public RelayParameterizedCommand(Action<object> action)
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
        /// Executes the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _handler(parameter);
        }
    }
}
