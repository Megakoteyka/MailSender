﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Lib.Entities;

namespace MailSender.Lib.Data
{
    public static class TestData
    {
        public static ObservableCollection<Server> Servers = new ObservableCollection<Server>
        {
            new Server{Name = "Яндекс", Address = "smtp.yandex.ru", Port = 587, Login = "login", Password = "pass"},
            new Server{Name = "Mail.ru", Address = "smtp.mail.ru", Port = 587, Login = "login", Password = "pass"},
            new Server{Name = "GMail", Address = "smtp.gmail.com", Port = 587, Login = "login", Password = "pass"}
        };

        public static ObservableCollection<Sender> Senders=new ObservableCollection<Sender>
        {
            new Sender{Name = "Alice", Address = "alice@mail.ru"},
            new Sender{Name = "Bob", Address = "bob@yandex.ru"},
            new Sender{Name = "Carol", Address = "carol@gmail.com"}
        };

        public static ObservableCollection<Recipient> Recipients = new ObservableCollection<Recipient>
        {
            new Recipient{Name = "Alice", Address = "alice@mail.ru"},
            new Recipient{Name = "Bob", Address = "bob@yandex.ru"},
            new Recipient{Name = "Carol", Address = "carol@gmail.com"}
        };
    }
}