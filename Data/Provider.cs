using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace User.api.Data
{
    public sealed class Provider
    {
        public Provider()
        {
            if (FirstUse)
            {
                var config = new ProviderConfigure();
                Mylist.AddRange(config.ConfigData());
                FirstUse = false;
            }
        }

        private static bool FirstUse = true;

        private static Provider _instance;

        public static List<CreateUserParameters> Mylist = new List<CreateUserParameters>();

        public static Provider GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Provider();
            }

            return _instance;
        }

        public async Task <List<CreateUserParameters>> GetListAsync()
        {
            return Mylist;
        }

        public async Task<List<CreateUserParameters>> CreateAsync(CreateUserParameters user)
        {
            Mylist.Add(user);
            return Mylist;
        }
    }
}
