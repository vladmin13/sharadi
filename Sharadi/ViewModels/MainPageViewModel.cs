using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using Sharadi.Views;
using Xamarin.Forms;

namespace Sharadi.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ICommand newGameCommand;

        public MainPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            NewGameCommand = new Command(NewGame);
        }

        public ICommand NewGameCommand
        {
            get => newGameCommand;
            set => SetProperty(ref newGameCommand, value);
        }

        private async void NewGame()
        {
            await NavigationService.NavigateAsync(nameof(TeamsPage));
        }
    }
}