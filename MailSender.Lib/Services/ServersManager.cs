using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Services
{
    public class ServersManager:DataManager<Server>
    {
        private readonly DebugServersStore _serversStore;

        public ServersManager(DebugServersStore serversStore) => _serversStore = serversStore;

        public override IEnumerable<Server> Read() => _serversStore?.Servers;

        public override void Add(Server item) => throw new NotImplementedException();

        public override void Update(Server item) => throw new NotImplementedException();

        public override void Delete(Server item) => throw new NotImplementedException();
    }
}
