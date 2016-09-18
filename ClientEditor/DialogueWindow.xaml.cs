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
    /// Interaction logic for DialogueWindow.xaml
    /// </summary>
    public partial class DialogueWindow : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }
        public DialogueWindow()
        {
            InitializeComponent();
            this.Load = false;
            this.SavedChanges = true;
            Settings.EditorID = 11;
        }

        private void loadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Load = LoadFile.LoadFunction(dialogListBox, versionTextBlock);
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.Save(this.Load);
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void dialogListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Load)
            {
                try
                {
                    int index = dialogListBox.SelectedIndex;
                    unknownTextBox1.Text = Data<Dialogue>.DialogList[index].Unknown1;
                    unknownTextBox2.Text = Data<Dialogue>.DialogList[index].Unknown2;
                }
                catch(ArgumentOutOfRangeException)
                {

                }
            }
        }

        private void unknownTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = dialogListBox.SelectedIndex;
                Data<Dialogue>.DialogList[index].Unknown1 = unknownTextBox1.Text;
            }
        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                int index = dialogListBox.SelectedIndex;
                Data<Dialogue>.DialogList[index].Unknown2 = unknownTextBox2.Text;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Quit(this.SavedChanges, this, this.Load, e);
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            Data<Dialogue>.Add(dialogListBox);
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Load)
                Data<Dialogue>.Remove(dialogListBox);
        }
    }
}
