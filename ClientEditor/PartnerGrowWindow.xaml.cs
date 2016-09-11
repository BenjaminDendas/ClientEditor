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
    /// Interaction logic for PartnerGrowWindow.xaml
    /// </summary>
    public partial class PartnerGrowWindow : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }

        public PartnerGrowWindow()
        {
            InitializeComponent();
            Settings.EditorID = 8;
            this.Load = false;
            this.SavedChanges = true;
        }

        private void partnerGrowListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if(this.Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    unknownTextBox1.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown01;
                    unknownTextBox2.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown02;
                    unknownTextBox3.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown03;
                    unknownTextBox4.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown04;
                    unknownTextBox5.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown05;
                    unknownTextBox6.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown06;
                    unknownTextBox7.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown07;
                    unknownTextBox8.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown08;
                    unknownTextBox9.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown09;
                    unknownTextBox10.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown10;
                    unknownTextBox11.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown11;
                    unknownTextBox12.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown12;
                    unknownTextBox13.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown13;
                    unknownTextBox14.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown14;
                    unknownTextBox15.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown15;
                    unknownTextBox16.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown16;
                    unknownTextBox17.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown17;
                    unknownTextBox18.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown18;
                    unknownTextBox19.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown19;
                    unknownTextBox20.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown20;
                    unknownTextBox21.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown21;
                    unknownTextBox22.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown22;
                    unknownTextBox23.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown23;
                    unknownTextBox24.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown24;
                    unknownTextBox25.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown25;
                    unknownTextBox26.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown26;
                    unknownTextBox27.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown27;
                    unknownTextBox28.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown28;
                    unknownTextBox29.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown29;
                    unknownTextBox30.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown30;
                    unknownTextBox31.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown31;
                    unknownTextBox32.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown32;
                    unknownTextBox33.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown33;
                    unknownTextBox34.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown34;
                    unknownTextBox35.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown35;
                    unknownTextBox36.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown36;
                    unknownTextBox37.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown37;
                    unknownTextBox38.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown38;
                    unknownTextBox39.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown39;
                    unknownTextBox40.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown40;
                    unknownTextBox41.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown41;
                    unknownTextBox42.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown42;
                    unknownTextBox43.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown43;
                    unknownTextBox44.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown44;
                    unknownTextBox45.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown45;
                    unknownTextBox46.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown46;
                    unknownTextBox47.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown47;
                    unknownTextBox48.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown48;
                    unknownTextBox49.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown49;
                    unknownTextBox50.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown50;
                    unknownTextBox51.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown51;
                    unknownTextBox52.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown52;
                    unknownTextBox53.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown53;
                    unknownTextBox54.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown54;
                    unknownTextBox55.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown55;
                    unknownTextBox56.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown56;
                    unknownTextBox57.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown57;
                    unknownTextBox58.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown58;
                    unknownTextBox59.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown59;
                    unknownTextBox60.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown60;
                    unknownTextBox61.Text = Data<PartnerGrow>.PartnerGrowList[index].Unknown61;
                }
            }
            catch(ArgumentOutOfRangeException)
            {

            }
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<PartnerGrow>.Add(partnerGrowListBox);
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<PartnerGrow>.Remove(partnerGrowListBox);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Quit(SavedChanges, this, Load, e);
        }

        private void unknownTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if(Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown01 = unknownTextBox1.Text;
                }
            }
            catch(IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown02 = unknownTextBox2.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown03 = unknownTextBox3.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown04 = unknownTextBox4.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown05 = unknownTextBox5.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown06 = unknownTextBox6.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown07 = unknownTextBox7.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown08 = unknownTextBox8.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox9_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown09 = unknownTextBox9.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox10_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown10 = unknownTextBox10.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox11_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown11 = unknownTextBox11.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox12_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown12 = unknownTextBox12.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox13_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown13 = unknownTextBox13.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox14_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown14 = unknownTextBox14.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox15_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown15 = unknownTextBox15.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox16_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown16 = unknownTextBox16.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox17_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown17 = unknownTextBox17.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox18_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown18 = unknownTextBox18.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

        }

        private void unknownTextBox19_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown19 = unknownTextBox19.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

        }

        private void unknownTextBox20_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown20 = unknownTextBox20.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox21_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown21 = unknownTextBox21.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox22_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown22 = unknownTextBox22.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox23_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown23 = unknownTextBox23.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox24_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown24 = unknownTextBox24.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox25_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown25 = unknownTextBox25.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox26_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown26 = unknownTextBox26.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }


        private void unknownTextBox27_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown27 = unknownTextBox27.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox28_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown28 = unknownTextBox28.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox29_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown29 = unknownTextBox29.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox30_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown30 = unknownTextBox30.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox31_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown31 = unknownTextBox31.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox32_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown32 = unknownTextBox32.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox33_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown33 = unknownTextBox33.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox34_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown34 = unknownTextBox34.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox35_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown35 = unknownTextBox35.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox36_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown36 = unknownTextBox36.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox37_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown37 = unknownTextBox37.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox38_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown38 = unknownTextBox38.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox39_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown39 = unknownTextBox39.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox40_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown40 = unknownTextBox40.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox41_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown41 = unknownTextBox41.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox42_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown42 = unknownTextBox42.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox43_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown43 = unknownTextBox43.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox44_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown44 = unknownTextBox45.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox45_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown45 = unknownTextBox45.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox46_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown46 = unknownTextBox46.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox47_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown47 = unknownTextBox47.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox48_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown48 = unknownTextBox48.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox49_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown49 = unknownTextBox49.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox50_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown50 = unknownTextBox50.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox51_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown51 = unknownTextBox51.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox52_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown52 = unknownTextBox52.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox53_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown53 = unknownTextBox53.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox54_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown54 = unknownTextBox54.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox55_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown55 = unknownTextBox55.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox56_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown56 = unknownTextBox56.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox57_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown57 = unknownTextBox57.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox58_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown58 = unknownTextBox58.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox59_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown59 = unknownTextBox59.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox60_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown60 = unknownTextBox60.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void unknownTextBox61_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Load)
                {
                    int index = partnerGrowListBox.SelectedIndex;
                    Data<PartnerGrow>.PartnerGrowList[index].Unknown61 = unknownTextBox61.Text;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
        }


        private void loadMenuitem_Click(object sender, RoutedEventArgs e)
        {
            this.Load = LoadFile.LoadFunction(partnerGrowListBox, versionTextBlock);
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.Save(this.Load);
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }
    }
}
