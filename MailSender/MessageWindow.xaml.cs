using System.Windows;
using System.Windows.Media;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MessageWindow.xaml
    /// </summary>
    public partial class MessageWindow : Window
    {
        public string Caption { get; set; }
        public string MessageText { get; set; }
        public Brush MessageBrush { get; set; }

        public static void Show(string caption, string messageText, Brush messageBrush)
        {
            new MessageWindow
            {
                Caption = caption,
                MessageText = messageText,
                MessageBrush = messageBrush
            }.ShowDialog();
        }

        public MessageWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void ButtonOk_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
