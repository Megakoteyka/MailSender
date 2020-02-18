using System.Collections.Generic;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;

namespace MailSender.Lib.Services
{
    public class RecipientsManager : IRecipientsManager
    {
        private readonly IStore<Recipient> _recipientsStore;

        public RecipientsManager(IStore<Recipient> recipientsStore) => _recipientsStore = recipientsStore;

        public IEnumerable<Recipient> Read() => _recipientsStore?.GetItems();

        public void Add(Recipient item) =>
            System.Diagnostics.Debug.WriteLine($"RecipientsManager.Create Id = {item.Id}, Name = {item.Name}, Address = {item.Address}");

        public void Update(Recipient item) =>
            System.Diagnostics.Debug.WriteLine($"RecipientsManager.Update Id = {item.Id}, Name = {item.Name}, Address = {item.Address}");

        public void Delete(Recipient item) =>
            System.Diagnostics.Debug.WriteLine($"RecipientsManager.Delete Id = {item.Id}, Name = {item.Name}, Address = {item.Address}");

    }
}
