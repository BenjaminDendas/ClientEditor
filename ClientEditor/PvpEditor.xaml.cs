using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClientEditor
{
    /// <summary>
    /// Interaction logic for PvpEditor.xaml
    /// </summary>
    public partial class PvpEditor : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }
        public PvpEditor()
        {
            InitializeComponent();
            this.Load = Load;
            this.SavedChanges = true;
        }

        private void LoadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            LoadFile.LoadFunction(pvpListBox, versionTextBlock);
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.Save(this.Load);
        }

        private void QuitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void unknownTextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void unknownTextBox8_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void unknownTextBox9_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void unknownTextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void unknownTextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void unknownTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void unknownTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void unknownTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
