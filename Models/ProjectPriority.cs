using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TechHelpDesk.Models
{
    public class ProjectPriority
    {
        public int Id { get; set; }         //Primary key

        [DisplayName("Priority Name")]
        public string Name { get; set; }

    }
}
