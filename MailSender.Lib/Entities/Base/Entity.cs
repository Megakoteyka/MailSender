namespace MailSender.Lib.Entities.Base
{
    public class Entity
    {
        public int Id { get; set; }

        public override string ToString() => $"Id = {Id}";
    }
}
