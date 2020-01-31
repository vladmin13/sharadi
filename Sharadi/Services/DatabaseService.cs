using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
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

        public async Task<List<Group>> GetGroups()
        {
            var groupObjects = await firebaseClient.Child(FirebaseDatabase.GroupsNameResource).OnceAsync<Group>();
            return groupObjects.Select(x => x.Object).ToList();
        }
    }
}