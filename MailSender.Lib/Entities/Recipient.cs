namespace MailSender.Lib.Entities
{
    public class Recipient
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public override string ToString() => Name;
    }
}
