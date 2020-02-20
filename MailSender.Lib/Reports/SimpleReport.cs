using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace MailSender.Lib.Reports
{
    public static class SimpleReport<T>
    {
        private static TableCellWidth DefaultTableCellWidth => new TableCellWidth
        {
            Type = new EnumValue<TableWidthUnitValues>(TableWidthUnitValues.Pct), Width = "1"
        };

        private static TableCellMargin DefaultCellMargin => new TableCellMargin
        {
            LeftMargin = new LeftMargin { Type = new EnumValue<TableWidthUnitValues>(TableWidthUnitValues.Dxa), Width = "50" },
            RightMargin = new RightMargin { Type = new EnumValue<TableWidthUnitValues>(TableWidthUnitValues.Dxa), Width = "50" },
        };


        /// <summary>
        /// Создает отчет в виде файла .docx. В отчет попадают все свойства, имеющие атрибут IncludeToReportAttribute.
        /// </summary>
        /// <param name="fileName">имя файла отчета</param>
        /// <param name="header">заголовок отчета</param>
        /// <param name="items">элементы, которые должны быть включены в отчет</param>
        public static void Create(string fileName, string header, IEnumerable<T> items)
        {
            using (var wordDocument = WordprocessingDocument.Create(fileName, WordprocessingDocumentType.Document))
            {
                var mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                var body = mainPart.Document.AppendChild(new Body());

                // заголовок
                var paragraph = body.AppendChild(new Paragraph());
                var run = paragraph.AppendChild(new Run());
                run.AppendChild(new Text(header));

                // таблица с данными
                var table = body.AppendChild(new Table());

                table.AppendChild(new TableProperties(
                    new TableBorders(
                        new TopBorder {Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2, Color = new StringValue("Gray")},
                        new BottomBorder {Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2, Color = new StringValue("Gray") },
                        new LeftBorder {Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2, Color = new StringValue("Gray") },
                        new RightBorder {Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2, Color = new StringValue("Gray") },
                        new InsideHorizontalBorder {Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2, Color = new StringValue("Gray") },
                        new InsideVerticalBorder {Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 2, Color = new StringValue("Gray")})));

                // в отчет попадут все свойства, помеченные атрибутом IncludeToReportAttribute
                var properties = typeof(T).GetProperties()
                    .Where(p => p.GetCustomAttribute<IncludeToReportAttribute>() != null).Reverse().ToArray();

                // заголовок таблицы
                table.AppendChild(CreateRow(properties.Select(GetDisplayName)));

                // строки с данными
                table.Append(items.Select(item => CreateRow(properties.Select(p => p.GetValue(item)))));
            }
        }

        /// <summary>
        /// именем свойства будет считаться значение из атрибута DisplayNameAttribute
        /// либо непосредственно имя свойства, если атрибут отсутствует
        /// </summary>
        private static string GetDisplayName(PropertyInfo property) =>
            property.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? property.Name;

        private static TableRow CreateRow(IEnumerable<object> values) => new TableRow(values.Select(CreateCell));

        private static TableCell CreateCell(object value) => new TableCell(
            new TableCellProperties(DefaultTableCellWidth, DefaultCellMargin),
            new Paragraph(new Run(new Text(value?.ToString() ?? ""))));
    }
}
