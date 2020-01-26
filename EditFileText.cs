using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication7
{
    public class EditFileText : IFileController
    {
        public void ControlFile()
        {
            int fileID = EditLoadFiles.index;
            string fileName = fileID.ToString() + ".txt"; //File Name

            // Create a new file and add information to list
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Form3.chain.TextBox1.Text);
                writer.WriteLine(Form3.chain.DateTimePicker1.Text);
                writer.WriteLine(Form3.chain.ComboBox1.Text);
                writer.WriteLine(Form3.chain.TextBox2.Text);

                foreach (ListViewItem itemID in Form1.fr1.ListView1.Items)
                {
                    Form1.fr1.ListView1.Items.Remove(itemID);
                }

                writer.Close();
            }
        }
    }
}
