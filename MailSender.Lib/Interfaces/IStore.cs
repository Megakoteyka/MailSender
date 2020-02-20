using System.Collections.Generic;

namespace MailSender.Lib.Interfaces
{
    public interface IStore<T>
    {
        IEnumerable<T> GetItems();

        T GetById(int id);

        int Create(T item);
        void Update(int id, T item);
        T Delete(int id);

        //void SaveChanges();
    }
}