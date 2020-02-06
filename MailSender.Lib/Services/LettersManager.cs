using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Services
{
    public class LettersManager:DataManager<Letter>
    {
        private readonly DebugLettersStore _lettersStore;

        public LettersManager(DebugLettersStore lettersStore) => _lettersStore = lettersStore;

        public override IEnumerable<Letter> Read() => _lettersStore?.Letters;

        public override void Add(Letter item) => throw new NotImplementedException();

        public override void Update(Letter item) => throw new NotImplementedException();

        public override void Delete(Letter item) => throw new NotImplementedException();
    }
}
