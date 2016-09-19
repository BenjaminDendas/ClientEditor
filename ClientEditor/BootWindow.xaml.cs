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
                    case 6:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "07_MageEditor.png");
                        break;
                    case 7:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "08_PartnerGrowEditor.png");
                        break;
                    case 8:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "09_PartnerTalkEditor.png");
                        break;
                    case 9:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "10_GrowEquipEditor.png");
                        break;
                  /*  case 10:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "11_DialogEditor.png");
                        break;*/
                    case 11:
                        pic.UriSource = new Uri(this.num2 + "" + System.IO.Path.DirectorySeparatorChar + "Pictures" + "" + System.IO.Path.DirectorySeparatorChar + "12_LevelEditor.png");
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
                case 6:
                    MageWindow mw = new MageWindow();
                    mw.Show();
                    this.Hide();
                    break;
                case 7:
                    PartnerGrowWindow pg = new PartnerGrowWindow();
                    pg.Show();
                    this.Hide();
                    break;
                case 8:
                    PartnerTalkEditor pte = new PartnerTalkEditor();
                    pte.Show();
                    this.Hide();
                    break;
                case 9:
                    GrowequipWindow gw = new GrowequipWindow();
                    this.Hide();
                    gw.Show();
                    break;
            /*    case 10:
                    DialogueWindow dw = new DialogueWindow();
                    this.Hide();
                    dw.Show();
                    break;
                    */
                case 11:
                    LevelWindow lw = new LevelWindow();
                    this.Hide();
                    lw.Show();
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
