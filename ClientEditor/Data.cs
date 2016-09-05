using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ClientEditor
{
    public class Data
    {

        public static List<CharColor> CharColorList { get; set; }
        public static List<ClassBase> ClassBaseList { get; set; }
        public static List<DyingItems> DyingItemsList { get; set; }

        public static void Flush(ListBox l, List<CharColor> list)
        {
            list.Clear();
            l.Items.Clear();
            l.Items.Refresh();
        }
        public static void Flush(ListBox l, List<ClassBase> list)
        {
            list.Clear();
            l.Items.Clear();
            l.Items.Refresh();
        }
        public static void Flush(ListBox l, List<DyingItems> list)
        {
            list.Clear();
            l.Items.Clear();
            l.Items.Refresh();
        }


        public static void Remove(ListBox l)
        {
            
            try
            {
                int selected = l.SelectedIndex;
                Console.WriteLine(selected);
                switch (Settings.EditorID)
                {
                    case 1: Data.CharColorList.RemoveAt(selected);
                        break;
                    case 2: Data.ClassBaseList.RemoveAt(selected);
                        break;
                    case 3: Data.DyingItemsList.RemoveAt(selected);
                        break;
                }
                
                l.Items.RemoveAt(selected);
                l.SelectedIndex = 0;
                l.ScrollIntoView(l.Items.GetItemAt(0));
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("invalid Operation");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void Add(ListBox l)
        {
            try
            {
                l.Items.Add(l.Items.Count + 1);
                switch (Settings.EditorID)
                {
                    case 1:
                        Data.CharColorList.Add(new CharColor(0000, "", 0000, 0000, 0000));
                        break;
                    case 2:
                        Data.ClassBaseList.Add(new ClassBase("0000", "0.0", "0.0", "0.0", "0.0", "0.0", "0.0",""));
                        break;
                    case 3:
                        Data.DyingItemsList.Add(new DyingItems(0000, 0000, 0000, 0000, 0000, 0000, 0000, 
                                                               0000, 0000, 0000, 0000, 0000, 
                                                               0000, 0000, 0000, 0000, 0000, 0000, 0000, 
                                                               0000, 0000, 0000, 0000, 0000, 0000, 0000));
                        break;
                }
                l.SelectedIndex = 0;
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("Something went wrong.");
            }
            
        }



    }
}
