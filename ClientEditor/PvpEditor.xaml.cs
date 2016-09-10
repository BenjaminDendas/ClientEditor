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
            this.Load = false;
            this.SavedChanges = true;
            Settings.EditorID = 5;
        }

        private void LoadMenuItem_Click(object sender, RoutedEventArgs e)
        {
           this.Load = LoadFile.LoadFunction(pvpListBox, versionTextBlock);
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
            try
            {
                if(this.Load)
                {
                    int selected = pvpListBox.SelectedIndex;
                    Data<Pvp>.PvpList[selected].Unknown7 = unknownTextBox7.Text;
                    this.SavedChanges = false;
                }
               
            }
            catch(FormatException)
            {
                Console.WriteLine("Something went wrong");
            }
            
        }

        private void unknownTextBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (this.Load)
                {
                    int selected = pvpListBox.SelectedIndex;
                    Data<Pvp>.PvpList[selected].Unknown8 = unknownTextBox8.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private void unknownTextBox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (this.Load)
                {
                    int selected = pvpListBox.SelectedIndex;
                    Data<Pvp>.PvpList[selected].Unknown9 = unknownTextBox9.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private void unknownTextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (this.Load)
                {
                    int selected = pvpListBox.SelectedIndex;
                    Data<Pvp>.PvpList[selected].Unknown6 = unknownTextBox6.Text;
                    this.SavedChanges = false;
                }
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private void unknownTextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if(this.Load)
                {
                    int selected = pvpListBox.SelectedIndex;
                    Data<Pvp>.PvpList[selected].Unknown5 = unknownTextBox5.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private void unknownTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (this.Load)
                {
                    int selected = pvpListBox.SelectedIndex;
                    Data<Pvp>.PvpList[selected].Unknown4 = unknownTextBox4.Text;
                    this.SavedChanges = false;
                }
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private void unknownTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (this.Load)
                {
                    int selected = pvpListBox.SelectedIndex;
                    Data<Pvp>.PvpList[selected].Unknown3 = unknownTextBox3.Text;
                    this.SavedChanges = false;
                }
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (this.Load)
                {
                    int selected = pvpListBox.SelectedIndex;
                    Data<Pvp>.PvpList[selected].Unknown2 = unknownTextBox2.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private void unknownTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (this.Load)
                {
                    int selected = pvpListBox.SelectedIndex;
                    Data<Pvp>.PvpList[selected].Unknown1 = unknownTextBox1.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong");
            }
        }

        private void pvpListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int selected = pvpListBox.SelectedIndex;
                unknownTextBox1.Text = Data<Pvp>.PvpList[selected].Unknown1;
                unknownTextBox2.Text = Data<Pvp>.PvpList[selected].Unknown2;  
                unknownTextBox3.Text = Data<Pvp>.PvpList[selected].Unknown3;
                unknownTextBox4.Text = Data<Pvp>.PvpList[selected].Unknown4;
                unknownTextBox5.Text = Data<Pvp>.PvpList[selected].Unknown5;
                unknownTextBox6.Text = Data<Pvp>.PvpList[selected].Unknown6;
                unknownTextBox7.Text = Data<Pvp>.PvpList[selected].Unknown7;
                unknownTextBox8.Text = Data<Pvp>.PvpList[selected].Unknown8;
                unknownTextBox9.Text = Data<Pvp>.PvpList[selected].Unknown9;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
           
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<Pvp>.Add(pvpListBox);
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<Pvp>.Remove(pvpListBox);
        }
    }
}
