using System.Collections.ObjectModel;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Data
{
    public static class TestData
    {
        public static readonly ObservableCollection<Server> Servers = new ObservableCollection<Server>
        {
            new Server{Id = 1, Name = "Яндекс", Address = "smtp.yandex.ru", Port = 587, Login = "login", Password = "pass"},
            new Server{Id = 2, Name = "Mail.ru", Address = "smtp.mail.ru", Port = 587, Login = "login", Password = "pass"},
            new Server{Id = 3, Name = "GMail", Address = "smtp.gmail.com", Port = 587, Login = "login", Password = "pass"}
        };

        public static readonly ObservableCollection<Sender> Senders=new ObservableCollection<Sender>
        {
            new Sender{Id = 1, Name = "Alice", Address = "alice@mail.ru"},
            new Sender{Id = 2, Name = "Bob", Address = "bob@yandex.ru"},
            new Sender{Id = 3, Name = "Carol", Address = "carol@gmail.com"}
        };

        public static readonly ObservableCollection<Recipient> Recipients = new ObservableCollection<Recipient>
        {
            new Recipient{Id = 1, Name = "Alice", Address = "alice@mail.ru"},
            new Recipient{Id = 2, Name = "Bob", Address = "bob@yandex.ru"},
            new Recipient{Id = 3, Name = "Carol", Address = "carol@gmail.com"}
        };

        public static readonly ObservableCollection<Letter> Letters = new ObservableCollection<Letter>()
        {
            new Letter {Id = 1, Subject = "Письмо 1", Body = "Проверка рассыльщика писем 1"},
            new Letter {Id = 2, Subject = "Письмо 2", Body = "Проверка рассыльщика писем 2"},
            new Letter {Id = 3, Subject = "Письмо 3", Body = "Проверка рассыльщика писем 3"},
        };
    }
}
