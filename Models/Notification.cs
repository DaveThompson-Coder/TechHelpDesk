using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TechHelpDesk.Models
{
    public class Notification
    {
        public int Id { get; set; }     //Primary key

        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Message")]
        public string Message { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date")]
        public DateTimeOffset Created { get; set; }

        [Required]
        [DisplayName("Recipient")]
        public string RecipientId { get; set; }

        [Required]
        [DisplayName("Sender")]
        public string SenderId { get; set; }

        [DisplayName("Has been Viewed")]
        public bool Viewed { get; set; }

        // -- Navigation Properties -- //
        public virtual Ticket Ticket { get; set; }
        public virtual HDUser Recipient { get; set; }
        public virtual HDUser Sender { get; set; }

    }
}
