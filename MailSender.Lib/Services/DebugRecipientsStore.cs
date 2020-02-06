using System.Collections.Generic;
using MailSender.Lib.Data;
using MailSender.Lib.Entities;
using MailSender.Lib.MVVM;

namespace MailSender.Lib.Services
{
    public class DebugRecipientsStore : IStore<Recipient>
    {
        public IEnumerable<Recipient> Items => TestData.Recipients;
    }
}
