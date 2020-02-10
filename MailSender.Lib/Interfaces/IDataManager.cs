using System.Collections.Generic;

namespace MailSender.Lib.Interfaces
{
    public interface IDataManager<T>
    {
        IEnumerable<T> Read();
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}