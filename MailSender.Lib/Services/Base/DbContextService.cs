using System;
using System.Data.Entity;
using MailSender.Lib.Interfaces;

namespace MailSender.Lib.Services.Base
{
    public class DbContextService<TDbContext> : IDbContextService<TDbContext> where TDbContext: DbContext, new()
    {
        //public object Do(Func<TDbContext, object> action)
        //{
        //    using (var db = new TDbContext()) 
        //        return action?.Invoke(db);
        //}

        public TDbContext GetDbContext() => new TDbContext();
    }
}
