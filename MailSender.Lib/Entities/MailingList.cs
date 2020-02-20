using System.Collections.Generic;
using MailSender.Lib.Entities.Base;

namespace MailSender.Lib.Entities
{
    public class MailingList : NamedEntity
    {
        public ICollection<Recipient> Recipients { get; set; } = new List<Recipient>();
    }
}
