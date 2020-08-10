using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Login2
{
    public partial class MainWindow : Window
    {
        List<string> h = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory() + "\\Logins.txt";
            string j = "";
            using (StreamReader sr = new StreamReader(path))
            {
                j = sr.ReadToEnd();
            }
            h.AddRange(j.Split('#'));
        }

        private void Aut_Click(object sender, RoutedEventArgs e)
        {
            int p = -1;
            for (int i = 0; i < h.Count; i++)
            {
                if (login.Text + "," + password.Text == h[i])
                {
                    p = i;
                }

            }
            if (p == -1)
            {
                MessageBox.Show("Неверно введен логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Otchet form = new Otchet(p);
                form.Show();
                this.Hide();
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
