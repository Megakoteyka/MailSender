using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security;
using System.Windows;
using System.Windows.Media;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<MailServerInfo> Servers => MailServerInfo.Servers;

        public MailServerInfo Server { get; set; }
        public string UserName { get; set; }
        public SecureString Password { get; set; }

        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Server = Servers.FirstOrDefault();
        }

        private void ButtonSend_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Password = PasswordBox.SecurePassword;

                EmailSendServiceClass.SendMail(From, To, Subject, Body, Server, UserName, Password);

                var text = $"From: {From}\nTo: {To}\nSubject: {Subject}\nBody: {Body}\n\n";
                MessageWindow.Show("Ура!", text + "Сообщение как будто отправлено, но на самом деле нет.", Brushes.Green);
            }
            catch (Exception exception)
            {
                MessageWindow.Show("Ошибка!", exception.ToString(), Brushes.Red);
            }
        }
    }
}
