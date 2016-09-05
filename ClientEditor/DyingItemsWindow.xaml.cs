﻿using System;
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
        public DyingItemsWindow()
        {
            InitializeComponent();
            Settings.EditorID = 3;
            this.Load = false;
        }

        private void loadMenuitem_Click(object sender, RoutedEventArgs e)
        {
            if(this.Load)
            {
                Data.Flush(dyingItemsListBox, Data.DyingItemsList);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown01 = int.Parse(unknownTextBox01.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter integer values only.");
            }
            
        }

        private void unknownTextBox02_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown02 = int.Parse(unknownTextBox02.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown03 = int.Parse(unknownTextBox03.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown04 = int.Parse(unknownTextBox04.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown05 = int.Parse(unknownTextBox05.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown06 = int.Parse(unknownTextBox06.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown07 = int.Parse(unknownTextBox07.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown08 = int.Parse(unknownTextBox08.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown09 = int.Parse(unknownTextBox09.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown10 = int.Parse(unknownTextBox10.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown11 = int.Parse(unknownTextBox11.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown12 = int.Parse(unknownTextBox12.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown13 = int.Parse(unknownTextBox13.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown14 = int.Parse(unknownTextBox14.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown15 = int.Parse(unknownTextBox15.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown16 = int.Parse(unknownTextBox16.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown17 = int.Parse(unknownTextBox17.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown18 = int.Parse(unknownTextBox18.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown19 = int.Parse(unknownTextBox19.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown20 = int.Parse(unknownTextBox20.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown21 = int.Parse(unknownTextBox21.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown22 = int.Parse(unknownTextBox22.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown23 = int.Parse(unknownTextBox23.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown24 = int.Parse(unknownTextBox24.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown25 = int.Parse(unknownTextBox25.Text);
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
                int index = dyingItemsListBox.SelectedIndex;
                Data.DyingItemsList[index].Unknown26 = int.Parse(unknownTextBox26.Text);
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
                this.unknownTextBox01.Text = Data.DyingItemsList[selected].Unknown01.ToString();
                this.unknownTextBox02.Text = Data.DyingItemsList[selected].Unknown02.ToString();
                this.unknownTextBox03.Text = Data.DyingItemsList[selected].Unknown03.ToString();
                this.unknownTextBox04.Text = Data.DyingItemsList[selected].Unknown04.ToString();
                this.unknownTextBox05.Text = Data.DyingItemsList[selected].Unknown05.ToString();
                this.unknownTextBox06.Text = Data.DyingItemsList[selected].Unknown06.ToString();
                this.unknownTextBox07.Text = Data.DyingItemsList[selected].Unknown07.ToString();
                this.unknownTextBox08.Text = Data.DyingItemsList[selected].Unknown08.ToString();
                this.unknownTextBox09.Text = Data.DyingItemsList[selected].Unknown09.ToString();
                this.unknownTextBox10.Text = Data.DyingItemsList[selected].Unknown10.ToString();

                this.unknownTextBox11.Text = Data.DyingItemsList[selected].Unknown11.ToString();
                this.unknownTextBox12.Text = Data.DyingItemsList[selected].Unknown12.ToString();
                this.unknownTextBox13.Text = Data.DyingItemsList[selected].Unknown13.ToString();
                this.unknownTextBox14.Text = Data.DyingItemsList[selected].Unknown14.ToString();
                this.unknownTextBox15.Text = Data.DyingItemsList[selected].Unknown15.ToString();
                this.unknownTextBox16.Text = Data.DyingItemsList[selected].Unknown16.ToString();
                this.unknownTextBox17.Text = Data.DyingItemsList[selected].Unknown17.ToString();
                this.unknownTextBox18.Text = Data.DyingItemsList[selected].Unknown18.ToString();
                this.unknownTextBox19.Text = Data.DyingItemsList[selected].Unknown19.ToString();
                this.unknownTextBox20.Text = Data.DyingItemsList[selected].Unknown20.ToString();

                this.unknownTextBox21.Text = Data.DyingItemsList[selected].Unknown21.ToString();
                this.unknownTextBox22.Text = Data.DyingItemsList[selected].Unknown22.ToString();
                this.unknownTextBox23.Text = Data.DyingItemsList[selected].Unknown23.ToString();
                this.unknownTextBox24.Text = Data.DyingItemsList[selected].Unknown24.ToString();
                this.unknownTextBox25.Text = Data.DyingItemsList[selected].Unknown25.ToString();
                this.unknownTextBox26.Text = Data.DyingItemsList[selected].Unknown26.ToString();





            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}