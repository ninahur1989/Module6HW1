namespace User.api.Data
{
    using Models;
    using System.Collections.Generic;

    public sealed class ProviderConfigure
    {
        public List<CreateUserParameters> ConfigData()
        {
            var result1 = new CreateUserParameters() { Job = "it-developer", Name = "Stass", Id = 1, Salary = 12000 };
            var result2 = new CreateUserParameters() { Job = "it-developer2", Name = "Stass2", Id = 2, Salary = 15000 };
            var result3 = new CreateUserParameters() { Job = "it-developer3", Name = "Stass3", Id = 3, Salary = 14000 };
            List<CreateUserParameters> mylist = new List<CreateUserParameters>();
            mylist.Add(result1);
            mylist.Add(result2);
            mylist.Add(result3);
            return mylist;
        }
    }
}
