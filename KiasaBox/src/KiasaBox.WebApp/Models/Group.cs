namespace KiasaBox.WebApp.Models
{
    using System.Collections.Generic;


    public class Group
    {
        public int Id;

        public string Name { get; set; }

        public ICollection<Manager> Managers { get; set; }
    }
}
