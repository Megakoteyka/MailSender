using System;
using System.ComponentModel.DataAnnotations;
using MailSender.Lib.Entities.Base;

namespace MailSender.Lib.Entities
{
    public class Server : NamedEntity, ICloneable
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

        public object Clone()
        {
            return new Server
            {
                Id=Id,
                Name = Name?.Clone() as string,
                Address = Address?.Clone() as string,
                Port = Port,
                UseSSL = UseSSL,
                Login = Login?.Clone() as string,
                Password = Password.Clone() as string
            };
        }
    }
}
