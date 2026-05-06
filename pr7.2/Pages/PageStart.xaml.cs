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
        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// </summary>
        public PageStart()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик нажатия кнопки для запуска шифрования или дешифрования. Определяет действие
        /// на основе того, какое поле ввода пусто: если пусто поле шифротекста — выполняется
        /// шифрование, если пусто поле исходного текста — выполняется дешифрование.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
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
        /// <summary>
        /// Шифрует исходный текст методом шифра Цезаря с указанным сдвигом. Результат выводится
        /// в элемент интерфейса answer. Поддерживает английский и русский алфавиты
        /// (верхний и нижний регистры).
        /// </summary>
        /// <param name="ttext">Исходный текст для шифрования.</param>
        /// <param name="sshift">Величина сдвига для шифрования.</param>
        /// <returns>Возвращает true, если операция выполнена успешно.</returns>
        public bool EncryptCaesar(string ttext, int sshift)
        {
            var result = new StringBuilder(ttext.Length);

            foreach (char c in ttext)
            {
                if (TryGetAlphabet(c, out string alphabet, out int index))
                {
                    int len = alphabet.Length;

                    int normShift = ((sshift % len) + len) % len;
                    int newIndex = (index + normShift) % len;
                    result.Append(alphabet[newIndex]);
                }
                else
                {
                    result.Append(c);
                }
            }
            answer.Text = Convert.ToString(result);
            return true;
        }
        /// <summary>
        /// Дешифрует текст, зашифрованный методом шифра Цезаря. Выполняется путем вызова
        /// метода шифрования с инвертированным (отрицательным) сдвигом.
        /// </summary>
        /// <param name="ccipher">Зашифрованный текст.</param>
        /// <param name="sshift">Величина сдвига, использованная при шифровании.</param>
        /// <returns>Возвращает true, если операция выполнена успешно.</returns>
        public bool DecryptCaesar(string ccipher, int sshift)
        {
            return EncryptCaesar(ccipher, -sshift);
        }
        /// <summary>
        /// Определяет, к какому алфавиту принадлежит символ, и возвращает этот алфавит
        /// вместе с индексом символа в нем.
        /// </summary>
        /// <param name="c">Символ для проверки.</param>
        /// <param name="alphabet">Если метод вернул true, содержит строку алфавита
        /// (англ/рус, верхний/нижний регистр), к которому относится символ.</param>
        /// <param name="index">Если метод вернул true, содержит индекс символа в найденном алфавите.</param>
        /// <returns>true, если символ найден в одном из поддерживаемых алфавитов; иначе false.</returns>
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
        /// <summary>
        /// Обработчик нажатия кнопки очистки. Очищает поля ввода исходного текста,
        /// шифротекста, сдвига и поле вывода результата.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            cipher.Text = String.Empty;
            text.Text = String.Empty;
            shift.Text = String.Empty;
            answer.Text = String.Empty;
        }
    }
}
