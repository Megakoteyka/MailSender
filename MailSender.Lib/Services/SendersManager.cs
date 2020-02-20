using System;
using System.Collections.Generic;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;

namespace MailSender.Lib.Services
{
    public class SendersManager:ISendersManager
    {
        private readonly ISendersStore _sendersStore;

        public SendersManager(ISendersStore sendersStore) => _sendersStore = sendersStore;

        public IEnumerable<Sender> Read() => _sendersStore?.GetItems();

        public void Add(Sender item) => throw new NotImplementedException();

        public void Update(Sender item) => throw new NotImplementedException();

        public void Delete(Sender item) => throw new NotImplementedException();
    }
}
