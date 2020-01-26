using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication7
{
    public class DeleteFile : IFileController
    {
        public void ControlFile()
        {
            foreach (ListViewItem itemID in Form1.fr1.ListView1.SelectedItems)
            {
                if (File.Exists(Convert.ToInt32(Form1.fr1.ListView1.Items.IndexOf(itemID)).ToString() + ".txt"))
                {
                    int id = Convert.ToInt32(Form1.fr1.ListView1.Items.IndexOf(itemID));
                    File.Delete(id.ToString() + ".txt");
                    id++;

                    while (File.Exists(id.ToString() + ".txt"))
                    {
                        int n_id = id - 1;
                        File.Move(id.ToString() + ".txt", n_id.ToString() +".txt");
                        id++;
                    }
                }

                Form1.fr1.ListView1.Items.Remove(itemID);
            }
        }
    }
}
