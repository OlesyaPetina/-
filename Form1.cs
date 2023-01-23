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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] files;
            files = System.IO.Directory.GetFiles(@"..\Debug", "*txt");
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Substring(9, files[i].Length - 13);
                listBox1.Items.Add(files[i]);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.lBox = listBox1;
            form2.ShowDialog();
           
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.lBox = listBox1;
            form3.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selPath;
            selPath = listBox1.SelectedItem.ToString();
            string path = selPath + ".txt";
            if (File.Exists(path))
            {
                 File.Delete(path);
                listBox1.Items.Remove(selPath);
            }
            else
            {
                MessageBox.Show("Данная анкета не существует");
            }
        }
    }
}
