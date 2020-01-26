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
    public partial class Form1 : Form
    {
        public static Form1 fr1; //I need to access Form1 to populate the list
        IFileController fileCheck; //Check if file exists
        IFileController deleteFile; //Delete the file

        public Form1()
        {
            InitializeComponent();
            fileCheck = new FileExistsCheck();
            fr1 = this;
            fileCheck.ControlFile();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Add new information
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            deleteFile = new DeleteFile();
            deleteFile.ControlFile();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void btn_EquipCon_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            IFileController fr = new FileExistsCheck();
            fr.ControlFile();
        }

        private void btn_LabRep_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
        }

    }
}
