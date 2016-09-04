using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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

        public static bool ReadFile(int aos, int editor)
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
                            Data.ClassBaseList.Add(new ClassBase(objectArray[0],
                                                                 objectArray[1],
                                                                 objectArray[2],
                                                                 objectArray[3],
                                                                 objectArray[4],
                                                                 objectArray[5],
                                                                 objectArray[6],
                                                                 objectArray[7]));
                            break;
                        default: throw new EditorNotFoundException("Editor not Found");
                    }
                }
                MessageBox.Show("Finished reading file.");
                return true;
            }
            catch (EditorNotFoundException ex)
            {
                throw ex;
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please select a file to load.");
            }
            catch (IOException)
            {
                MessageBox.Show("Something went wrong with reading the file..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occured");
                Console.WriteLine(ex.StackTrace);
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
            return false;
        }

        public static bool LoadFunction(ListBox l, TextBlock t)
        {
            bool value = false;
            try
            {
                LoadFile f = new LoadFile();
                value = ReadFile(5, Settings.EditorID); // result komen
                switch(Settings.EditorID)
                {
                    case 1:
                        for (int i = 1; i <= Data.CharColorList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        break;
                    case 2:
                        for (int i = 1; i <= Data.ClassBaseList.Count; i++)
                        {
                            l.Items.Add(i);
                        }
                        break;
                }
                
                t.Text = Settings.Version;
                return value;
            }
            catch (EditorNotFoundException)
            {
                MessageBox.Show("Editor not supported, Application will close.");
                Environment.Exit(1);
            }
            return value;
        }




    }
}
