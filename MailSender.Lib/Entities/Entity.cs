namespace MailSender.Lib.Entities
{
    public class Entity
    {
        public int Id { get; set; }

        public override string ToString() => $"Id = {Id}";
    }
}
