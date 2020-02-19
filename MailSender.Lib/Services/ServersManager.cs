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

        public void Add(Server item) => throw new NotImplementedException();

        public void Update(Server item) => throw new NotImplementedException();

        public void Delete(Server item) => throw new NotImplementedException();
    }
}
