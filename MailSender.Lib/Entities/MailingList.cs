using System.Collections.Generic;

namespace MailSender.Lib.Entities
{
    public class MailingList : Entity
    {
        public ICollection<Recipient> Recipients { get; set; } = new List<Recipient>();
    }
}
