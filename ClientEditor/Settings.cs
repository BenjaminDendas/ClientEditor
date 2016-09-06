using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientEditor
{
    public static class Settings
    {
        public static int EditorID { get; set; }
        public static string File { get; set; }
        public static string CharColorVersion { get; set; }
        public static string ClassBaseVersion { get; set; }
        public static string DyingItemsVersion { get; set; }
        public static string AdventureVersion { get; set; }

        public static void Quit(Window w)
        {
            var message = MessageBox.Show("Are you sure that you want to go back to the main screen?", "Return to main", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (message == MessageBoxResult.Yes)
            {
                w.Hide();
                BootWindow window = new BootWindow();
                window.Show();
            }
            else { }
        }
    }
}
