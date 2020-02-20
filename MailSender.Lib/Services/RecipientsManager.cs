using System.Collections.Generic;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;

namespace MailSender.Lib.Services
{
    public class RecipientsManager : IRecipientsManager
    {
        private readonly IRecipientsStore _recipientsStore;

        public RecipientsManager(IRecipientsStore recipientsStore) => _recipientsStore = recipientsStore;

        public IEnumerable<Recipient> Read() => _recipientsStore?.GetItems();

        public void Add(Recipient item) => _recipientsStore.Create(item);

        public void Update(Recipient item) => _recipientsStore.Update(item.Id, item);

        public void Delete(Recipient item) => _recipientsStore.Delete(item.Id);
    }
}
