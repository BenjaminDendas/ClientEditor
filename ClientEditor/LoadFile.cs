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

        public void ReadFile(int aos, int editor)
        {
            switch(editor)
            {
                case 1: Data.CharColorList = new List<CharColor>();
                    break;
                case 2: Data.ClassBaseList = new List<ClassBase>();
                    break;
            }

            FileStream fs = null;
            StreamReader reader = null;
            try
            {
                fs = new FileStream(Settings.File, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(fs, Encoding.GetEncoding(950));
                string line = "";
                string[] objectArray = new string[aos];

                line = reader.ReadLine();
                switch (editor)
                {
                    case 1:
                        Settings.Version = line;
                        break;
                    case 2:
                        Settings.ClassBaseVersion = line;
                        break;
                }


                for (int i = 0; i < File.ReadAllLines(Settings.File).Length - 1; i++)
                {
                    line = reader.ReadLine();
                    objectArray = line.Split('|');
                    switch (editor)
                    {
                        case 1:
                            Data.CharColorList.Add(new CharColor(int.Parse(objectArray[0]), objectArray[1], int.Parse(objectArray[2]), int.Parse(objectArray[3]), int.Parse(objectArray[4])));
                            break;
                        case 2:
                            Data.ClassBaseList.Add(new ClassBase(int.Parse(objectArray[0]), double.Parse(objectArray[1]), double.Parse(objectArray[2]), double.Parse(objectArray[3]), double.Parse(objectArray[4]), double.Parse(objectArray[5]), double.Parse(objectArray[6])));
                            break;
                        default: throw new EditorNotFoundException("Editor not Found");
                    }
                }
            }
            catch (EditorNotFoundException ex)
            {
                throw ex;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please select a file to load.");
            }
            catch (IOException)
            {
                MessageBox.Show("Something went wrong with reading the file..");
            }
            catch (Exception)
            {
                MessageBox.Show("An exception occured");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }     
    }
}
