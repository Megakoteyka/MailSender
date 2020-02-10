namespace MailSender.Lib.Entities
{
    public class Recipient:Entity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public override string ToString() => Name;
    }
}
