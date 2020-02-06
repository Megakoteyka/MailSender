using System.Collections.Generic;
using MailSender.Lib.Data;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Services
{
    public class DebugLettersStore
    {
        public IEnumerable<Letter> Letters => TestData.Letters;
    }
}
