using System;
using System.Collections.Generic;
using System.Text;

namespace pollingapp
{
    class Topic
    {
        public string title { get; set; }
        private string summary { get; set; }
        private string description { get; set; }
        private string[] moreInfoLinks { get; set; }
        public List<Comment> userComments { get; set; }

        public Topic(string Title, string Summary, string Description, string[] MoreInfoLinks)
        {
            this.title         = Title;
            this.summary       = Summary;
            this.description   = Description;
            this.moreInfoLinks = MoreInfoLinks;
        }
    }
}
