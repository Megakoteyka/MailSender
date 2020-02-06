using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Data;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Services
{
    public class DebugSendersStore
    {
        public IEnumerable<Sender> Senders => TestData.Senders;
    }
}
