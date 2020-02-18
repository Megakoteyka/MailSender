using System.ComponentModel.DataAnnotations;
using MailSender.Lib.Entities.Base;

namespace MailSender.Lib.Entities
{
    public class Server : NamedEntity
    {
        [Required]
        public string Address { get; set; }
        
        [Required]
        public ushort Port { get; set; }
        
        // ReSharper disable once InconsistentNaming
        [Required]
        public bool UseSSL { get; set; } = true;
        
        [Required]
        public string Login { get; set; }
        
        [Required]
        public string Password { get; set; }

        public override string ToString() =>
            base.ToString() +
            $", Address = {Address}:{Port}" +
            $", Use SSL = {UseSSL}" +
            $", Login = {Login}" +
            $", Password = {Password}";
    }
}
