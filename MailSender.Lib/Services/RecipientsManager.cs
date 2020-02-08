using System;
using System.Collections.Generic;
using MailSender.Lib.Entities;
using MailSender.Lib.MVVM;

namespace MailSender.Lib.Services
{
    public class RecipientsManager : DataManager<Recipient>
    {
        private readonly IStore<Recipient> _recipientsStore;

        public RecipientsManager(IStore<Recipient> recipientsStore) => _recipientsStore = recipientsStore;

        public override IEnumerable<Recipient> Read() => _recipientsStore?.Items;

        public override void Add(Recipient item) => throw new NotImplementedException();

        public override void Update(Recipient item) => throw new NotImplementedException();

        public override void Delete(Recipient item) => throw new NotImplementedException();
    }
}
