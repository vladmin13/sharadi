using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Sharadi.Model;
using Sharadi.Resources;

namespace Sharadi.Services
{
    public class DatabaseService : IDatabaseService
    {
        private FirebaseClient firebaseClient;

        public DatabaseService()
        {
            firebaseClient = new FirebaseClient(FirebaseDatabase.Url);
        }

        public async Task<List<Category>> GetCategories()
        {
            var groupObjects = await firebaseClient
                .Child(FirebaseDatabase.CategoriesNameResource)
                .OnceAsync<Category>();

            return groupObjects.Select(x =>
            {
                x.Object.Id = x.Key;
                return x.Object;
            }).ToList();
        }
    }
}