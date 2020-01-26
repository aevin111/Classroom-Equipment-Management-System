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
    public partial class Form3 : Form
    {
        public static Form3 chain; //For access
        IFileController load; //Load existing file
        IFileController save; //Save edited file

        public Form3()
        {
            InitializeComponent();
            load = new EditLoadFiles();
            chain = this;
            load.ControlFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save = new EditFileText();
            save.ControlFile();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
