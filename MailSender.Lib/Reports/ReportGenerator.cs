using System.Windows.Input;

namespace MailSender.Lib.Reports
{
    /// <summary>
    /// Вспомогательный класс для размещения кнопки создания отчета
    /// </summary>
    public class ReportGenerator
    {
        public string Name { get; }
        public ICommand GenerateReportCommand { get; }

        public ReportGenerator(string name, ICommand generateReportCommand)
        {
            Name = name;
            GenerateReportCommand = generateReportCommand;
        }
    }
}
