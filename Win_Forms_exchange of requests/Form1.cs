using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Win_Forms_exchange_of_requests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://www.professorweb.ru");
            StreamReader sr = new StreamReader(stream);
            string newLine;
            while ((newLine = sr.ReadLine()) != null)
                textBox1.Text += newLine;

            stream.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
