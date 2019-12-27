using System;
using System.Collections.Generic;

namespace NePisirsem.Models
{
    public partial class Users
    {
        public Users()
        {
            Recipes = new HashSet<Recipes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Recipes> Recipes { get; set; }
    }
}
