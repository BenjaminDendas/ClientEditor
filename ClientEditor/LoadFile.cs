using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientEditor
{
    public class LoadFile
    {
        public LoadFile()
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "ini Files (.ini)|*.ini|All Files (*.*)|*.*";
            filedialog.FilterIndex = 1;
            if(filedialog.ShowDialog() == true)
            {
                Settings.File = filedialog.FileName;
            }
   
        }

        public List<CharColor> ReadFile(int aos, int editor)
        {
            List<CharColor> charColorList = new List<CharColor>();
            FileStream fs = null;
            StreamReader reader = null;
            try
            {
                fs = new FileStream(Settings.File, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fs,Encoding.GetEncoding(950));
                string line = "";
                string[] objectArray = new string[aos];

                line = reader.ReadLine();
                Settings.Version = line;
                

                for (int i = 0; i < File.ReadAllLines(Settings.File).Length-1; i++)
                {
                    line = reader.ReadLine();
                    objectArray = line.Split('|');
                    switch (editor)
                    {
                        case 1:
                            charColorList.Add(new CharColor(int.Parse(objectArray[0]), objectArray[1], int.Parse(objectArray[2]), int.Parse(objectArray[3]), int.Parse(objectArray[4])));
                            break;
                        default: throw new EditorNotFoundException("Editor not Found");
                    }
                }
            }
            catch(EditorNotFoundException ex)
            {
                throw ex;
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
                if(reader != null)
                {
                    reader.Close();
                }
            }
           
            
            return charColorList;

        }
        // debug method
      public void CheckChars()
        {
            FileStream fs = new FileStream(@"D:\INI-EditorV4\client\C_CharColor.ini", FileMode.Open);
            StreamReader reader = new StreamReader(fs);
            string line = reader.ReadLine();
            int counter;
            while (line != null)
            {
                counter = 0;
                foreach (char c in line)
                {
                    if (c == '|')
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
                line = reader.ReadLine();
            }

            fs.Close();
            reader.Close();
        }
    }
}
