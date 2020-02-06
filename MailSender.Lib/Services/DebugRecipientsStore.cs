using System.Collections.Generic;
using MailSender.Lib.Data;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Services
{
    public class DebugRecipientsStore
    {
        public IEnumerable<Recipient> Recipients => TestData.Recipients;
    }
}
