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
    /// Interaction logic for DyingItemsWindow.xaml
    /// </summary>
    public partial class DyingItemsWindow : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }

        public DyingItemsWindow()
        {
            InitializeComponent();
            Settings.EditorID = 3;
            this.Load = false;
            this.SavedChanges = true;
        }

        private void func(TextBox l)
        {
            l.Text = String.Empty;
        }

        private void loadMenuitem_Click(object sender, RoutedEventArgs e)
        {
            if (this.Load)
            {
                Data<DyingItems>.Flush(dyingItemsListBox, Data<DyingItems>.DyingItemsList);
                MessageBox.Show("File Already loaded, reloading...");
            }
           this.Load = LoadFile.LoadFunction(dyingItemsListBox, versionTextBlock);
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.Save(this.Load); 
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void unknownTextBox01_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown01 = unknownTextBox1.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
            
        }

        private void unknownTextBox02_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown02 = unknownTextBox2.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox03_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown03 = unknownTextBox3.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox04_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown04 = unknownTextBox4.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox05_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown05 = unknownTextBox5.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox06_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown06 = unknownTextBox6.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox07_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown07 = unknownTextBox7.Text;
                    this.SavedChanges = false;
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox08_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown08 = unknownTextBox8.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox09_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown09 = unknownTextBox9.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox10_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown10 = unknownTextBox10.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox11_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown11 = unknownTextBox11.Text;
                    this.SavedChanges = false;
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox12_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown12 = unknownTextBox12.Text;
                    this.SavedChanges = false;
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox13_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown13 = unknownTextBox13.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox14_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown14 = unknownTextBox14.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox15_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown15 = unknownTextBox15.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox16_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown16 = unknownTextBox16.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox17_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown17 = unknownTextBox17.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox18_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown18 = unknownTextBox18.Text;
                    this.SavedChanges = false;
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox19_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown19 = unknownTextBox19.Text;
                    this.SavedChanges = false;
                }
              
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox20_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown20 = unknownTextBox20.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox21_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown21 = unknownTextBox21.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox22_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown22 = unknownTextBox22.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox23_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown23 = unknownTextBox23.Text;
                    this.SavedChanges = false;
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox24_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown24 = unknownTextBox24.Text;
                    this.SavedChanges = false;
                }    
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox25_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown25 = unknownTextBox25.Text;
                    this.SavedChanges = false;
                }               
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox26_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = dyingItemsListBox.SelectedIndex;
                    Data<DyingItems>.DyingItemsList[index].Unknown26 = unknownTextBox26.Text;
                    this.SavedChanges = false;
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void dyingItemsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int selected = dyingItemsListBox.SelectedIndex;
                this.unknownTextBox1.Text = Data<DyingItems>.DyingItemsList[selected].Unknown01.ToString();
                this.unknownTextBox2.Text = Data<DyingItems>.DyingItemsList[selected].Unknown02.ToString();
                this.unknownTextBox3.Text = Data<DyingItems>.DyingItemsList[selected].Unknown03.ToString();
                this.unknownTextBox4.Text = Data<DyingItems>.DyingItemsList[selected].Unknown04.ToString();
                this.unknownTextBox5.Text = Data<DyingItems>.DyingItemsList[selected].Unknown05.ToString();
                this.unknownTextBox6.Text = Data<DyingItems>.DyingItemsList[selected].Unknown06.ToString();
                this.unknownTextBox7.Text = Data<DyingItems>.DyingItemsList[selected].Unknown07.ToString();
                this.unknownTextBox8.Text = Data<DyingItems>.DyingItemsList[selected].Unknown08.ToString();
                this.unknownTextBox9.Text = Data<DyingItems>.DyingItemsList[selected].Unknown09.ToString();
                this.unknownTextBox10.Text = Data<DyingItems>.DyingItemsList[selected].Unknown10.ToString();

                this.unknownTextBox11.Text = Data<DyingItems>.DyingItemsList[selected].Unknown11.ToString();
                this.unknownTextBox12.Text = Data<DyingItems>.DyingItemsList[selected].Unknown12.ToString();
                this.unknownTextBox13.Text = Data<DyingItems>.DyingItemsList[selected].Unknown13.ToString();
                this.unknownTextBox14.Text = Data<DyingItems>.DyingItemsList[selected].Unknown14.ToString();
                this.unknownTextBox15.Text = Data<DyingItems>.DyingItemsList[selected].Unknown15.ToString();
                this.unknownTextBox16.Text = Data<DyingItems>.DyingItemsList[selected].Unknown16.ToString();
                this.unknownTextBox17.Text = Data<DyingItems>.DyingItemsList[selected].Unknown17.ToString();
                this.unknownTextBox18.Text = Data<DyingItems>.DyingItemsList[selected].Unknown18.ToString();
                this.unknownTextBox19.Text = Data<DyingItems>.DyingItemsList[selected].Unknown19.ToString();
                this.unknownTextBox20.Text = Data<DyingItems>.DyingItemsList[selected].Unknown20.ToString();

                this.unknownTextBox21.Text = Data<DyingItems>.DyingItemsList[selected].Unknown21.ToString();
                this.unknownTextBox22.Text = Data<DyingItems>.DyingItemsList[selected].Unknown22.ToString();
                this.unknownTextBox23.Text = Data<DyingItems>.DyingItemsList[selected].Unknown23.ToString();
                this.unknownTextBox24.Text = Data<DyingItems>.DyingItemsList[selected].Unknown24.ToString();
                this.unknownTextBox25.Text = Data<DyingItems>.DyingItemsList[selected].Unknown25.ToString();
                this.unknownTextBox26.Text = Data<DyingItems>.DyingItemsList[selected].Unknown26.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            {
                Data<DyingItems>.Add(dyingItemsListBox);
            }
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            {
                Data<DyingItems>.Remove(dyingItemsListBox);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Quit(this.SavedChanges, this, this.Load, e);
        }
    }
}
