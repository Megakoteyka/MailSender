﻿using System.Collections.Generic;
using MailSender.Lib.Data;
using MailSender.Lib.Entities;
using MailSender.Lib.Interfaces;

namespace MailSender.Lib.Services
{
    public class DebugRecipientsStore : DebugStore<Recipient>, IRecipientsStore
    {
        public DebugRecipientsStore() : base(TestData.Recipients)
        {
        }

        public override void Update(int id, Recipient recipient)
        {
            var dbRecipient = GetById(id);
            if (dbRecipient == null)
                return;
            dbRecipient.Name = recipient.Name;
            dbRecipient.Address = recipient.Address;
        }
    }
}
