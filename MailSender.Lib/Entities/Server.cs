using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MailSender.Lib.Entities.Base;
using MailSender.Lib.Reports;

namespace MailSender.Lib.Entities
{
    public class Server : NamedEntity, ICloneable
    {
        [Required]
        [IncludeToReport]
        [DisplayName("Адрес")]
        public string Address { get; set; }
        
        [Required]
        [IncludeToReport]
        [DisplayName("Порт")]
        public int Port { get; set; }
        
        // ReSharper disable once InconsistentNaming
        [Required]
        [IncludeToReport]
        [DisplayName("SSL")]
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
