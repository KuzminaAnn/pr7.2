using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr7._2
{
    /// <summary>
    /// Логика взаимодействия для PageStart.xaml
    /// </summary>
    public partial class PageStart : Page
    {
        private const string EnUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string EnLower = "abcdefghijklmnopqrstuvwxyz";
        private const string RuUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const string RuLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public PageStart()
        {
            InitializeComponent();
        }
        private void rezul_Click(object sender, RoutedEventArgs e)
        {
            string ccipher = cipher.Text;
            string ttext = text.Text;
            int.TryParse(shift.Text, out int sshift);
            
            if (string.IsNullOrEmpty(text.Text))
            {
                DecryptCaesar(ccipher, sshift);
            }
            if (string.IsNullOrEmpty(cipher.Text))
            {
                EncryptCaesar(ttext, sshift);
            }
        }
        public bool EncryptCaesar(string ttext, int sshift)
        {
            var result = new StringBuilder(ttext.Length);

            foreach (char c in ttext)
            {
                if (TryGetAlphabet(c, out string alphabet, out int index))
                {
                    int len = alphabet.Length;
                    // Нормализация сдвига: корректно обрабатывает отрицательные и большие значения
                    int normShift = ((sshift % len) + len) % len;
                    int newIndex = (index + normShift) % len;
                    result.Append(alphabet[newIndex]);
                }
                else
                {
                    // Пробелы, цифры, знаки препинания и другие символы остаются без изменений
                    result.Append(c);
                }
            }
            answer.Text = Convert.ToString(result);
            return true;
        }
        public bool DecryptCaesar(string ccipher, int sshift)
        {
            return EncryptCaesar(ccipher, -sshift);
        }
        private static bool TryGetAlphabet(char c, out string alphabet, out int index)
        {
            index = EnUpper.IndexOf(c);
            if (index >= 0) { alphabet = EnUpper; return true; }

            index = EnLower.IndexOf(c);
            if (index >= 0) { alphabet = EnLower; return true; }

            index = RuUpper.IndexOf(c);
            if (index >= 0) { alphabet = RuUpper; return true; }

            index = RuLower.IndexOf(c);
            if (index >= 0) { alphabet = RuLower; return true; }

            alphabet = null;
            index = -1;
            return false;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            cipher.Text = String.Empty;
            text.Text = String.Empty;
            shift.Text = String.Empty;
            answer.Text = String.Empty;
        }
    }
}
