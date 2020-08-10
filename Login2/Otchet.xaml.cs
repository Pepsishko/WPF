using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login2
{
    public partial class Otchet : Window
    {
        static string nameofForm = "";
        List<int> kolvo = new List<int>();
        static int check;
        static string path2 = "";
        List<string> name = new List<string>();
        static List<string> perch = new List<string>();
        static List<string> price = new List<string>();
        public Otchet(int s)
        {
            InitializeComponent();
            check = s;
            string path = Directory.GetCurrentDirectory() + "\\otdel.txt";
            string path1 = Directory.GetCurrentDirectory() + "\\op.txt";
            path2 = Directory.GetCurrentDirectory() + "\\Otchett.pdf";
            if (s == 0)
            {
                string temp = "";
                using (StreamReader sr = new StreamReader(path1))
                {
                    temp = sr.ReadToEnd();
                }
                var kek = temp.Split('#');
                var kek1 = kek[s].Split(',');
                for (int z = 0; z < kek1.Length; z++)
                {
                    kolvo.Add(Convert.ToInt32(kek1[z]));
                }
            }
            if (s == 1)
            {
                string temp = "";
                using (StreamReader sr = new StreamReader(path1))
                {
                    temp = sr.ReadToEnd();
                }
                var kek = temp.Split('#');
                var kek1 = kek[s].Split(',');
                for (int z = 0; z < kek1.Length; z++)
                {
                    kolvo.Add(Convert.ToInt32(kek1[z]));
                }
            }
            if (s == 2)
            {
                string temp = "";
                using (StreamReader sr = new StreamReader(path1))
                {
                    temp = sr.ReadToEnd();
                }
                var kek = temp.Split('#');
                var kek1 = kek[s].Split(',');
                for (int z = 0; z < kek1.Length; z++)
                {
                    kolvo.Add(Convert.ToInt32(kek1[z]));
                }
            }
            if (s == 3)
            {
                string temp = "";
                using (StreamReader sr = new StreamReader(path1))
                {
                    temp = sr.ReadToEnd();
                }
                var kek = temp.Split('#');
                var kek1 = kek[s].Split(',');
                for (int z = 0; z < kek1.Length; z++)
                {
                    kolvo.Add(Convert.ToInt32(kek1[z]));
                }
            }
            if (s == 4)
            {
                string temp = "";
                using (StreamReader sr = new StreamReader(path1))
                {
                    temp = sr.ReadToEnd();
                }
                var kek = temp.Split('#');
                var kek1 = kek[s].Split(',');
                for (int z = 0; z < kek1.Length; z++)
                {
                    kolvo.Add(Convert.ToInt32(kek1[z]));
                }
            }
            if (s == 5)
            {
                string temp = "";
                using (StreamReader sr = new StreamReader(path1))
                {
                    temp = sr.ReadToEnd();
                }
                var kek = temp.Split('#');
                var kek1 = kek[s].Split(',');
                for (int z = 0; z < kek1.Length; z++)
                {
                    kolvo.Add(Convert.ToInt32(kek1[z]));
                }
            }
            if (s == 6)
            {
                string temp = "";
                using (StreamReader sr = new StreamReader(path1))
                {
                    temp = sr.ReadToEnd();
                }
                var kek = temp.Split('#');
                var kek1 = kek[s].Split(',');
                for (int z = 0; z < kek1.Length; z++)
                {
                    kolvo.Add(Convert.ToInt32(kek1[z]));
                }
            }
            string j = "";

            name.Add("Гинекология");
            name.Add("Отоларингология");
            name.Add("Микрохирургия");
            name.Add("Колопроктология");
            name.Add("Урология");
            name.Add("Ортопедия");
            name.Add("Комбустиология");

            perch.Add("Перчатки хирургические стерильные PROTEXIS Latex Micro, Кардинал Хелс-Тайланд");
            perch.Add("Перчатки хирургические стерильные PROTEXIS Latex, Cardinal Health, Тайланд");
            perch.Add("Перчатки хирургические стерильные Gammeх PF Sensitivel (UK) Малайзия");
            perch.Add("Перчатки хирургические стерильные PROTEXIS Latex, Cardinal Health, Тайланд");
            perch.Add("Перчатки хирургические стерильные PROTEXIS Latex Micro, Кардинал Хелс-Тайланд");
            perch.Add("Перчатки хирургические стерильные PROTEGRITY LATEX NEU THERA#Перчатки хирургические стерильные PROTEXIS Latex Micro, Кардинал Хелс-Тайланд");
            perch.Add("Перчатки хирургические стерильные PROTEXIS Latex, Cardinal Health, Тайланд");

            price.Add("75,29");
            price.Add("68,63");
            price.Add("70");
            price.Add("68,63");
            price.Add("75,29");
            price.Add("118,38 75,29");
            price.Add("68,63");

            if (s == 0)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    j = sr.ReadToEnd();
                }
                this.Title = name[s];
                nameOt.Content = name[s];
                var temp = j.Split('#');
                var temp1 = temp[0].Split(',');
                foreach (string op in temp1)
                {
                    operation.Items.Add(op);
                }
            }
            if (s == 1)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    j = sr.ReadToEnd();
                }
                this.Title = name[s];
                nameOt.Content = name[s];
                var temp = j.Split('#');
                var temp1 = temp[1].Split(',');
                foreach (string op in temp1)
                {
                    operation.Items.Add(op);
                }
            }
            if (s == 2)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    j = sr.ReadToEnd();
                }
                this.Title = name[s];
                nameOt.Content = name[s];
                var temp = j.Split('#');
                var temp1 = temp[2].Split(',');
                foreach (string op in temp1)
                {
                    operation.Items.Add(op);
                }
            }
            if (s == 3)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    j = sr.ReadToEnd();
                }
                this.Title = name[s];
                nameOt.Content= name[s];
                var temp = j.Split('#');
                var temp1 = temp[3].Split(',');
                foreach (string op in temp1)
                {
                    operation.Items.Add(op);
                }
            }
            if (s == 4)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    j = sr.ReadToEnd();
                }
                this.Title = name[s];
                nameOt.Content = name[s];
                var temp = j.Split('#');
                var temp1 = temp[4].Split(',');
                foreach (string op in temp1)
                {
                    operation.Items.Add(op);
                }
            }
            if (s == 5)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    j = sr.ReadToEnd();
                }
                this.Title = name[s];
                nameOt.Content = name[s];
                var temp = j.Split('#');
                var temp1 = temp[5].Split(',');
                foreach (string op in temp1)
                {
                    operation.Items.Add(op);
                }
            }
            if (s == 6)
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    j = sr.ReadToEnd();
                }
                this.Title = name[s];
                nameOt.Content = name[s];
                var temp = j.Split('#');
                var temp1 = temp[6].Split(',');
                foreach (string op in temp1)
                {
                    operation.Items.Add(op);
                }
            }
            nameofForm = this.Title;
        }
        int raschet(int choise, int amount)
        {
            if (choise == 0)
            {
                if (check == 5)
                {
                    return ((kolvo[choise] * 3) + kolvo[choise]) * amount;
                }
                return kolvo[choise] * amount;

            }
            else if (choise == 1)
            {
                return kolvo[choise] * amount;
            }
            else if (choise == 2)
            {
                return kolvo[choise] * amount;
            }
            else if (choise == 3)
            {
                return kolvo[choise] * amount;
            }
            return 0;
        }
        List<int> raschet1(int choise, int amount)
        {
            List<int> temp = new List<int>();
            temp.Add((kolvo[choise] * 3) * amount);
            temp.Add(kolvo[choise] * amount);
            return temp;
        }
        string labe = "";
        static int nasledie;
        static int nasledie1;
        static int nasledie2;
        static bool flag = false;

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            flag = false;
            try
            {
                if (check != 5)
                {
                    nasledie = raschet(operation.SelectedIndex, Convert.ToInt32(kolich.Text));
                  //  label2.Content = "Количество пар перчаток для операции " + operation.SelectedItem + " = " + raschet(operation.SelectedIndex, Convert.ToInt32(kolich.Text));
                }
                else
                {
                    if (operation.SelectedIndex == 0)
                    {
                        flag = true;
                        List<int> temp = raschet1(operation.SelectedIndex, Convert.ToInt32(kolich.Text));
                     //   label2.Content = "Количество пар перчаток для операции " + operation.SelectedItem + " = " + temp[0].ToString() + " и " + temp[1].ToString();
                        nasledie1 = temp[0];
                        nasledie2 = temp[1];
                    }
                    else
                    {
                        nasledie = raschet(operation.SelectedIndex, Convert.ToInt32(kolich.Text));
                      //  label2.Content = "Количество пар перчаток для операции " + operation.SelectedItem + " = " + raschet(operation.SelectedIndex, Convert.ToInt32(kolich.Text));
                    }
                }

            }
            catch { MessageBox.Show("Выберите операцию и введите их количество", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning); }
            // labe = label2.Content.ToString();
            try
            {
                formFill();
                MessageBox.Show("Отчет сформирован", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                System.Diagnostics.Process.Start("pdfTables.pdf");
            }
            catch {
                MessageBox.Show("Необходимо закрыть предыдущий отчет", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
        private static void formFill()
        {

            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(doc, new FileStream("pdfTables.pdf", FileMode.Create));
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont("arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            Paragraph header = new Paragraph("Главному врачу  КГБУЗ ККБ\n\nКорчагину Е.Е. от\n\n_______________________\n\n_______________________\n\n_______________________\n\n\n\n\n\n", font);
            header.Alignment = Element.ALIGN_RIGHT;
            doc.Add(new Paragraph(header));
            Paragraph center = new Paragraph("Заявление\n\n", font);
            center.Alignment = Element.ALIGN_CENTER;
            doc.Add(center);
            Paragraph tender = new Paragraph("Прошу, провести тендер на закупку перчаток для отделения «" + nameofForm + "»:\n\n\n", font);
            tender.Alignment = Element.ALIGN_CENTER;
            doc.Add(tender);
            float[] widths = { 1, 9, 2, 2 };
            PdfPTable table = new PdfPTable(widths);
            table.AddCell(new PdfPCell(new Phrase("№", font)));
            table.AddCell(new PdfPCell(new Phrase("Название перчаток", font)));
            table.AddCell(new PdfPCell(new Phrase("Цена, пара", font)));
            table.AddCell(new PdfPCell(new Phrase("Кол-во", font)));
            if (check == 5 && flag == true)
            {
                var temp = perch[check].Split('#');
                var temp1 = price[check].Split(' ');
                table.AddCell("1");
                table.AddCell(new PdfPCell(new Phrase(temp[1], font)));
                table.AddCell(temp1[1]);
                table.AddCell(nasledie1.ToString());
                table.AddCell("2");
                table.AddCell(new PdfPCell(new Phrase(temp[0], font)));
                table.AddCell(temp1[0]);
                table.AddCell(nasledie2.ToString());
                PdfPCell cell = new PdfPCell(new Phrase("Итого:", font));
                cell.Colspan=2;
                double result = 0.0;
                for (int i = 0; i < temp1.Length; i++) {
                    if (i == 0) {
                        result = Convert.ToDouble(temp1[1]) *Convert.ToDouble(nasledie1); 
                    }
                    if (i == 1) {
                        result += Convert.ToDouble(temp1[0]) * Convert.ToDouble(nasledie2);
                    }
                }
                PdfPCell cell1 = new PdfPCell(new Phrase(result.ToString() + " руб.", font));
                cell1.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(cell1);
            }
            else if (check == 5 && flag == false)
            {
                var temp = perch[check].Split('#');
                table.AddCell("1");
                table.AddCell(new PdfPCell(new Phrase(temp[1], font)));
                table.AddCell(price[check].Split(' ')[1]);
                table.AddCell(nasledie.ToString());
                PdfPCell cell = new PdfPCell(new Phrase("Итого:", font));
                cell.Colspan = 2;
                double result = 0.0;
                result = Convert.ToDouble(price[check].Split(' ')[1]) * Convert.ToDouble(nasledie.ToString());
                PdfPCell cell1 = new PdfPCell(new Phrase(result.ToString()+" руб.", font));
                cell1.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(cell1);
            }
            else
            {
                table.AddCell("1");
                table.AddCell(new PdfPCell(new Phrase(perch[check], font)));
                table.AddCell(price[check]);
                table.AddCell(nasledie.ToString());
                PdfPCell cell = new PdfPCell(new Phrase("Итого:", font));
                cell.Colspan = 2;
                double result = 0.0;
                result = Convert.ToDouble(price[check]) * Convert.ToDouble(nasledie);
                PdfPCell cell1 = new PdfPCell(new Phrase(result.ToString() + " руб.", font));
                cell1.Colspan = 2;
                table.AddCell(cell);
                table.AddCell(cell1);
            }
            doc.Add(table);
            Paragraph niz = new Paragraph("\n\n\n\n\n\n\n\n\n\n\n\n\n\n«_____»  __________________ 20____г.    ______________          _______________________.    ", font);
            niz.Alignment = Element.ALIGN_LEFT;
            doc.Add(niz);
            Paragraph nizhe = new Paragraph("                                                                            (подпись)                    (расшифровка подписи)", font);
            nizhe.Alignment = Element.ALIGN_LEFT;
            doc.Add(nizhe);
            doc.Close();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
