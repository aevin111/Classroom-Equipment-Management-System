using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form5 : Form
    {
        public static Form5 chain;

        public Form5()
        {
            InitializeComponent();
            chain = this;
            SingletonReadfile sl = SingletonReadfile.Initialize();
            sl.ReadFileEquip();
        }

        private void ms_gotoMain_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void ms_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
