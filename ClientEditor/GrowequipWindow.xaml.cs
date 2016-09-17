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
    /// Interaction logic for GrowequipWindow.xaml
    /// </summary>
    public partial class GrowequipWindow : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }
        public GrowequipWindow()
        {
            InitializeComponent();
            Settings.EditorID = 10;
            this.Load = false;
            this.SavedChanges = true;
        }

        private void loadMenuItem_Click(object sender, RoutedEventArgs e)
        {
           this.Load = LoadFile.LoadFunction(growequipListBox, versionTextBlock);
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.Save(this.Load);
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void growequipListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Load)
            {
                try
                {
                    int index = growequipListBox.SelectedIndex;
                    unknownTextBox1.Text = Data<Growequip>.GrowEquipList[index].Unknown1;
                    unknownTextBox2.Text = Data<Growequip>.GrowEquipList[index].Unknown2;
                    unknownTextBox3.Text = Data<Growequip>.GrowEquipList[index].Unknown3;
                    unknownTextBox4.Text = Data<Growequip>.GrowEquipList[index].Unknown4;
                    unknownTextBox5.Text = Data<Growequip>.GrowEquipList[index].Unknown5;
                    unknownTextBox6.Text = Data<Growequip>.GrowEquipList[index].Unknown6;
                    unknownTextBox7.Text = Data<Growequip>.GrowEquipList[index].Unknown7;
                    unknownTextBox8.Text = Data<Growequip>.GrowEquipList[index].Unknown8;
                    unknownTextBox9.Text = Data<Growequip>.GrowEquipList[index].Unknown9;
                    unknownTextBox10.Text = Data<Growequip>.GrowEquipList[index].Unknown10;
                    unknownTextBox11.Text = Data<Growequip>.GrowEquipList[index].Unknown11;
                    unknownTextBox12.Text = Data<Growequip>.GrowEquipList[index].Unknown12;
                    unknownTextBox13.Text = Data<Growequip>.GrowEquipList[index].Unknown13;
                    unknownTextBox14.Text = Data<Growequip>.GrowEquipList[index].Unknown14;
                    unknownTextBox15.Text = Data<Growequip>.GrowEquipList[index].Unknown15;
                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            {
                Data<Growequip>.Add(growequipListBox);
            }
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            {
                Data<Growequip>.Remove(growequipListBox);
            }
        }

        private void unknown01TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown1 = unknownTextBox1.Text;
            }
        }

        private void unknown02TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown1 = unknownTextBox1.Text;
            }
        }

        private void unknownTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown1 = unknownTextBox1.Text;
            }
        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown2 = unknownTextBox2.Text;
            }
        }

        private void unknownTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown3 = unknownTextBox3.Text;
            }
        }

        private void unknownTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown4 = unknownTextBox4.Text;
            }
        }

        private void unknownTextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown5 = unknownTextBox5.Text;
            }
        }

        private void unknownTextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown6 = unknownTextBox6.Text;
            }
        }

        private void unknownTextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown7 = unknownTextBox7.Text;
            }
        }

        private void unknownTextBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown8 = unknownTextBox8.Text;
            }
        }

        private void unknownTextBox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown9 = unknownTextBox9.Text;
            }
        }

        private void unknownTextBox10_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown10 = unknownTextBox10.Text;
            }
        }

        private void unknownTextBox11_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown11 = unknownTextBox11.Text;
            }
        }

        private void unknownTextBox12_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown12 = unknownTextBox12.Text;
            }
        }

        private void unknownTextBox13_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown13 = unknownTextBox13.Text;
            }
        }

        private void unknownTextBox14_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown14 = unknownTextBox14.Text;
            }
        }

        private void unknownTextBox15_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = growequipListBox.SelectedIndex;
                Data<Growequip>.GrowEquipList[index].Unknown15 = unknownTextBox15.Text;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Quit(this.SavedChanges, this, this.Load, e);
        }
    }
}
