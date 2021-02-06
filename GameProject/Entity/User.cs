using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class User: IEntity
    {
        public int Id { get; set; }

        public string Abc { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long IdentityNumber { get; set; }
        public string BirthOfYear { get; set; }
        public List<string> UserNameList { get; set; }

    }
}
