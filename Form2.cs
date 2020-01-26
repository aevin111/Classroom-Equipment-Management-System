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
    public partial class Form2 : Form
    {
        public static Form2 chain; //For accessibility
        string name;
        string date;
        string cond;
        string lab;

        //Accessors and getters
        public string Names
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Cond
        {
            get
            {
                return cond;
            }

            set
            {
                cond = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Lab
        {
            get
            {
                return lab;
            }

            set
            {
                lab = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
            chain = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Obtain values from textbox
            name = textBox1.Text;
            date = dateTimePicker1.Text.ToString();
            cond = comboBox1.Text;
            lab = textBox2.Text;
            IFileController newFile = new GenerateFile();
            newFile.ControlFile();
            this.Close();
        }

    }
}
