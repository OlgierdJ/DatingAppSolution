using DatingApp.ViewModels;

namespace DatingApp.ValueConverters
{
    internal class ChatViewModel : BaseViewModel
    {
        private MainViewModel mainContext;

        public ChatViewModel(MainViewModel mainContext)
        {
            this.mainContext = mainContext;
        }
    }
}