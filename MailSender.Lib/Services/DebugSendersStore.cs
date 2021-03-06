﻿using System.Collections.Generic;
using MailSender.Lib.Data;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;

namespace MailSender.Lib.Services
{
    public class DebugSendersStore : DebugStore<Sender>, ISendersStore
    {
        public DebugSendersStore():base(TestData.Senders)
        {
            
        }

        public override void Update(int id, Sender sender)
        {
            var dbSender = GetById(id);
            if (dbSender == null)
                return;

            dbSender.Name = sender.Name;
            dbSender.Address = sender.Address;
            dbSender.Comment = sender.Comment;
        }
    }
}
