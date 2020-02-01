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
            Teams = new ObservableCollection<Team>();
            for (int i = 0; i < 2; i++) AddTeam();                
            Title = Strings.Teams;
            Teams.CollectionChanged += UpdateList;
            AddTeamCommand = new Command(AddTeam);
            RemoveTeamCommand = new Command(RemoveTeam);
            GoToSettingsCommand = new Command(GoToSettings);
        }

        private void UpdateList(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RaisePropertyChanged(nameof(IsRemovable));
        }

        public ICommand RemoveTeamCommand
        {
            get => removeTeamCommand;
            set => SetProperty(ref removeTeamCommand, value);
        }

        public bool IsRemovable => Teams.Count > 2;

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
            int i = 1;
            Team NewTeam;
            do
            {
                NewTeam = new Team { Name = $"{Strings.Team} {i++}" };
            } while (Teams.Contains(NewTeam));
            Teams.Add( NewTeam );
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
