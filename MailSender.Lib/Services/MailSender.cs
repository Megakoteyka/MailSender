using System.Net;
using System.Net.Mail;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Services
{
    public class MailSender
    {
        private readonly string _address;
        private readonly ushort _port;
        private readonly bool _useSsl;
        private readonly string _login;
        private readonly string _password;

        public MailSender(string address, ushort port, bool useSsl, string login, string password)
        {
            _address = address;
            _port = port;
            _useSsl = useSsl;
            _login = login;
            _password = password;
        }

        public MailSender(Server server)
        {
            _address = server.Address;
            _port = server.Port;
            _useSsl = server.UseSSL;
            _login = server.Login;
            _password = server.Password;
        }

        public void Send(string subject, string body, string from, string to)
        {
            using (var msg = new MailMessage(from, to, subject, body))
            {
                var account = new NetworkCredential(_login, _password);
                using (var client = new SmtpClient(_address, _port) {EnableSsl = _useSsl, Credentials=account})
                    client.Send(msg);
            }
        }
    }
}
