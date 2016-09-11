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
    /// Interaction logic for MageWindow.xaml
    /// </summary>
    public partial class MageWindow : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }
        public MageWindow()
        {
            InitializeComponent();
            Settings.EditorID = 7;
            this.Load = false;
            this.SavedChanges = true;
        }

        private void loadMenuitem_Click(object sender, RoutedEventArgs e)
        {
            this.Load = LoadFile.LoadFunction(mageListBox, versionTextBlock);
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
                if(Load)
                {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown01 = unknownTextBox1.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown02 = unknownTextBox2.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown03 = unknownTextBox3.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown04 = unknownTextBox4.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown05 = unknownTextBox5.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown06 = unknownTextBox6.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown07 = unknownTextBox7.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown08 = unknownTextBox8.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown09 = unknownTextBox9.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox10_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown10 = unknownTextBox10.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox11_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown11 = unknownTextBox11.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox12_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown12 = unknownTextBox12.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox13_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown13 = unknownTextBox13.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox14_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown14 = unknownTextBox14.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox15_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown15 = unknownTextBox15.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox16_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown16 = unknownTextBox16.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox17_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown17 = unknownTextBox17.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox18_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown18 = unknownTextBox18.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox19_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown19 = unknownTextBox19.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox20_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown20 = unknownTextBox20.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox21_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown21 = unknownTextBox21.Text;
                this.SavedChanges = false;
            }
        }

        private void unknownTextBox22_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                int index = mageListBox.SelectedIndex;
                Data<Mage>.MageList[index].Unknown22 = unknownTextBox22.Text;
                this.SavedChanges = false;
            }
        }

        private void mageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int index = mageListBox.SelectedIndex;
                unknownTextBox1.Text = Data<Mage>.MageList[index].Unknown01;
                unknownTextBox2.Text = Data<Mage>.MageList[index].Unknown02;
                unknownTextBox3.Text = Data<Mage>.MageList[index].Unknown03;
                unknownTextBox4.Text = Data<Mage>.MageList[index].Unknown04;
                unknownTextBox5.Text = Data<Mage>.MageList[index].Unknown05;
                unknownTextBox6.Text = Data<Mage>.MageList[index].Unknown06;
                unknownTextBox7.Text = Data<Mage>.MageList[index].Unknown07;
                unknownTextBox8.Text = Data<Mage>.MageList[index].Unknown08;
                unknownTextBox9.Text = Data<Mage>.MageList[index].Unknown09;
                unknownTextBox10.Text = Data<Mage>.MageList[index].Unknown10;
                unknownTextBox11.Text = Data<Mage>.MageList[index].Unknown11;
                unknownTextBox12.Text = Data<Mage>.MageList[index].Unknown12;
                unknownTextBox13.Text = Data<Mage>.MageList[index].Unknown13;
                unknownTextBox14.Text = Data<Mage>.MageList[index].Unknown14;
                unknownTextBox15.Text = Data<Mage>.MageList[index].Unknown15;
                unknownTextBox16.Text = Data<Mage>.MageList[index].Unknown16;
                unknownTextBox17.Text = Data<Mage>.MageList[index].Unknown17;
                unknownTextBox18.Text = Data<Mage>.MageList[index].Unknown18;
                unknownTextBox19.Text = Data<Mage>.MageList[index].Unknown19;
                unknownTextBox20.Text = Data<Mage>.MageList[index].Unknown20;
                unknownTextBox21.Text = Data<Mage>.MageList[index].Unknown21;
                unknownTextBox22.Text = Data<Mage>.MageList[index].Unknown22;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<Mage>.Add(mageListBox);
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<Mage>.Remove(mageListBox);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Quit(this.SavedChanges, this, this.Load, e);
        }
    }
}
