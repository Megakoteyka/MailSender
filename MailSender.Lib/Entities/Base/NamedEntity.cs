using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MailSender.Lib.Entities.Base
{
    public class NamedEntity : Entity, IDataErrorInfo
    {
        [Required]
        public string Name { get; set; }

        [NotMapped]
        public virtual string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Name):

                        if (string.IsNullOrWhiteSpace(Name))
                            return "Имя не может быть пустым";
                        if (Name.Length < 2)
                            return "Имя не может быть короче двух символов";
                        if (Name.Length > 30)
                            return "Имя не может быть длинее 30 символов";
                        break;
                }

                return null;
            }
        }

        [NotMapped]
        public virtual string Error => null;

        public override string ToString() => base.ToString() + $", Name = {Name}";
    }
}