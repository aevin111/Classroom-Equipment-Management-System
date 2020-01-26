using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    class GenerateFile : IFileController
    {
        public void ControlFile()
        {
            int fileID = 0; //File ID
            string fileName = fileID.ToString() + ".txt"; //File Name

            // Check if file exists
            while (File.Exists(fileName))
            {
                fileID++;
                fileName = fileID.ToString() + ".txt";
            }

            // Create a new file and add information to list
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Form2.chain.Names);
                writer.WriteLine(Form2.chain.Date);
                writer.WriteLine(Form2.chain.Cond);
                writer.WriteLine(Form2.chain.Lab);
                string[] tempStore = { Form2.chain.Names, Form2.chain.Date, Form2.chain.Cond, Form2.chain.Lab };
                ListViewItem itr = new ListViewItem(tempStore);
                Form1.fr1.ListView1.Items.Add(itr);
                writer.Close();
            }
        }
    }
}
