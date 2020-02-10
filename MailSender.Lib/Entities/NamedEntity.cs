namespace MailSender.Lib.Entities
{
    public class NamedEntity : Entity
    {
        public string Name { get; set; }

        public override string ToString() => base.ToString() + $", Name = {Name}";
    }
}