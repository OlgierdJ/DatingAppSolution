using DatingAppLibrary.Commands;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DatingApp.ViewModels
{
    /// <summary>
    /// A view model for a chat message thread list.
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        /// <summary>
        /// The chat thread items for the list.
        /// </summary>
        protected ObservableCollection<ChatMessageListItemViewModel> _Items;


        /// <summary>
        /// The chat thread items for the list.
        /// NOTE: Do not call Items.Add to add messages to this list
        ///       as it will make the FilteredItems out of sync.
        /// </summary>
        public ObservableCollection<ChatMessageListItemViewModel> Items
        {
            get => _Items;
            set
            {
                // Make sure list has changed.
                if (_Items == value)
                    return;

                // Update value.
                _Items = value;

            }
        }

        /// <summary>
        /// The title of this chat list.
        /// </summary>
        public string DisplayTitle { get; set; }
      
        /// <summary>
        /// The text for the current message being written.
        /// </summary>
        public string PendingMessageText { get; set; }


        /// <summary>
        /// The command for when the user clicks the send button.
        /// </summary>
        public ICommand SendCommand { get; set; }


        /// <summary>
        /// Default constructor.
        /// </summary>
        public ChatMessageListViewModel()
        {
            SendCommand = new RelayCommand(Send);
        }


        /// <summary>
        /// When the user clicks the send button, sends the message.
        /// </summary>
        public void Send()
        {
            // Don't send a blank message.
            if (string.IsNullOrEmpty(PendingMessageText))
                return;

            // Ensure lists are not null.
            if (Items == null)
                Items = new ObservableCollection<ChatMessageListItemViewModel>();

            // Fake send a new message.
            var message = new ChatMessageListItemViewModel
            {
                Initials = "LM",
                Message = PendingMessageText,
                MessageSentTime = DateTime.UtcNow,
                SentByMe = true,
                SenderName = "Luke Malpass",
                NewItem = true
            };

            // Add message to both lists.
            Items.Add(message);

            // Clear the pending message text.
            PendingMessageText = string.Empty;
        }
    }
}
