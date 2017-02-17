namespace KiasaBox.WebApp.Models
{
    using System.Collections.Generic;
    
    public class Group
    {
        public int Id;

        public string Name { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}