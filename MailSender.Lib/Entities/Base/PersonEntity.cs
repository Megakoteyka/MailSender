using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using MailSender.Lib.Reports;

namespace MailSender.Lib.Entities.Base
{
    public class PersonEntity : NamedEntity
    {
        [IncludeToReport]
        [DisplayName("Адрес")]
        public string Address { get; set; }

        [NotMapped]
        public override string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Address):
                        if (!new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(Address))
                            return "неверный формат email-адреса";
                        break;
                }

                return base[columnName];
            }
        }

        public override string ToString() => base.ToString() + $", Address = {Address}";
    }
}