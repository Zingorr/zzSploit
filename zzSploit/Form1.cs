using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cxapi;



namespace zzSploit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CoreFunctions.Inject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoreFunctions.KillRoblox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript(richTextBox1.Text);
        }
    }
}
