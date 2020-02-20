using System.Windows;

namespace MailSender.Views
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

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
