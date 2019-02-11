using System;
using System.Collections.Generic;
using System.Text;

namespace pollingapp
{
    class Comment
    {
        private string title { get; set; }
        private string description { get; set; }
        private User creator { get; set; }

        public Comment (string Title, string Description, User Creator)
        {
            this.title       = Title;
            this.description = Description;
            this.creator     = Creator;
        }
    }
}
