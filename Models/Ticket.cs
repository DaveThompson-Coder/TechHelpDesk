using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TechHelpDesk.Models
{
    public class Ticket
    {
        public int Id { get; set; }     //Primary key

        [Required]
        [StringLength(50)]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Created")]
        public DateTimeOffset Created { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Updated")]
        public DateTimeOffset? Updated { get; set; }       //'?' - Means value can be null or empty Not Required

        [DisplayName("Archived")]
        public bool Archived { get; set; }

        [DisplayName("Archived By Project")]
        public bool ArchivedByProject { get; set; }

        [DisplayName("Project")]
        public int ProjectId { get; set; }              //Foreign key to the project it belongs to

        [DisplayName("Ticket Type")]
        public int TicketTypeId { get; set; }          //Foreign key refers to TicketType Table

        [DisplayName("Ticket Priority")]
        public int TicketPriorityId { get; set; }      //Foreign key refers to TicketPriority Table

        [DisplayName("Ticket Status")]
        public int TicketStatusId { get; set; }        //Foreign key refers to TicketStatus Table

        [DisplayName("Ticket Owner")]
        public string OwnerUserId { get; set; }         //Foreign key refers to identity User

        [DisplayName("Ticket Developer")]
        public string DeveloperUserId { get; set; }     //Foreign key refers to identity User

        // -- These Navigation Properties -- Create 1 to 1 Relationships between Tables//
        //when entity framework sees virtual - it allows for LAZY LOADING; populate the project at a later time
        //with the info requested - provide the id for the foreign keys and you will get the object that is tied
        //to the id's - It doesn't have to be in by default. Populate based on the foreign key given - if you have the
        //ProjectId then you can get the project when you need it....

        public virtual Project Project { get; set; }
        public virtual TicketType TicketType { get; set; }
        public virtual TicketStatus TicketStatus { get; set; }
        public virtual TicketPriority TicketPriority { get; set; }
        public virtual HDUser OwnerUser { get; set; }
        public virtual HDUser DeveloperUser { get; set; }


        // -- Navigation Properties -- Create One to Many Relationships between the Tables
        public virtual ICollection<TicketComment> Comments { get; set; } = new HashSet<TicketComment>();
        public virtual ICollection<TicketAttachment> Attachments { get; set; } = new HashSet<TicketAttachment>();
        public virtual ICollection<Notification> Notifications { get; set; } = new HashSet<Notification>();
        public virtual ICollection<TicketHistory> History { get; set; } = new HashSet<TicketHistory>();

    }
}
