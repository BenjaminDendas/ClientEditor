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
                Data<CharColor>.Flush(CharColorListBox,Data<CharColor>.CharColorList);
            }  
               this.Load = LoadFile.LoadFunction(CharColorListBox, versionTextBlock);
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
                this.idTextBox.Text = Data<CharColor>.CharColorList[selected].ID.ToString();
                this.colorTextBox.Text = Data<CharColor>.CharColorList[selected].Color.ToString();
                this.unknown02TextBox.Text = Data<CharColor>.CharColorList[selected].Unknown02.ToString();
                this.unknown03TextBox.Text = Data<CharColor>.CharColorList[selected].Unknown03.ToString();
                this.unknown04TextBox.Text = Data<CharColor>.CharColorList[selected].Unknown04.ToString();
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
                    Data<CharColor>.CharColorList[index].ID = idTextBox.Text;
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
                    Data<CharColor>.CharColorList[index].Color = colorTextBox.Text;
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
                    Data<CharColor>.CharColorList[index].Unknown02 = unknown02TextBox.Text;
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
                    Data<CharColor>.CharColorList[index].Unknown03 = unknown03TextBox.Text;
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
                    Data<CharColor>.CharColorList[index].Unknown04 = unknown04TextBox.Text;
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
                Data<CharColor>.Add(CharColorListBox);
                this.SavedChanges = false;
            }
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Load)
            {
                Data<CharColor>.Remove(CharColorListBox);
                this.SavedChanges = false;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Quit(this.SavedChanges, this, this.Load, e);
        }
    }
}
