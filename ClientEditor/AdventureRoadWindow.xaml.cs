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
    /// Interaction logic for AdventureRoadWindow.xaml
    /// </summary>
    public partial class AdventureRoadWindow : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }

        public AdventureRoadWindow()
        {
            InitializeComponent();
            Settings.EditorID = 4;
            this.Load = false;
            this.SavedChanges = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var bericht = MessageBox.Show("Are you sure that you want to leave the editor?", "Quit?", MessageBoxButton.YesNo);
            if ((bericht == MessageBoxResult.Yes) && SavedChanges == true)
            {
                BootWindow win = new BootWindow();
                win.Show();
                this.Hide();
            }
            else
            {
                if (Load == true && (bericht == MessageBoxResult.Yes) && SavedChanges == false)
                {
                    var mess = MessageBox.Show("You have changes that are not saved, save?", "Save changes?", MessageBoxButton.YesNo);
                    if (mess == MessageBoxResult.Yes)
                    {
                        SaveFile.Save(this.Load);
                        BootWindow win = new BootWindow();
                        win.Show();
                        this.Hide();
                    }
                    else
                    {
                        BootWindow win = new BootWindow();
                        win.Show();
                        this.Hide();
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void loadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (this.Load)
            {
                Data<Adventureroad>.Flush(adventureListBox, Data<Adventureroad>.AdventureRoadList);
                MessageBox.Show("File Already loaded, reloading...");
            }
            this.Load = LoadFile.LoadFunction(adventureListBox, versionTextBlock, 13);
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.Save(this.Load);
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void adventureListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int selected = adventureListBox.SelectedIndex;
                this.unknownTextBox1.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown01.ToString();
                this.unknownTextBox2.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown02.ToString();
                this.unknownTextBox3.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown03.ToString();
                this.unknownTextBox4.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown04.ToString();
                this.unknownTextBox5.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown05.ToString();
                this.unknownTextBox6.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown06.ToString();
                this.unknownTextBox7.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown07.ToString();
                this.unknownTextBox8.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown08.ToString();
                this.unknownTextBox9.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown09.ToString();
                this.unknownTextBox10.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown10.ToString();
                this.unknownTextBox11.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown11.ToString();
                this.unknownTextBox12.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown12.ToString();
                this.unknownTextBox13.Text = Data<Adventureroad>.AdventureRoadList[selected].Unknown13.ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void unknownTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown01 = unknownTextBox1.Text;
                this.SavedChanges = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown02 = unknownTextBox2.Text;
                this.SavedChanges = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown03 = unknownTextBox3.Text;
                this.SavedChanges = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown04 = unknownTextBox4.Text;
                this.SavedChanges = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown05 = unknownTextBox5.Text;
                this.SavedChanges = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown06 = unknownTextBox6.Text;
                this.SavedChanges = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown07 = unknownTextBox7.Text;
                this.SavedChanges = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown08 = unknownTextBox8.Text;
                this.SavedChanges = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknownTextBox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown09 = unknownTextBox9.Text;
                this.SavedChanges = false;
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
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown10 = unknownTextBox10.Text;
                this.SavedChanges = false;
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
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown11 = unknownTextBox11.Text;
                this.SavedChanges = false;
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
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown12 = unknownTextBox12.Text;
                this.SavedChanges = false;
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
                int index = adventureListBox.SelectedIndex;
                Data<Adventureroad>.AdventureRoadList[index].Unknown13 = unknownTextBox13.Text;
                this.SavedChanges = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }
    }
}
