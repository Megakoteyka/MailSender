using System;
using System.ComponentModel.DataAnnotations;
using MailSender.Lib.Entities.Base;

namespace MailSender.Lib.Entities
{
    public class SchedulerTask : Entity
    {
        [Required]
        public DateTime Time { get; set; }

        [Required]
        public Server Server { get; set; }

        [Required]
        public Sender Sender { get; set; }

        [Required]
        public MailingList MailingList { get; set; }

        public override string ToString() => 
            base.ToString() + 
            $", Time = {Time}" +
            $", ServerId = {Server.Id}" +
            $", SenderId = {Sender.Id}" +
            $", MailingListId = {MailingList.Id}";
    }
}