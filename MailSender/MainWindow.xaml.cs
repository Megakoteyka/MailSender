using System;
using System.Windows;
using MailSender.Lib.Data;
using MailSender.Lib.Entities;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonEditSender_OnClick(object sender, RoutedEventArgs e)
        {
            var mailSender = CbSenders.SelectedValue as Sender;
            if (mailSender == null) throw new ArgumentNullException(nameof(mailSender));

            var dialog = new EditSenderWindow {DataContext = mailSender.Clone() as Sender};
            if (dialog.ShowDialog() != true)
                return;

            var index = TestData.Senders.IndexOf(mailSender);
            TestData.Senders.RemoveAt(index);
            TestData.Senders.Insert(index, dialog.DataContext as Sender);
            CbSenders.SelectedIndex = index;
        }
    }
}
