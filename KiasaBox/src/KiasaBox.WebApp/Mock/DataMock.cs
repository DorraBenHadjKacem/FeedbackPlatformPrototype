using KiasaBox.WebApp.Models;

namespace KiasaBox.WebApp.Mock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DataMock
    {
        public Feedback MockFeedback()
        {
            var groups = new List<Group>();
            var topics = new List<Topic>();

            var group01 = new Group
            {
                Id = 1,
                Name = "Team"
            };

            var group02 = new Group
            {
                Id = 2,
                Name = "IT department"
            };

            var group03 = new Group
            {
                Id = 3,
                Name = "Media department"
            };

            groups.Add(group01);
            groups.Add(group02);
            groups.Add(group03);

            var topic01 = new Topic
            {
                Id = 1,
                Name = "Working conditions",
                Description = "This topic is about the general working condition. Annoyed by noisy neighbors? Desks are not high enough? This is the topic you should use!"
            };

            var topic02 = new Topic
            {
                Id = 2,
                Name = "Workplace facilities",
                Description = "Kitchen duty is not being done? Toilets are always dirty? Here is the topic for you!"
            };

            var topic03 = new Topic
            {
                Id = 3,
                Name = "Events",
                Description = "Some critics about the last event? Want to suggest more events? Any specific feedback? This is the topic for you!"
            };

            topics.Add(topic01);
            topics.Add(topic02);
            topics.Add(topic03);

            var feedback = new Feedback
            {
                Groups = groups,
                Topics = topics,
                Category = Category.Strength,
                Content = "This is the feedback content",
                Title = "This is the feedback's title",
                Deadline = DateTime.Now,
                Privacy = Privacy.ManagersOnly,
                Status = Status.Open
            };

            return feedback;
        }
    }
}
