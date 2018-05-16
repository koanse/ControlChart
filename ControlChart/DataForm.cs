using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ControlChart
{
    public partial class DataForm : Form
    {
        public DataForm(string file)
        {
            InitializeComponent();
            try
            {
                FileStream fs = new FileStream(file, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.Unicode);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                Text += file;
            }
            catch { }
        }
    }
}