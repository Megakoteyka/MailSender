using System;
using System.ComponentModel;
using MailSender.Lib.Entities.Base;
using MailSender.Lib.Reports;

namespace MailSender.Lib.Entities
{
    public class Sender: PersonEntity, ICloneable
    {
        [IncludeToReport]
        [DisplayName("Комментарий")]
        public string Comment { get; set; }

        public object Clone() => new Sender
        {
            Name = Name?.Clone() as string, 
            Address = Address?.Clone() as string, 
            Comment = Comment?.Clone() as string
        };

        public override string ToString() => base.ToString() + $", Comment = {Comment}";
    }
}
