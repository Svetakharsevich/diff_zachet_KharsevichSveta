using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> listOfString = new List<string>();
        List<string> listOf = new List<string>();
        string letter;
        string new_letter;
        Class1 l=new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            listBox1.Items.Clear();
            string path = "info.txt";
            try
            {
                string[] araay = l.z(path).Split('*');
                for(int i=0;i<araay.Length;i++)
                {
                    listBox1.Items.Add(araay[i]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось найти файл", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            listBox1.Items.Clear();
            letter = textBox1.Text;
            if (textBox1.Text == "") MessageBox.Show("Введите значение", "Ошибка");
            else
            {
                bool cheak = false;
                for (int i = 0; i < letter.Length; i++)
                {
                    if (Char.IsDigit(letter[i])) cheak = true;

                }
                if(cheak) { MessageBox.Show("Введите букву", "Ошибка"); listBox1.Items.Clear(); }
                string[] array = l.zp(letter).Split('*');
                for (int i = 0; i < array.Length; i++)
                {
                    listBox1.Items.Add(array[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new_letter = textBox2.Text;
            listBox1.Items.Clear();
            if (textBox2.Text == "") MessageBox.Show("Введите значения", "Ошибка");
            else
            {
                bool cheak = false;
                for (int i = 0; i < letter.Length; i++)
                {
                    if (Char.IsDigit(letter[i])) cheak = true;

                }
                if (cheak) { MessageBox.Show("Введите букву", "Ошибка"); listBox1.Items.Clear(); }
                else
                {
                    l.s(new_letter);
                    MessageBox.Show("Слово добавлено");
                }
            }
        }
    }
}
