using System.ComponentModel.DataAnnotations;
using MailSender.Lib.Entities.Base;

namespace MailSender.Lib.Entities
{
    public class Mail : Entity
    {
        public string Subject { get; set; }
        
        [Required]
        public string Body { get; set; }
    }
}
