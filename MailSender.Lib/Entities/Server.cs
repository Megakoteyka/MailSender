namespace MailSender.Lib.Entities
{
    public class Server
    {
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public ushort Port { get; set; }
        
        // ReSharper disable once InconsistentNaming
        public bool UseSSL { get; set; } = true;
        
        public string Login { get; set; }
        
        public string Password { get; set; }

        public override string ToString() => Name;
    }
}
