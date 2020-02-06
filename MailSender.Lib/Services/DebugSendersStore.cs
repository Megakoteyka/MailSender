using System.Collections.Generic;
using MailSender.Lib.Data;
using MailSender.Lib.Entities;
using MailSender.Lib.MVVM;

namespace MailSender.Lib.Services
{
    public class DebugSendersStore : IStore<Sender>
    {
        public IEnumerable<Sender> Items => TestData.Senders;
    }
}
