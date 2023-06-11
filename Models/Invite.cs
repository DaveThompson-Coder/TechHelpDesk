using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TechHelpDesk.Models
{
    public class Invite
    {
        public int Id { get; set; }         //Primary key

        [DisplayName("Date Sent")]
        public DateTimeOffset InviteDate { get; set; }

        [DisplayName("Join Date")]
        public DateTimeOffset JoinDate { get; set; }

        [DisplayName("Code")]
        public Guid CompanyToken { get; set; }

        [DisplayName("Company")]
        public int CompanyId { get; set; }      //Foreign key to Company Table

        [DisplayName("Project")]
        public int ProjectId { get; set; }      //Foreign key to Project Table

        [DisplayName("Invitor")]
        public string InvitorId { get; set; }      //Foreign key to HDUser/IdentityUser Table

        [DisplayName("Invitee")]
        public string InviteeId { get; set; }      //Foreign key to HDUser/IdentityUser Table

        [DisplayName("Invitee Email")]
        public string InviteeEmail { get; set; }

        [DisplayName("Invitee First Name")]
        public string InviteeFirstName { get; set; }

        [DisplayName("Invitee Last Name")]
        public string InviteeLastName { get; set; }

        public bool IsValid { get; set; }

        // -- Navigation Properties -- Creates 1 to 1 relationships between Tables//
        public virtual Company Company { get; set; }
        public virtual HDUser Invitor { get; set; }
        public virtual HDUser Invitee { get; set; }
        public virtual Project Project { get; set; }

    }
}
