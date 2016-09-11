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
        public static string PvpVersion { get; set; }
        public static string FightVersion { get; set; }
        public static string MageVersion { get; set; }
        public static string PartnerGrowVersion { get; set; }



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

        public static void Quit(bool SavedChanges,Window w,bool Load, System.ComponentModel.CancelEventArgs e)
        {
            var bericht = MessageBox.Show("Are you sure that you want to leave the editor?", "Quit?", MessageBoxButton.YesNo);
            if ((bericht == MessageBoxResult.Yes) && SavedChanges == true)
            {
                BootWindow win = new BootWindow();
                win.Show();
                w.Hide();
            }
            else
            {
                if (Load == true && (bericht == MessageBoxResult.Yes) && SavedChanges == false)
                {
                    var mess = MessageBox.Show("You have changes that are not saved, save?", "Save changes?", MessageBoxButton.YesNo);
                    if (mess == MessageBoxResult.Yes)
                    {
                        SaveFile.Save(Load);
                        BootWindow win = new BootWindow();
                        win.Show();
                        w.Hide();
                    }
                    else
                    {
                        BootWindow win = new BootWindow();
                        win.Show();
                        w.Hide();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }



    }
}
