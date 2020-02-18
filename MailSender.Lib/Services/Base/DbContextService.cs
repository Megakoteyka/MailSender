using System;
using System.Data.Entity;

namespace MailSender.Lib.Services.Base
{
    public class DbContextService<T> where T : DbContext, new()
    {
        public void Do(Action<T> action)
        {
            using (var db = new T()) action?.Invoke(db);
        }
    }
}
