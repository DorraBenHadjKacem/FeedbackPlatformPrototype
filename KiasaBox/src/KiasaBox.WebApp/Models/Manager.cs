namespace KiasaBox.WebApp.Models
{
    using System.Collections.Generic;
    
    public class Manager
    {
        public int Id;

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
