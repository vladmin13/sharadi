using Prism.Navigation;


namespace Sharadi.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        private int countWords = 100;
        private int countSeconds = 60;
        private bool isFine;
        private bool isSound;

        public SettingsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        public int CountWords
        {
            get => countWords;
            set => SetProperty(ref countWords, value);
        }

        public int CountSeconds
        {
            get => countSeconds;
            set => SetProperty(ref countSeconds, value);
        }

        public bool IsFine
        {
            get => isFine;
            set => SetProperty(ref isFine, value);
        }

        public bool IsSound
        {
            get => isSound;
            set => SetProperty(ref isSound, value);
        }

        private async void GoToCategoryes()
        {
            //await NavigationService.NavigateAsync(nameof(SettingsPage), new NavigationParameters() { { Params.Teams, Teams.ToList() } });
        }
    }
}

