using System;
using System.Collections.Generic;

namespace Models
{
    public sealed class CreateUserParameters
    {

        public string Name { get; set; }

        public string Job { get; set; }

        public int Id { get; set; }

        public int Salary { get; set; }
    }
}
