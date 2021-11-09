using System;
using System.Collections.Generic;

namespace Work3
{
    [Serializable]
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }

        public string Password { get; set; }

    }
}