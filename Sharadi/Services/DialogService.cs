using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sharadi.Services
{
    class DialogService : IDialogService
    {
        public Task<string> DisplayPrompt(string title, string discription)
        {
            return App.Current.MainPage.DisplayPromptAsync(title, discription, placeholder: title);
        }
    }
}
