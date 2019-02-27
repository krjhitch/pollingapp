using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace pollingapp
{
    static class PollingFactory
    {
        private static List<User> users = new List<User>();
        private static List<Topic> topics = new List<Topic>();
    
        public static User CreateUser(string UserName, string EmailAddress)
        {
            var newUser = new User(UserName, EmailAddress);
            return newUser;
        }
        public static Topic AddTopic(string Title, string Summary, string Description, string[] MoreInfoLinks)
        {
            var newTopic = new Topic(Title, Summary, Description, MoreInfoLinks);
            return newTopic;
        }
        public static IEnumerable<User> GetAllUsers()
        {
            return users;
        }
        public static IEnumerable<Topic> GetAllTopics()
        {
            return topics;
        }
        public static IEnumerable<Topic> GetTopicByTitle(string Keyword)
        {
            return topics.Where(t => t.title.Contains(Keyword));
        }
        public static List<Comment> GetComments(string Keyword)
        {
            var topicResults = GetTopicByTitle(Keyword);
            var commentResults = new List<Comment>();
            foreach (var topic in topicResults)
            {
                foreach (var comment in topic.userComments)
                {
                    commentResults.Add(comment);
                }
            }
            return commentResults;
        }
        public static Comment AddComment (Topic ParentTopic, string Title, string Description, User Creator)
        {
            var newComment = new Comment(Title, Description, Creator);
            ParentTopic.userComments.Add(newComment);
            return newComment;
        }
    }
}
