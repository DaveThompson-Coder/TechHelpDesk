using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace TechHelpDesk.Models
{
    public class TicketHistory
    {
        public int Id { get; set; }                 //Primary key id for History item

        [DisplayName("Ticket")]
        public int TicketId { get; set; }           //Secondary key of Ticket in another Table - Navigates to the Ticket table

        [DisplayName("Updated Item")]
        public string Property { get; set; }        //holds value of what was changed

        [DisplayName("Previous")]
        public string OldValue { get; set; }        //holds value before it was changed

        [DisplayName("Current")]
        public string NewValue { get; set; }        //holds value of what it was changed to

        [DisplayName("Date Modified")]
        public DateTimeOffset Created { get; set; } //holds the Date when the Modification was made

        [DisplayName("Description of Change")]
        public string Description { get; set; }     //holds a Description of what was changed

        [DisplayName("Team Member")]                //holds the user Id of the person who made the modification as a 'String'
        public string UserId { get; set; }          //is a Foreign key navigates to user Table to get data of User who made the change

        //Navigation properties - Virtual properties Not Stored in database
        public virtual Ticket Ticket { get; set; }
        public virtual HDUser User { get; set; }

    }
}
