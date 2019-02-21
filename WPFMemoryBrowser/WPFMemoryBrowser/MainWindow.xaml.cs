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
using System.IO;

namespace WPFMemoryBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> comboBoxDataSource = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            populateCombo();
            foreach (var item in comboBoxDataSource)
            {
                combo1.Items.Add(item);
            }
            brwapp.Navigate("https://www.spartaglobal.com");


        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string item = combo2.SelectedItem.ToString();
            //brwControl.Navigate(item);
            //comboBoxDataSource.Add(e.Source.ToString());

        }
        public void populateCombo()
        {

            comboBoxDataSource.Add("https://www.google.com");
            comboBoxDataSource.Add("https://www.microsoft.com");
            comboBoxDataSource.Add("https://www.apple.com");
        }
        private void OnKeyPress(object sender, KeyEventArgs e)
        {
           
             
            if (e.Key == Key.Enter)
            {
                brwapp.Navigate(combo1.Text);
                //File.WriteAllText("C:/Users/tech-w99a.LAPTOP-3BLG1NHP/Engineering26/week6/day3/Sparta_Global_MemoryBrowser/urllist.txt", combo1.Text);
                using (StreamWriter str = new StreamWriter("C:/Users/tech-w99a.LAPTOP-3BLG1NHP/Engineering26/week6/day3/Sparta_Global_MemoryBrowser/urllist.txt"));

                //string x = str.ReadToEnd();
                //string[] y = x.Split('\n');
                //foreach (string s in y)
                //{
                //    combo1.Items.Add(s);
                //}

                //while (str.Peek() >= 0)
                //{
                //    combo1.Items.Add(str.ReadLine());
                //}
                //combo1.SelectedIndex = 0;



            }

            //combo1.Items.AddRange(File.ReadAllLines("C:/Users/tech-w99a.LAPTOP-3BLG1NHP/Engineering26/week6/day3/Sparta_Global_MemoryBrowser/urllist.txt"));

        }

                
        }
       
    }

