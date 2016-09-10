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
    /// Interaction logic for ClassBaseEditor.xaml
    /// </summary>
    public partial class ClassBaseEditor : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }

        public ClassBaseEditor()
        {
            InitializeComponent();
            Settings.EditorID = 2;
            this.Load = false;
            this.SavedChanges = true;
        }

        private void loadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(this.Load)
            {
                Data<ClassBase>.Flush(classbaseListBox, Data<ClassBase>.ClassBaseList);
            }
            this.Load = LoadFile.LoadFunction(classbaseListBox, versionTextBlock);
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.Save(this.Load);
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void unknown01TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if(Load)
                {
                    int index = classbaseListBox.SelectedIndex;
                    Data<ClassBase>.ClassBaseList[index].Unknown01 = unknown01TextBox.Text;
                    SavedChanges = false;
                }
               
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
        }

        private void unknown02TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if(Load)
                {
                    int index = classbaseListBox.SelectedIndex;
                    Data<ClassBase>.ClassBaseList[index].Unknown02 = unknown02TextBox.Text;
                    SavedChanges = false;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter double values only.");
            }
        }

        private void unknown03TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = classbaseListBox.SelectedIndex;
                    Data<ClassBase>.ClassBaseList[index].Unknown03 = unknown03TextBox.Text;
                    SavedChanges = false;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter double values only.");
            }
        }

        private void unknown04TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = classbaseListBox.SelectedIndex;
                    Data<ClassBase>.ClassBaseList[index].Unknown04 = unknown04TextBox.Text;
                    SavedChanges = false;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter double values only.");
            }
        }

        private void unknown05TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = classbaseListBox.SelectedIndex;
                    Data<ClassBase>.ClassBaseList[index].Unknown05 = unknown05TextBox.Text;
                    SavedChanges = false;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter double values only.");
            }
        }

        private void unknown06TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = classbaseListBox.SelectedIndex;
                    Data<ClassBase>.ClassBaseList[index].Unknown06 = unknown06TextBox.Text;
                    SavedChanges = false;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter double values only.");
            }
        }

        private void unknown07TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = classbaseListBox.SelectedIndex;
                    Data<ClassBase>.ClassBaseList[index].Unknown07 = unknown07TextBox.Text;
                    SavedChanges = false;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter double values only.");
            }
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<ClassBase>.Add(classbaseListBox);
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<ClassBase>.Remove(classbaseListBox);
        }

        private void classbaseListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int selected = classbaseListBox.SelectedIndex;
                this.unknown01TextBox.Text = Data<ClassBase>.ClassBaseList[selected].Unknown01.ToString();
                this.unknown02TextBox.Text = Data<ClassBase>.ClassBaseList[selected].Unknown02.ToString();
                this.unknown03TextBox.Text = Data<ClassBase>.ClassBaseList[selected].Unknown03.ToString();
                this.unknown04TextBox.Text = Data<ClassBase>.ClassBaseList[selected].Unknown04.ToString();
                this.unknown05TextBox.Text = Data<ClassBase>.ClassBaseList[selected].Unknown05.ToString();
                this.unknown06TextBox.Text = Data<ClassBase>.ClassBaseList[selected].Unknown06.ToString();
                this.unknown07TextBox.Text = Data<ClassBase>.ClassBaseList[selected].Unknown07.ToString();


            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var bericht = MessageBox.Show("Are you sure that you want to leave the editor?", "Quit?", MessageBoxButton.YesNo);
            if ((bericht == MessageBoxResult.Yes) && (SavedChanges == true))
            {
                BootWindow win = new BootWindow();
                win.Show();
                this.Hide();
            }
            else
            {

                if (Load == true && (bericht == MessageBoxResult.Yes))
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
