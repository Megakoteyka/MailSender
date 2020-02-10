using System;
using System.Collections.Generic;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;
using MailSender.Lib.MVVM;

namespace MailSender.Lib.Services
{
    public class ServersManager:IServersManager
    {
        private readonly IStore<Server> _serversStore;

        public ServersManager(IStore<Server> serversStore) => _serversStore = serversStore;

        public IEnumerable<Server> Read() => _serversStore?.GetItems();

        public void Add(Server item) => throw new NotImplementedException();

        public void Update(Server item) => throw new NotImplementedException();

        public void Delete(Server item) => throw new NotImplementedException();
    }
}
