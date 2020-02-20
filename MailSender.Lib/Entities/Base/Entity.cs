using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MailSender.Lib.Reports;

namespace MailSender.Lib.Entities.Base
{
    public class Entity
    {
        [IncludeToReport]
        [DisplayName("ID")]
        public int Id { get; set; }

        public override string ToString() => $"Id = {Id}";
    }
}
