namespace DatingApp.ViewModels
{
    public class ChatViewModel : BaseViewModel
    {
        private MainViewModel mainContext;

        public ChatViewModel(MainViewModel mainContext)
        {
            this.mainContext = mainContext;
        }
    }
}