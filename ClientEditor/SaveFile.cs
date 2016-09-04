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

        public static void Save(bool load)
        {
            if(load)
            {
                using (FileStream fs = new FileStream(Settings.File, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(fs, Encoding.GetEncoding(950)))
                    {
                        try
                        {
                            switch (Settings.EditorID)
                            {
                                case 1:
                                    writer.WriteLine(Settings.Version);
                                    foreach (CharColor col in Data.CharColorList)
                                    {
                                        string s = String.Format("{0}|{1}|{2}|{3}|{4}|", col.ID, col.Color, col.Unknown02, col.Unknown03, col.Unknown04);
                                        writer.WriteLine(s);
                                    }
                                    break;
                                case 2:
                                    writer.WriteLine(Settings.ClassBaseVersion);
                                    foreach (ClassBase cb in Data.ClassBaseList)
                                    {
                                        string s = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", cb.Unknown01, cb.Unknown02, cb.Unknown03, cb.Unknown04, cb.Unknown05, cb.Unknown06, cb.Unknown07, cb.Unknown08);
                                        writer.WriteLine(s);
                                    }
                                    break;
                            }

                            MessageBox.Show("File Succesfully saved.");
                        }
                        catch (IOException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    }
                }
            }
            
        }
    }
}
