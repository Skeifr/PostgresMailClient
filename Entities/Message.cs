using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace mailClient
{
    [Table("messages", Schema = "public")]
    internal class Message
    {
        [Key]
        public int? id { get; set; }
        [Column("body")]
        public string? Body { get; set; }
        [Column("recipient_id")]
        public int? Recipient_id { get; set; }
        [NotMapped]
        public int? CopyRecipient_id { get; set; }
        [Column("sender_id")]
        public int? Sender_id { get; set; }
        [Column("title")]
        public string? Title { get; set; }
        [NotMapped]
        public Contact? Recipient
        {
            get
            {
                if (dataPg.ContactsArr != null)
                    return dataPg.ContactsArr.Where(contact => contact.id == Recipient_id).FirstOrDefault();
                else
                    return null;
            }
        }
        [NotMapped]
        public Contact? Sender
        {
            get
            {
                if (dataPg.ContactsArr != null)
                    return dataPg.ContactsArr.Where(contact => contact.id == Sender_id).FirstOrDefault();
                else
                    return null;
            }
        }
        [Column("sendeddate")]
        public DateTime SendedDate { get; set; }
    }
}
