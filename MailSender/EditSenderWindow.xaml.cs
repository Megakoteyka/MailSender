using System.Windows;
using MailSender.Lib.Entities;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для EditSenderWindow.xaml
    /// </summary>
    public partial class EditSenderWindow : Window
    {
        public EditSenderWindow()
        {
            InitializeComponent();
        }

        private void ButtonOk_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
