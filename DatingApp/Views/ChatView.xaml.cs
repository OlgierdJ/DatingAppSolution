using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace DatingApp.Views
{
    /// <summary>
    /// Interaction logic for ChatView.xaml
    /// </summary>
    public partial class ChatView : UserControl
    {
        public ChatView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Preview the input into the message box and respond as required
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageText_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Get the text box
            var textbox = sender as TextBox;

            // Check if we have pressed enter
            if (e.Key == Key.Enter)
            {
                // If we have control pressed...
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                {
                    // Add a new line at the point where the cursor is
                    var index = textbox.CaretIndex;

                    // Insert the new line
                    textbox.Text = textbox.Text.Insert(index, Environment.NewLine);

                    // Shift the caret forward to the newline
                    textbox.CaretIndex = index + Environment.NewLine.Length;

                    // Mark this key as handled by us
                    e.Handled = true;
                }
                else
                    // Send the message
                   // ViewModel.Send();

                // Mark the key as handled
                e.Handled = true;
            }
        }
    }
}
