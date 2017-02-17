namespace KiasaBox.WebApp.Models
{
    using System.Collections.Generic;
    
    public class Category
    {
        public int Id;

        public string Name { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }
    }
}
