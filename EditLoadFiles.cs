using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication7
{
    public class EditLoadFiles : IFileController
    {
        public static int index;

        public void ControlFile()
        {
            foreach (ListViewItem itemID in Form1.fr1.ListView1.SelectedItems) //Get selected index
            {
                index = Convert.ToInt32(Form1.fr1.ListView1.Items.IndexOf(itemID));

                if (File.Exists(Convert.ToInt32(Form1.fr1.ListView1.Items.IndexOf(itemID)).ToString() + ".txt")) //Load file using index ID
                {
                    using (StreamReader reader = new StreamReader(Convert.ToInt32(Form1.fr1.ListView1.Items.IndexOf(itemID)).ToString() + ".txt")) //streamreader: Load file
                    {
                        //Get text from file
                        Form3.chain.TextBox1.Text = reader.ReadLine();
                        //Parse to date
                        Form3.chain.DateTimePicker1.Value = DateTime.Parse(reader.ReadLine());
                        Form3.chain.ComboBox1.Text = reader.ReadLine();
                        Form3.chain.TextBox2.Text = reader.ReadLine();
                        reader.Close();
                    }
                }
            }
        }
    }
}
