using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace TechHelpDesk.Models
{
    public class TicketAttachment
    {
        public int Id { get; set; }         //Primary key

        [DisplayName("Ticket")]
        public int TicketId { get; set; }   //foreign key of Ticket this attachment belongs to

        [DisplayName("File Date")]
        public DateTimeOffset Created { get; set; }

        [DisplayName("Team Member")]
        public string UserId { get; set; }

        [DisplayName("File Descrition")]
        public string Description { get; set; }


        //Attachment information fields
        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile FormFile { get; set; }

        [DisplayName("File Name")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        [DisplayName("File Extension")]
        public string FileContentType { get; set; }


        //Navigation properties
        public virtual Ticket Ticket { get; set; }
        public virtual HDUser User { get; set; }

    }
}
