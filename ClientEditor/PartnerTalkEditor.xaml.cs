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
    /// Interaction logic for PartnerTalkEditor.xaml
    /// </summary>
    public partial class PartnerTalkEditor : Window
    {
        public bool Load { get; set; }
        public bool SavedChanges { get; set; }
        public PartnerTalkEditor()
        {
            InitializeComponent();
            Settings.EditorID = 9;
            this.Load = false;
            this.SavedChanges = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Quit(this.SavedChanges, this, this.Load, e);
        }

        private void loadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Load = LoadFile.LoadFunction(partnerTalkListBox, versionTextBlock);
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFile.Save(this.Load);
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings.Quit(this);
        }

        private void partnerTalkListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int index = partnerTalkListBox.SelectedIndex;
                unknownTextBox1.Text = Data<PartnerTalk>.PartnerTalkList[index].Unknown1;
                unknownTextBox2.Text = Data<PartnerTalk>.PartnerTalkList[index].Unknown2;
                unknownTextBox3.Text = Data<PartnerTalk>.PartnerTalkList[index].Unknown3;
                unknownTextBox4.Text = Data<PartnerTalk>.PartnerTalkList[index].Unknown4;
                unknownTextBox5.Text = Data<PartnerTalk>.PartnerTalkList[index].Unknown5;
                unknownTextBox6.Text = Data<PartnerTalk>.PartnerTalkList[index].Unknown6;
                unknownTextBox7.Text = Data<PartnerTalk>.PartnerTalkList[index].Unknown7;
            }
            catch(IndexOutOfRangeException)
            {

            }
        }

        private void newContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<PartnerTalk>.Add(partnerTalkListBox);
        }

        private void removeContextMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Data<PartnerTalk>.Remove(partnerTalkListBox);
        }

        private void unknownTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Load)
            {
                try
                {
                    int index = partnerTalkListBox.SelectedIndex;
                    Data<PartnerTalk>.PartnerTalkList[index].Unknown1 = unknownTextBox1.Text;
                }
                catch(Exception)
                {

                }
            }
        }

        private void unknownTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                try
                {
                    int index = partnerTalkListBox.SelectedIndex;
                    Data<PartnerTalk>.PartnerTalkList[index].Unknown2 = unknownTextBox2.Text;
                }
                catch (Exception)
                {

                }
            }
        }

        private void unknownTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                try
                {
                    int index = partnerTalkListBox.SelectedIndex;
                    Data<PartnerTalk>.PartnerTalkList[index].Unknown3 = unknownTextBox3.Text;
                }
                catch (Exception)
                {

                }
            }
        }

        private void unknownTextBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                try
                {
                    int index = partnerTalkListBox.SelectedIndex;
                    Data<PartnerTalk>.PartnerTalkList[index].Unknown4 = unknownTextBox4.Text;
                }
                catch (Exception)
                {

                }
            }
        }

        private void unknownTextBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                try
                {
                    int index = partnerTalkListBox.SelectedIndex;
                    Data<PartnerTalk>.PartnerTalkList[index].Unknown5 = unknownTextBox5.Text;
                }
                catch (Exception)
                {

                }
            }
        }

        private void unknownTextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                try
                {
                    int index = partnerTalkListBox.SelectedIndex;
                    Data<PartnerTalk>.PartnerTalkList[index].Unknown6 = unknownTextBox6.Text;
                }
                catch (Exception)
                {

                }
            }
        }

        private void unknownTextBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Load)
            {
                try
                {
                    int index = partnerTalkListBox.SelectedIndex;
                    Data<PartnerTalk>.PartnerTalkList[index].Unknown7 = unknownTextBox7.Text;
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
