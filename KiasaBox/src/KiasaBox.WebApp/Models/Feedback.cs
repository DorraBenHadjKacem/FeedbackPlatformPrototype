namespace KiasaBox.WebApp.Models
{
    using System;
    using System.Collections.Generic;

    public class Feedback
    {
        public int Id;

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Deadline { get; set; }

        public Status Status { get; set; }

        public Privacy Privacy { get; set; }

        public Category Category { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }
    }
}
