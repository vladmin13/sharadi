using System.Collections.ObjectModel;
using System.Windows.Input;
using Prism.Navigation;
using Sharadi.Model;
using Sharadi.Services;
using Xamarin.Forms;

namespace Sharadi.ViewModels
{
    public class CategoriesPageViewModel : ViewModelBase
    {
        private readonly IDatabaseService databaseService;
        private ObservableCollection<Category> categories;
        private ICommand selectCommand;
        
        public CategoriesPageViewModel(INavigationService navigationService,
            IDatabaseService databaseService) 
            : base(navigationService)
        {
            this.databaseService = databaseService;

            SelectCommand = new Command(SelectItem);
        }

        public ICommand SelectCommand
        {
            get => selectCommand;
            set => SetProperty(ref selectCommand, value);
        }

        public ObservableCollection<Category> Categories
        {
            get => categories;
            set => SetProperty(ref categories, value);
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            Categories = new ObservableCollection<Category>(await databaseService.GetCategories());
        }

        private async void SelectItem(object item)
        {
        }
    }
}