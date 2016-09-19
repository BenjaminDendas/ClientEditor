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
    /// Interaction logic for LevelWindow.xaml
    /// </summary>
    public partial class LevelWindow : Window
    {
        public bool SavedChanges { get; set; }
        public bool Load { get; set; }
        public LevelWindow()
        {
            InitializeComponent();
            Settings.EditorID = 12;
            this.Load = false;
            this.SavedChanges = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Quit(this.SavedChanges, this, this.Load, e);
        }

        private void loadMenuitem_Click(object sender, RoutedEventArgs e)
        {
            this.Load = LoadFile.LoadFunction(levelListBox, versionTextBlock);
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {

            SaveFile.Save(this.Load);

        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void unknownTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown1 = unknownTextBox1.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown2 = unknownTextBox2.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown3 = unknownTextBox3.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown4 = unknownTextBox4.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown5 = unknownTextBox5.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown6 = unknownTextBox6.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown7 = unknownTextBox7.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown8 = unknownTextBox8.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown9 = unknownTextBox9.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox10_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown10 = unknownTextBox10.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox11_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown11 = unknownTextBox11.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox12_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown12 = unknownTextBox12.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox13_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown13 = unknownTextBox13.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox14_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown14 = unknownTextBox14.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox15_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown15 = unknownTextBox15.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox16_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown16 = unknownTextBox16.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox17_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown17 = unknownTextBox17.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox18_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown18 = unknownTextBox18.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox19_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown19 = unknownTextBox19.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox20_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown20 = unknownTextBox20.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox21_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown21 = unknownTextBox21.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox22_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown22 = unknownTextBox22.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox23_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown23 = unknownTextBox23.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox24_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown24 = unknownTextBox24.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox25_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown25 = unknownTextBox25.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox26_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown26 = unknownTextBox26.Text;
                this.SavedChanges = false;
            }
        }

        private void levelListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (this.Load)
                {
                    int index = levelListBox.SelectedIndex;
                    unknownTextBox1.Text = Data<Level>.LevelList[index].Unknown1;
                    unknownTextBox2.Text = Data<Level>.LevelList[index].Unknown2;
                    unknownTextBox3.Text = Data<Level>.LevelList[index].Unknown3;
                    unknownTextBox4.Text = Data<Level>.LevelList[index].Unknown4;
                    unknownTextBox5.Text = Data<Level>.LevelList[index].Unknown5;
                    unknownTextBox6.Text = Data<Level>.LevelList[index].Unknown6;
                    unknownTextBox7.Text = Data<Level>.LevelList[index].Unknown7;
                    unknownTextBox8.Text = Data<Level>.LevelList[index].Unknown8;
                    unknownTextBox9.Text = Data<Level>.LevelList[index].Unknown9;
                    unknownTextBox10.Text = Data<Level>.LevelList[index].Unknown10;
                    unknownTextBox11.Text = Data<Level>.LevelList[index].Unknown11;
                    unknownTextBox12.Text = Data<Level>.LevelList[index].Unknown12;
                    unknownTextBox13.Text = Data<Level>.LevelList[index].Unknown13;
                    unknownTextBox14.Text = Data<Level>.LevelList[index].Unknown14;
                    unknownTextBox15.Text = Data<Level>.LevelList[index].Unknown15;
                    unknownTextBox16.Text = Data<Level>.LevelList[index].Unknown16;
                    unknownTextBox17.Text = Data<Level>.LevelList[index].Unknown17;
                    unknownTextBox18.Text = Data<Level>.LevelList[index].Unknown18;
                    unknownTextBox19.Text = Data<Level>.LevelList[index].Unknown19;
                    unknownTextBox20.Text = Data<Level>.LevelList[index].Unknown20;
                    unknownTextBox21.Text = Data<Level>.LevelList[index].Unknown21;
                    unknownTextBox22.Text = Data<Level>.LevelList[index].Unknown22;
                    unknownTextBox23.Text = Data<Level>.LevelList[index].Unknown23;
                    unknownTextBox24.Text = Data<Level>.LevelList[index].Unknown24;
                    unknownTextBox25.Text = Data<Level>.LevelList[index].Unknown25;
                    unknownTextBox26.Text = Data<Level>.LevelList[index].Unknown26;
                    unknownTextBox27.Text = Data<Level>.LevelList[index].Unknown27;
                    unknownTextBox28.Text = Data<Level>.LevelList[index].Unknown28;
                    unknownTextBox29.Text = Data<Level>.LevelList[index].Unknown29;
                    unknownTextBox30.Text = Data<Level>.LevelList[index].Unknown30;
                    unknownTextBox31.Text = Data<Level>.LevelList[index].Unknown31;
                    unknownTextBox32.Text = Data<Level>.LevelList[index].Unknown32;
                    unknownTextBox33.Text = Data<Level>.LevelList[index].Unknown33;
                    unknownTextBox34.Text = Data<Level>.LevelList[index].Unknown34;
                    unknownTextBox35.Text = Data<Level>.LevelList[index].Unknown35;
                    unknownTextBox36.Text = Data<Level>.LevelList[index].Unknown36;
                    unknownTextBox37.Text = Data<Level>.LevelList[index].Unknown37;
                    unknownTextBox38.Text = Data<Level>.LevelList[index].Unknown38;
                    unknownTextBox39.Text = Data<Level>.LevelList[index].Unknown39;
                    unknownTextBox40.Text = Data<Level>.LevelList[index].Unknown40;
                    unknownTextBox41.Text = Data<Level>.LevelList[index].Unknown41;
                    unknownTextBox42.Text = Data<Level>.LevelList[index].Unknown42;
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                
            }
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            Data<Level>.Add(levelListBox);
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            {
                Data<Level>.Remove(levelListBox);
            }
        }

        private void unknownTextBox27_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown27 = unknownTextBox27.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox28_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown28 = unknownTextBox28.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox29_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown29 = unknownTextBox29.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox30_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown30 = unknownTextBox30.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox31_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown31 = unknownTextBox31.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox32_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown32 = unknownTextBox32.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox33_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown33 = unknownTextBox33.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox34_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown34 = unknownTextBox34.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox35_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown35 = unknownTextBox35.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox36_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown36 = unknownTextBox36.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox37_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown37 = unknownTextBox37.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox38_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown38 = unknownTextBox38.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox39_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown39 = unknownTextBox39.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox40_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown40 = unknownTextBox40.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox41_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown41 = unknownTextBox41.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox42_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = levelListBox.SelectedIndex;
                Data<Level>.LevelList[index].Unknown42 = unknownTextBox42.Text;
                this.SavedChanges = false;
            }
        }
    }
}
