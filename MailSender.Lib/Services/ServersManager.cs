using System;
using System.Collections.Generic;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;

namespace MailSender.Lib.Services
{
    public class ServersManager : IServersManager
    {
        private readonly IServersStore _serversStore;

        public ServersManager(IServersStore serversStore) => _serversStore = serversStore;

        public IEnumerable<Server> Read() => _serversStore?.GetItems();

        public void Add(Server item) => _serversStore?.Create(item);

        public void Update(Server item) => _serversStore?.Update(item.Id, item);

        public void Delete(Server item) => _serversStore?.Delete(item.Id);
    }
}
