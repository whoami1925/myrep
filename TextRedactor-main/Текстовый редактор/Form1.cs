using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Текстовый_редактор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываемв файл содержимое textBox с кодировкой 1251
            }
            richTextBox.Clear();
        }

        private void слеваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            richTextBox.SelectAll(); //выделение всего текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox.DeselectAll(); //Отмена выделения

        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            richTextBox.SelectAll(); //выделение всего текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox.DeselectAll(); //Отмена выделения
        }

        private void справаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select(); // выравнивание только выделенного текста
            richTextBox.SelectAll(); //выделение всего текста
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox.DeselectAll(); //Отмена выделения
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void открытьТекстовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void сохранитьТекстовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываемв файл содержимое textBox с кодировкой 1251
            }
            richTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox.TextLength > 0)
            {
                richTextBox.Cut();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox.TextLength > 0)
            {
                richTextBox.Copy();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                richTextBox.Paste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox.Text = string.Empty;
        }
    }
}