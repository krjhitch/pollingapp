using System;
using System.Collections.Generic;
using System.Text;

namespace pollingapp
{
    class User
    {
        private string emailAddress { get; set; }
        private string userName { get; set; }
        private DateTime creationDate { get; set; }

        public User(string UserName, string EmailAddress)
        {
            this.emailAddress = EmailAddress;
            this.userName     = UserName;
            this.creationDate = DateTime.UtcNow;
        }
    }
}
