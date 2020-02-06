using System;
using System.Collections.Generic;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Services
{
    public class RecipientsManager : DataManager<Recipient>
    {
        private readonly DebugRecipientsStore _recipientsStore;

        public RecipientsManager(DebugRecipientsStore recipientsStore) => _recipientsStore = recipientsStore;

        public override IEnumerable<Recipient> Read() => _recipientsStore?.Recipients;

        public override void Add(Recipient item) => throw new NotImplementedException();

        public override void Update(Recipient item) => throw new NotImplementedException();

        public override void Delete(Recipient item) => throw new NotImplementedException();
    }
}
