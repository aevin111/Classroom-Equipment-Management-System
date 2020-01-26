﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public class SingletonReadfile //Singleton
    {
        private static SingletonReadfile sr = null;
        int id = 0;
        bool endOfFile = false;
        public List<string> labs = new List<string>();

        public static SingletonReadfile Initialize()
        {
            if (null == sr)
            {
                sr = new SingletonReadfile();
            }

            return sr;
        }

        public void ReadFileLabs()
        {
            int fileID = 0;
            bool endOfFile = false;

            while (endOfFile == false)
            {
                //Check if File exists
                if (File.Exists(fileID.ToString() + ".txt"))
                {
                    //Loop that itereates for as long as the file exists
                    while (File.Exists(fileID.ToString() + ".txt"))
                    {
                        //Reading the file and populating the list
                        using (StreamReader reader = new StreamReader(fileID.ToString() + ".txt"))
                        {
                            //Populate list
                            string[] tempStore = { reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine() };
                            string[] realStore = {tempStore[0], tempStore[3]};
                            ListViewItem lister = new ListViewItem(realStore);
                            Form4.chain.ListView1.Items.Add(lister);
                            reader.Close();

                        }

                        //Move to next file
                        fileID++;
                    }
                }

                //Nothing to see here *laughs in money*
                else
                {
                    if (fileID < 9999) //See, here's my problem: I use numbers to record equipments. 
                    {                  //If the numbers aren't in order, the program will not read the other files.
                        fileID++;      //The cause: Deleting files (ruins the order). So, I had to set a limit of 9999 so it doesn't iterate forever.
                    }

                    else
                    {
                        endOfFile = true;
                    }
                }
            }
        }

        public void ReadFileEquip()
        {
            int fileID = 0;
            bool endOfFile = false;

            while (endOfFile == false)
            {
                //Check if File exists
                if (File.Exists(fileID.ToString() + ".txt"))
                {
                    //Loop that itereates for as long as the file exists
                    while (File.Exists(fileID.ToString() + ".txt"))
                    {
                        //Reading the file and populating the list
                        using (StreamReader reader = new StreamReader(fileID.ToString() + ".txt"))
                        {
                            //Populate list
                            string[] tempStore = { reader.ReadLine(), reader.ReadLine(), reader.ReadLine(), reader.ReadLine() };
                            string[] realStore = { tempStore[0], tempStore[1] };
                            ListViewItem lister = new ListViewItem(realStore);
                            Form5.chain.ListView1.Items.Add(lister);
                            reader.Close();

                        }

                        //Move to next file
                        fileID++;
                    }
                }

                //Nothing to see here *laughs in money*
                else
                {
                    if (fileID < 9999) //See, here's my problem: I use numbers to record equipments. 
                    {                  //If the numbers aren't in order, the program will not read the other files.
                        fileID++;      //The cause: Deleting files (ruins the order). So, I had to set a limit of 9999 so it doesn't iterate forever.
                    }

                    else
                    {
                        endOfFile = true;
                    }
                }
            }
        }
    }
}
