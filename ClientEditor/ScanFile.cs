using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientEditor
{
    public class ScanFile
    {
        public static void CheckChars(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
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
