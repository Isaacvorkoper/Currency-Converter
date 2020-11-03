using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace Valutaomregner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CurBox1.Items.Add("USD");
            CurBox1.Items.Add("EUR");
            CurBox1.Items.Add("GBP");
            CurBox1.Items.Add("DKK");
            CurBox1.Items.Add("SEK");
            CurBox1.Items.Add("NOK");

            CurBox2.Items.Add("USD");
            CurBox2.Items.Add("EUR");
            CurBox2.Items.Add("GBP");
            CurBox2.Items.Add("DKK");
            CurBox2.Items.Add("SEK");
            CurBox2.Items.Add("NOK");
        }

        private void ConBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "Indtast beløb")
                txtBox.Text = string.Empty;
        }

        private void CurBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CurBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ResBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
