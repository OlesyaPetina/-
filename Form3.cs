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
    public partial class Form3 : Form
    {
        public ListBox lBox;
        public Form3()
        {
            InitializeComponent();

            
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            string path = lBox.SelectedItem.ToString();
            path += ".txt";
            StreamReader sr = new StreamReader(path, false);
            richTextBox1.AppendText(sr.ReadToEnd());
            sr.Close();
        }
    }
}
