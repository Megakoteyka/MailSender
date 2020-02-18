using System.Data.Entity;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Data
{
    public class MailSenderDbContext : DbContext
    {
        public DbSet<Server> Servers { get; set; }

        public DbSet<Sender> Senders { get; set; }

        public DbSet<Recipient> Recipients { get; set; }

        public DbSet<Letter> Letters { get; set; }

        public DbSet<MailingList> MailingLists { get; set; }

        public DbSet<SchedulerTask> SchedulerTasks { get; set; }




        public MailSenderDbContext()
        {
        }
    }
}
