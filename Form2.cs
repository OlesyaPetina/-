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

namespace Анкета
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public ListBox lBox;

        private void SaveText()
        {
            Queue<string> answers = new Queue<string>();
            answers.Enqueue("ФИО: " + textBox1.Text);
            answers.Enqueue("Дата рождения: " + dateTimePicker1.Text);
            answers.Enqueue("Место обучения: " + textBox4.Text);
            answers.Enqueue("Срок обучения: " + textBox5.Text);
            answers.Enqueue("Язык программирования: "+comboBox1.Text);
            answers.Enqueue("Мобильный телефон: " + textBox3.Text);
            answers.Enqueue("Опыт программирования: "+textBox2.Text);
            answers.Enqueue("Дата заполнения:");
            answers.Enqueue(DateTime.Now.ToString());
            string name = (textBox1.Text); 
            string path = name + ".txt";
            File.AppendAllLines(path, answers);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveText();
            lBox.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Checked = false;
        }
    }
}
