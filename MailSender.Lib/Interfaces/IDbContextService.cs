using System;
using System.Data.Entity;

namespace MailSender.Lib.Interfaces
{
    public interface IDbContextService<TDbContext> where TDbContext : DbContext, new()
    {
        //object Do(Func<TDbContext, object> action);

        TDbContext GetDbContext();
    }
}
