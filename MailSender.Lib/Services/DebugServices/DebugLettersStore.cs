using MailSender.Lib.Data;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;
using MailSender.Lib.Services.Base;

namespace MailSender.Lib.Services.DebugServices
{
    public class DebugLettersStore : DebugStore<Letter>, ILettersStore
    {
        public DebugLettersStore():base(TestData.Letters)
        {
            
        }

        public override void Update(int id, Letter letter)
        {
            var dbLetter = GetById(id);
            if (dbLetter == null)
                return;

            dbLetter.Subject = letter.Subject;
            dbLetter.Body = letter.Body;
        }
    }
}
