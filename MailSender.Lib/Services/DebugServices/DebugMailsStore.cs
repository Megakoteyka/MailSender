using MailSender.Lib.Data;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;
using MailSender.Lib.Services.Base;

namespace MailSender.Lib.Services.DebugServices
{
    public class DebugMailsStore : DebugStore<Mail>, IMailsStore
    {
        public DebugMailsStore():base(TestData.Mails)
        {
            
        }

        public override void Update(int id, Mail mail)
        {
            var dbLetter = GetById(id);
            if (dbLetter == null)
                return;

            dbLetter.Subject = mail.Subject;
            dbLetter.Body = mail.Body;
        }
    }
}
