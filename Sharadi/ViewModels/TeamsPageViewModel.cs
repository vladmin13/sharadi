using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;
using Sharadi.Model;
using Sharadi.Resources;
using Sharadi.Views;
using Xamarin.Forms;

namespace Sharadi.ViewModels
{
    public class TeamsPageViewModel : ViewModelBase
    {
        private ObservableCollection<Team> teams;
        private string title;
        private ICommand removeTeamCommand;
        private ICommand addTeamCommand;
        private ICommand goToSettingsCommand;


        public TeamsPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {
            Teams = new ObservableCollection<Team>() { new Team { Name = "First"}, new Team { Name = "Second" } };

            Title = Strings.Teams;
            AddTeamCommand = new Command(AddTeam);
            RemoveTeamCommand = new Command(RemoveTeam);
            GoToSettingsCommand = new Command(GoToSettings);
        }

        public ICommand RemoveTeamCommand
        {
            get => removeTeamCommand;
            set => SetProperty(ref removeTeamCommand, value);
        }

        public ICommand AddTeamCommand
        {
            get => addTeamCommand;
            set => SetProperty(ref addTeamCommand, value);
        }

        public ICommand GoToSettingsCommand
        {
            get => goToSettingsCommand;
            set => SetProperty(ref goToSettingsCommand, value);
        }

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public ObservableCollection<Team> Teams
        {
            get => teams;
            set => SetProperty(ref teams, value);
        }

        private void AddTeam()
        {
            Teams.Add(new Team { Name = $"Team {Teams.Count + 1}" });
        }

        private void RemoveTeam(object team)
        {
            Teams.Remove((Team)team);
        }

        private async void GoToSettings()
        {
            await NavigationService.NavigateAsync(nameof(SettingsPage), new NavigationParameters() { { Params.Teams, Teams.ToList() } });
        }
    }
}
