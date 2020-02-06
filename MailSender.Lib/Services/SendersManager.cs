using System;
using System.Collections.Generic;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Services
{
    public class SendersManager:DataManager<Sender>
    {
        private readonly DebugSendersStore _sendersStore;

        public SendersManager(DebugSendersStore sendersStore) => _sendersStore = sendersStore;

        public override IEnumerable<Sender> Read() => _sendersStore?.Senders;

        public override void Add(Sender item) => throw new NotImplementedException();

        public override void Update(Sender item) => throw new NotImplementedException();

        public override void Delete(Sender item) => throw new NotImplementedException();
    }
}
