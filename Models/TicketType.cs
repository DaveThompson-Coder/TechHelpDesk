using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TechHelpDesk.Models
{
    public class TicketType
    {
        public int Id { get; set; }         //Primary key
                                            //This Table Creates a 1 to 1 Relationship
        [DisplayName("Type Name")]          //Between the Ticket & the Ticket Type
        public string Name { get; set; }    //Because Each Ticket can Only be of One Type
    }
}       
