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
    /// Interaction logic for FightEditor.xaml
    /// </summary>
    public partial class FightEditor : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }

        public FightEditor()
        {
            InitializeComponent();
            this.Load = false;
            this.SavedChanges = true;
            Settings.EditorID = 6;
        }

        private void unknownTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown01 = unknownTextBox1.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown02 = unknownTextBox2.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown03 = unknownTextBox3.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown04 = unknownTextBox4.Text;
                this.SavedChanges = false;
            }
           
        }

        private void unknownTextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown05 = unknownTextBox5.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown06 = unknownTextBox6.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown07 = unknownTextBox7.Text;
                this.SavedChanges = false;
            }
           
        }

        private void unknownTextBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown08 = unknownTextBox8.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown09 = unknownTextBox9.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox10_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown10 = unknownTextBox10.Text;
                this.SavedChanges = false;
            }
           
        }

        private void unknownTextBox11_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown11 = unknownTextBox11.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox12_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown12 = unknownTextBox12.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox13_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown13 = unknownTextBox13.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox14_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown14 = unknownTextBox14.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox15_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown15 = unknownTextBox15.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox16_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown16 = unknownTextBox16.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox17_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown17 = unknownTextBox17.Text;
                this.SavedChanges = false;
            }
           
        }

        private void unknownTextBox18_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown18 = unknownTextBox18.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox19_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown19 = unknownTextBox19.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox20_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown20 = unknownTextBox20.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox21_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown21 = unknownTextBox21.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox22_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown22 = unknownTextBox22.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox23_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown23 = unknownTextBox23.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox24_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown24 = unknownTextBox24.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox25_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown25 = unknownTextBox25.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox26_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown26 = unknownTextBox26.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox27_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown27 = unknownTextBox27.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox28_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown28 = unknownTextBox28.Text;
                this.SavedChanges = false;
            }
            
        }

        private void unknownTextBox29_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int selected = fightListBox.SelectedIndex;
                Data<Fight>.FightList[selected].Unknown29 = unknownTextBox29.Text;
                this.SavedChanges = false;
            }
            
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<Fight>.Add(fightListBox);
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<Fight>.Remove(fightListBox);
        }

        private void loadMenuitem_Click(object sender, RoutedEventArgs e)
        {
            this.Load = LoadFile.LoadFunction(fightListBox, versionTextBlock);
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.Save(this.Load);
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void fightListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int selected = fightListBox.SelectedIndex;
                this.unknownTextBox1.Text = Data<Fight>.FightList[selected].Unknown01.ToString();
                this.unknownTextBox2.Text = Data<Fight>.FightList[selected].Unknown02.ToString();
                this.unknownTextBox3.Text = Data<Fight>.FightList[selected].Unknown03.ToString();
                this.unknownTextBox4.Text = Data<Fight>.FightList[selected].Unknown04.ToString();
                this.unknownTextBox5.Text = Data<Fight>.FightList[selected].Unknown05.ToString();
                this.unknownTextBox6.Text = Data<Fight>.FightList[selected].Unknown06.ToString();
                this.unknownTextBox7.Text = Data<Fight>.FightList[selected].Unknown07.ToString();
                this.unknownTextBox8.Text = Data<Fight>.FightList[selected].Unknown08.ToString();
                this.unknownTextBox9.Text = Data<Fight>.FightList[selected].Unknown09.ToString();
                this.unknownTextBox10.Text = Data<Fight>.FightList[selected].Unknown10.ToString();

                this.unknownTextBox11.Text = Data<Fight>.FightList[selected].Unknown11.ToString();
                this.unknownTextBox12.Text = Data<Fight>.FightList[selected].Unknown12.ToString();
                this.unknownTextBox13.Text = Data<Fight>.FightList[selected].Unknown13.ToString();
                this.unknownTextBox14.Text = Data<Fight>.FightList[selected].Unknown14.ToString();
                this.unknownTextBox15.Text = Data<Fight>.FightList[selected].Unknown15.ToString();
                this.unknownTextBox16.Text = Data<Fight>.FightList[selected].Unknown16.ToString();
                this.unknownTextBox17.Text = Data<Fight>.FightList[selected].Unknown17.ToString();
                this.unknownTextBox18.Text = Data<Fight>.FightList[selected].Unknown18.ToString();
                this.unknownTextBox19.Text = Data<Fight>.FightList[selected].Unknown19.ToString();
                this.unknownTextBox20.Text = Data<Fight>.FightList[selected].Unknown20.ToString();

                this.unknownTextBox21.Text = Data<Fight>.FightList[selected].Unknown21.ToString();
                this.unknownTextBox22.Text = Data<Fight>.FightList[selected].Unknown22.ToString();
                this.unknownTextBox23.Text = Data<Fight>.FightList[selected].Unknown23.ToString();
                this.unknownTextBox24.Text = Data<Fight>.FightList[selected].Unknown24.ToString();
                this.unknownTextBox25.Text = Data<Fight>.FightList[selected].Unknown25.ToString();
                this.unknownTextBox26.Text = Data<Fight>.FightList[selected].Unknown26.ToString();
                this.unknownTextBox27.Text = Data<Fight>.FightList[selected].Unknown27.ToString();
                this.unknownTextBox28.Text = Data<Fight>.FightList[selected].Unknown28.ToString();
                this.unknownTextBox29.Text = Data<Fight>.FightList[selected].Unknown29.ToString();


            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
