namespace MailSender.Lib.Entities
{
    public class PersonEntity : NamedEntity
    {
        public string Address { get; set; }

        public override string ToString() => base.ToString() + $", Address = {Address}";
    }
}