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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Settings.EditorID = 1;
            this.Load = false;
            this.SavedChanges = true;
            //ScanFile.CheckChars(@"D:\INI-EditorV4\client\C_ClassBase.ini");    
        }

        private void LoadFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            {
                Data.Flush(CharColorListBox,Data.CharColorList);
            }  
               this.Load = LoadFile.LoadFunction(CharColorListBox, versionTextBlock,5);
        }      

        private void SaveFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            {
                SaveFile.Save(this.Load);
            }
        }

        private void QuitFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void CharColorListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int selected = CharColorListBox.SelectedIndex;
                this.idTextBox.Text = Data.CharColorList[selected].ID.ToString();
                this.colorTextBox.Text = Data.CharColorList[selected].Color.ToString();
                this.unknown02TextBox.Text = Data.CharColorList[selected].Unknown02.ToString();
                this.unknown03TextBox.Text = Data.CharColorList[selected].Unknown03.ToString();
                this.unknown04TextBox.Text = Data.CharColorList[selected].Unknown04.ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }

        private void idTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                try
                {
                    int index = this.CharColorListBox.SelectedIndex;
                    Data.CharColorList[index].ID = idTextBox.Text;
                    this.SavedChanges = false;
                }
                catch(FormatException)
                {
                    MessageBox.Show("Please enter numeric values only.");
                }      
            }
        }

        private void colorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                try
                {
                    int index = this.CharColorListBox.SelectedIndex;
                    Data.CharColorList[index].Color = colorTextBox.Text;
                    this.SavedChanges = false;
                }
                catch(FormatException)
                {
                    MessageBox.Show("unknown string value");
                }
            }
        }

        private void unknown02TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                try
                {
                    int index = this.CharColorListBox.SelectedIndex;
                    Data.CharColorList[index].Unknown02 = unknown02TextBox.Text;
                    this.SavedChanges = false;
                }
                catch(FormatException)
                {
                    MessageBox.Show("Please enter Numeric values only!");
                }
            }
        }

        private void unknown03TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                try
                {
                    int index = this.CharColorListBox.SelectedIndex;
                    Data.CharColorList[index].Unknown03 = unknown03TextBox.Text;
                    this.SavedChanges = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter Numeric values only!");
                }
            }
        }

        private void unknown04TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                try
                {
                    int index = this.CharColorListBox.SelectedIndex;
                    Data.CharColorList[index].Unknown04 = unknown04TextBox.Text;
                    this.SavedChanges = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter Numeric values only!");

                }
            }
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            {
                Data.Add(CharColorListBox);
                this.SavedChanges = false;
            }
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Load)
            {
                Data.Remove(CharColorListBox);
                this.SavedChanges = false;
            }
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
    }
}
