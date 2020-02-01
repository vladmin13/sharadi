using System.Collections.Generic;
using System.Threading.Tasks;
using Sharadi.Model;

namespace Sharadi.Services
{
    public interface IDatabaseService
    {
        Task<List<Category>> GetCategories();
    }
}