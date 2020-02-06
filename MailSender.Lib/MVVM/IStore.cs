using System.Collections.Generic;

namespace MailSender.Lib.MVVM
{
    public interface IStore<out T>
    {
        IEnumerable<T> Items { get; }
    }
}