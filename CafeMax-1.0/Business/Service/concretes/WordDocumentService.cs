using CafeMax.Business.Service.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using CafeMax.DataAccess.report;
using CafeMax.Business.Entity;
using CafeMax.DataAccess.orderdetail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CafeMax.Business.Service.concretes
{
    internal class WordDocumentService : IWordDocumentService
    {
        public void CreateZRaport(string username)
        {
            ReportManager reportManager = new ReportManager();

            ZReport zReport = new ZReport();

            // Şu anki tarihi ve saati al
            DateTime now = DateTime.Now;

            // Saat 6:00 için bir DateTime nesnesi oluştur
            DateTime sixAM = new DateTime(now.Year, now.Month, now.Day, 6, 0, 0);


            if (now < sixAM)
            {
                // Şu anki tarihi al
                DateTime today = DateTime.Today;

                // Bir gün öncesini hesapla
                DateTime previousDay = today.AddDays(-1);

                DateTime firstDate = new DateTime(previousDay.Year, previousDay.Month, previousDay.Day, 6, 0, 0);

                zReport = reportManager.GetZRaport(firstDate, DateTime.Now);
            }
            else 
            {
                DateTime firstDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 6, 0, 0);
                zReport = reportManager.GetZRaport(firstDate, DateTime.Now); 
            }

            //ZReport zReport = reportManager.GetZRaport();


            string fileName = "ZRaporu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".docx";
            string folderPath = @"C:\CafeMaxRaporlar\ZRaporu";
            string filePath = Path.Combine(folderPath, fileName);

            // Klasör yoksa oluştur
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Word belgesini oluştur
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                // MainDocumentPart ekle
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                DocumentFormat.OpenXml.Wordprocessing.Body body = mainPart.Document.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Body());

                // Paragraf ekle
                Paragraph para1 = body.AppendChild(new Paragraph());
                Run run1 = para1.AppendChild(new Run());
                run1.AppendChild(new Text("CafeMax Z Raporu"));

                // Paragraf özelliklerini belirle
                ParagraphProperties paraProps1 = new ParagraphProperties();
                Justification justification1 = new Justification() { Val = JustificationValues.Center };
                paraProps1.Append(justification1);
                para1.Append(paraProps1);

                RunProperties runProps1 = new RunProperties();

                // Bold yap
                Bold bold = new Bold();
                runProps1.Append(bold);

                // 14 punto yap (1/2 pt cinsinden)
                FontSize fontSize = new FontSize() { Val = "28" }; // 14 * 2 = 28
                runProps1.Append(fontSize);


                Paragraph para2 = body.AppendChild(new Paragraph());
                Run run2 = para2.AppendChild(new Run());
                run2.AppendChild(new Text("Olympos Pub"));

                Paragraph para0 = body.AppendChild(new Paragraph());
                Run run0 = para0.AppendChild(new Run());
                run0.AppendChild(new Text("--------------------------------------------"));

                Paragraph para3 = body.AppendChild(new Paragraph());
                Run run3 = para3.AppendChild(new Run());
                run3.AppendChild(new Text("İşlem Tarihi: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));

                Paragraph para4 = body.AppendChild(new Paragraph());
                Run run4 = para4.AppendChild(new Run());
                run4.AppendChild(new Text($"Başlangıç: {DateTime.Now.ToString("yyyy-MM-dd")} 06:00:00"));

                Paragraph para5 = body.AppendChild(new Paragraph());
                Run run5 = para5.AppendChild(new Run());
                run5.AppendChild(new Text($"Bitiş: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}"));

                Paragraph para6 = body.AppendChild(new Paragraph());
                Run run6 = para6.AppendChild(new Run());
                run6.AppendChild(new Text($"Kullanıcı: {username}"));

                Paragraph para01 = body.AppendChild(new Paragraph());
                Run run01 = para01.AppendChild(new Run());
                run01.AppendChild(new Text("--------------------------------------------"));

                Paragraph para7 = body.AppendChild(new Paragraph());
                Run run7 = para7.AppendChild(new Run());
                run7.AppendChild(new Text("Toplam Satış"));

                Paragraph para8 = body.AppendChild(new Paragraph());
                Run run8 = para8.AppendChild(new Run());
                run8.AppendChild(new Text($"Miktar: {zReport.SaleAmount}"));

                Paragraph para9 = body.AppendChild(new Paragraph());
                Run run9 = para9.AppendChild(new Run());
                run9.AppendChild(new Text($"Tutar: {zReport.SaleTotalPrice}₺"));

                Paragraph para02 = body.AppendChild(new Paragraph());
                Run run02 = para02.AppendChild(new Run());
                run02.AppendChild(new Text("--------------------------------------------"));

                Paragraph para10 = body.AppendChild(new Paragraph());
                Run run10 = para10.AppendChild(new Run());
                run10.AppendChild(new Text("Ürün Gruplarına Göre Satışlar"));

                CreateTable(zReport.OrderDetails, body, "Grup", "Miktar", "Tutar");

                Paragraph para03 = body.AppendChild(new Paragraph());
                Run run03 = para03.AppendChild(new Run());
                run03.AppendChild(new Text("--------------------------------------------"));

                Paragraph para12 = body.AppendChild(new Paragraph());
                Run run12 = para12.AppendChild(new Run());
                run12.AppendChild(new Text("Giderler"));

                CreateTable(zReport.Expenses, body, "Gider", "Miktar", "Ödenen");

                Paragraph para04 = body.AppendChild(new Paragraph());
                Run run04 = para04.AppendChild(new Run());
                run04.AppendChild(new Text("--------------------------------------------"));

                Paragraph para14 = body.AppendChild(new Paragraph());
                Run run14 = para14.AppendChild(new Run());
                run14.AppendChild(new Text("Ödeme Türüne Göre Tahsilatlar"));

                Paragraph para15 = body.AppendChild(new Paragraph());
                Run run15 = para15.AppendChild(new Run());
                run15.AppendChild(new Text($"Nakit: {zReport.CashPaid}₺"));

                Paragraph para16 = body.AppendChild(new Paragraph());
                Run run16 = para16.AppendChild(new Run());
                run16.AppendChild(new Text($"Kredi Kartı: {zReport.CreditCardPaid}₺"));

                Paragraph para05 = body.AppendChild(new Paragraph());
                Run run05 = para05.AppendChild(new Run());
                run05.AppendChild(new Text("--------------------------------------------"));

                Paragraph para17 = body.AppendChild(new Paragraph());
                Run run17 = para17.AppendChild(new Run());
                run17.AppendChild(new Text($"Toplam Gider: {zReport.ExpenseTotalPrice}₺"));

                Paragraph para18 = body.AppendChild(new Paragraph());
                Run run18 = para18.AppendChild(new Run());
                run18.AppendChild(new Text($"Toplam İndirim: {zReport.TotalDiscount}₺"));

                Paragraph para19 = body.AppendChild(new Paragraph());
                Run run19 = para19.AppendChild(new Run());
                run19.AppendChild(new Text($"Toplam Ciro: {zReport.SaleTotalPrice}₺"));

                

                SetDocumentAsReadOnly(wordDocument);

                // Belgeyi kaydet
                mainPart.Document.Save();
            }

            static void SetDocumentAsReadOnly(WordprocessingDocument doc)
            {
                // Get or create the DocumentSettingsPart
                var settingsPart = doc.MainDocumentPart.DocumentSettingsPart;
                if (settingsPart == null)
                {
                    settingsPart = doc.MainDocumentPart.AddNewPart<DocumentSettingsPart>();
                }

                // Get or create the Settings element
                var settings = settingsPart.Settings;
                if (settings == null)
                {
                    settings = new Settings();
                    settingsPart.Settings = settings;
                }

                // Remove any existing protection
                settings.RemoveAllChildren<DocumentProtection>();

                // Apply read-only protection
                var dp = new DocumentProtection
                {
                    Edit = DocumentProtectionValues.ReadOnly,
                    Enforcement = true,
                    CryptographicAlgorithmClass = CryptAlgorithmClassValues.Hash,
                    CryptographicProviderType = CryptProviderValues.RsaFull,
                    CryptographicAlgorithmType = CryptAlgorithmValues.TypeAny,
                    Hash = "12345678901234567890123456789012"
                };

                // Append DocumentProtection to Settings
                settings.Append(dp);

                // Save changes to the DocumentSettingsPart
                settingsPart.Settings.Save();
            }

            static TableCell CreateTextCell(string text, string width)
            {
                TableCell cell = new TableCell();

                // Hücre genişliği ayarı
                TableCellProperties tcp = new TableCellProperties();
                TableCellWidth cellWidth = new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = width };
                tcp.Append(cellWidth);

                cell.Append(tcp);
                cell.Append(new Paragraph(new Run(new Text(text))));

                return cell;
            }

            static void CreateTable(object list, DocumentFormat.OpenXml.Wordprocessing.Body body, string tcText, string tc1Text, string tc2Text)
            {
                DocumentFormat.OpenXml.Wordprocessing.Table table = new DocumentFormat.OpenXml.Wordprocessing.Table();

                TableRow tr = new TableRow();

                TableCell tc = CreateTextCell(tcText, "3000");

                TableCell tc1 = CreateTextCell(tc1Text, "1000");

                TableCell tc2 = CreateTextCell(tc2Text, "1000");

                tr.Append(tc, tc1, tc2);

                table.Append(tr);

                if (list is List<OrderDetail> orderDetails)
                {
                    foreach (OrderDetail orderDetail in orderDetails)
                    {
                        TableRow tr0 = new TableRow();

                        TableCell tc0 = CreateTextCell($"{orderDetail.ProductName}", "3000");

                        TableCell tc01 = CreateTextCell($"{orderDetail.Amount}", "1000");

                        TableCell tc02 = CreateTextCell($"{orderDetail.TotalPrice}₺", "1000");

                        tr0.Append(tc0, tc01, tc02);

                        table.Append(tr0);
                    }
                }

                if (list is List<Expense> expenses)
                {
                    foreach (Expense expense in expenses)
                    {
                        TableRow tr0 = new TableRow();

                        TableCell tc0 = CreateTextCell($"{expense.Type}", "3000");

                        TableCell tc01 = CreateTextCell($"{expense.Amount}", "1000");

                        TableCell tc02 = CreateTextCell($"{expense.Paid}₺", "1000");

                        tr0.Append(tc0, tc01, tc02);

                        table.Append(tr0);
                    }
                }


                // Tabloyu gövdeye ekle
                body.Append(table);
            }
        }
    }
}
