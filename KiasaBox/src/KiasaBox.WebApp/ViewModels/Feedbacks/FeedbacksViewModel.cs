namespace KiasaBox.WebApp.ViewModels.Feedbacks
{
    using Models;
    using System.Collections.Generic;

    public class FeedbacksViewModel
    {
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
