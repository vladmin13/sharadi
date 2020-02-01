using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sharadi.Services
{
    public interface IDialogService
    {
        Task<string> DisplayPrompt(string title, string discription);        
    }
    
}
