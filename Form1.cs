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

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Code code = new Code();
        public static string filein = "C:\\Users\\Денис\\Desktop\\in.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string str = code.StrCode(inputBox.Text);
            string logstr = "Было " + inputBox.Text + " стало " + str;
            logBox.Text += logstr + " \n";
            
            outputBox.Text = str;
            
            StreamWriter fin = new StreamWriter(filein, true);
            fin.WriteLine(logstr);
            fin.Close();
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string str = code.StrDecode(inputBox.Text);
            
            string logstr = "Было " + inputBox.Text + " стало " + str;
            logBox.Text += logstr + " \n";
            outputBox.Text = str;
            StreamWriter fin = new StreamWriter(filein, true);
            fin.WriteLine(logstr);
            fin.Close();
        }
    }
}
