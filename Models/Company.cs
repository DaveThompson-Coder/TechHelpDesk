using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TechHelpDesk.Models
{
    public class Company
    {
        public int Id { get; set; }     //Primary key

        [DisplayName("Company Name")]
        public string Name { get; set; }

        [DisplayName("Company Description")]
        public string Description { get; set; }

        // --Navigation Properties -- //
        public virtual ICollection<HDUser> Members { get; set; }
        public virtual ICollection<Project> Projects { get; set; }

    }
}
