using System.Windows.Input;
using Prism.Navigation;
using Sharadi.Views;
using Xamarin.Forms;

namespace Sharadi.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        private int countWords = 100;
        private int countSeconds = 60;
        private bool isFine;
        private bool isSound;
        private ICommand goToCategoriesCommand;

        public SettingsPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            GoToCategoriesCommand = new Command(GoToCategories);
        }

        public ICommand GoToCategoriesCommand
        {
            get => goToCategoriesCommand;
            set => SetProperty(ref goToCategoriesCommand, value);
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

        private async void GoToCategories()
        {
            await NavigationService.NavigateAsync(nameof(CategoriesPage));
        }
    }
}