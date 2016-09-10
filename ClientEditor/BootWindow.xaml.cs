using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for BootWindow.xaml
    /// </summary>
    public partial class BootWindow : Window
    {
        private DirectoryInfo num2;
        public BootWindow()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo num = Directory.GetParent(path);
            this.num2 = Directory.GetParent(num.ToString());
            //ScanFile.CheckChars(@"C:\Dev\ClientEditor\ClientEditor\bin\Debug\c_adventureroad.ini");
        }

        private void editorChoiceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BitmapImage pic = new BitmapImage();
            try
            {
                pic.BeginInit();
                switch (editorChoiceComboBox.SelectedIndex)
                {
                    case 0:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "01_CharColor.png");
                        break;
                    case 1: pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "02_Classbase.png");
                        break;
                    case 2: pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "03_DyingitemsEditor.png");
                        break;
                    case 3: pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "04_AdventureRoadEditor.png");
                       break;
                    case 4:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "05_PvpEditor.png");
                        break;
                    case 5:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "06_FightEditor.png");
                        break;
                }
                pic.EndInit();
                editorImage.Source = pic;
                editorImage.Stretch = Stretch.Fill;
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("Something went wrong loading the image.");
            }      
        }

        private void launchButton_Click(object sender, RoutedEventArgs e)
        {
            switch(editorChoiceComboBox.SelectedIndex)
            {
                case 0:
                    MainWindow w = new MainWindow();
                    w.Show();
                    this.Hide();
                    break;
                case 1:
                    ClassBaseEditor cbe = new ClassBaseEditor();
                    cbe.Show();
                    this.Hide();
                    break;
                case 2:
                    DyingItemsWindow diw = new DyingItemsWindow();
                    diw.Show();
                    this.Hide();
                    break;
                case 3:
                    AdventureRoadWindow arw = new AdventureRoadWindow();
                    arw.Show();
                    this.Hide();
                    break;
                case 4:
                    PvpEditor pvpe = new PvpEditor();
                    pvpe.Show();
                    this.Hide();
                    break;
                case 5:
                    FightEditor fe = new FightEditor();
                    fe.Show();
                    this.Hide();
                    break;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var bericht = MessageBox.Show("Are you sure that you want to quit?", "Quit?", MessageBoxButton.YesNo);
            if(bericht == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
