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
        public List<CharColor> CharColorList { get; set; }
        public bool Load { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Settings.EditorID = 1;
            
        }

        private void LoadFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadFile f = new LoadFile();
                this.CharColorList = f.ReadFile(5, Settings.EditorID);
                for (int i = 1; i <= CharColorList.Count; i++)
                {
                    CharColorListBox.Items.Add(i);
                }
                versionTextBlock.Text = Settings.Version;
                this.Load = true;
            }
            catch(EditorNotFoundException)
            {
                MessageBox.Show("Editor not supported, Application will close.");
                Environment.Exit(1);
            }
           
        }

        private void SaveFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(Load)
            {
                SaveFile.Save(this.CharColorList);
            }
        }

        private void QuitFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var message = MessageBox.Show("Are you sure that you want to go back to the main screen?", "Return to main", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
             if(message == MessageBoxResult.Yes)
            {
                this.Hide();
                // load main window
            }
            else { }
        }

        private void CharColorListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int selected = CharColorListBox.SelectedIndex;
                this.idTextBox.Text = CharColorList[selected].ID.ToString();
                this.colorTextBox.Text = CharColorList[selected].Color.ToString();
                this.unknown02TextBox.Text = CharColorList[selected].Unknown02.ToString();
                this.unknown03TextBox.Text = CharColorList[selected].Unknown03.ToString();
                this.unknown04TextBox.Text = CharColorList[selected].Unknown04.ToString();
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
                    CharColorList[index].ID = int.Parse(idTextBox.Text);
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
                    CharColorList[index].Color = colorTextBox.Text;
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
                    CharColorList[index].Unknown02 = int.Parse(unknown02TextBox.Text);
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
                    CharColorList[index].Unknown03 = int.Parse(unknown03TextBox.Text);
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
                    CharColorList[index].Unknown04 = int.Parse(unknown04TextBox.Text);
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
                CharColorListBox.Items.Add(CharColorListBox.Items.Count + 1);
                CharColorList.Add(new CharColor(0000, "", 0000, 0000, 0000));
                this.CharColorListBox.SelectedIndex = 0;
            }
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Load)
            {
                int selected = this.CharColorListBox.SelectedIndex;
                Console.WriteLine(selected);
                CharColorList.RemoveAt(selected);
                CharColorListBox.Items.RemoveAt(selected);
                this.CharColorListBox.SelectedIndex = 0;
                this.CharColorListBox.ScrollIntoView(CharColorListBox.Items.GetItemAt(0));
            }
        }
    }
}
