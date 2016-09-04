using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientEditor
{
    public class SaveFile
    {

        public static void Save(List<CharColor> charColorList)
        {
            using (FileStream fs = new FileStream(Settings.File, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.GetEncoding(950)))
                {
                    try
                    {
                        writer.WriteLine(Settings.Version);
                        foreach (CharColor col in charColorList)
                        {
                            string s = String.Format("{0}|{1}|{2}|{3}|{4}|", col.ID, col.Color, col.Unknown02, col.Unknown03, col.Unknown04);
                            writer.WriteLine(s);
                        }
                        MessageBox.Show("File Succesfully saved.");
                    }
                    catch(IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }
        }
    }
}
