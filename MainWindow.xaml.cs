using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;

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
            curBox1.Items.Add("USD");
            curBox1.Items.Add("EUR");
            curBox1.Items.Add("GBP");
            curBox1.Items.Add("DKK");
            curBox1.Items.Add("SEK");
            curBox1.Items.Add("NOK");

            curBox2.Items.Add("USD");
            curBox2.Items.Add("EUR");
            curBox2.Items.Add("GBP");
            curBox2.Items.Add("DKK");
            curBox2.Items.Add("SEK");
            curBox2.Items.Add("NOK");
        }

        private float getCurrency(string api, string conversion)
        {
            try
            {
                string Json = new WebClient().DownloadString(api);
                var result = JsonConvert.DeserializeObject<dynamic>(Json);
                return result["rates"][conversion];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Prøv igen");
            }
            return 0;
        }

        private void CurBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CurBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void conBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (curBox1.Text.Length == 3 && curBox2.Text.Length == 3)
            {

                if (conBox.Text == "")
                {
                    resBox.Text = "";
                }
                else
                {
                    string apiRequest = "https://api.exchangeratesapi.io/latest?base=" + curBox1.SelectedItem;

                    string c2 = curBox2.SelectedItem.ToString();

                    float textValue = 1;
                    float currencyValue = getCurrency(apiRequest, c2);
                    try
                    {
                        textValue = float.Parse(conBox.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Noget gik galt");
                    }

                    resBox.Text = $"{textValue} {curBox1.SelectedItem} = {currencyValue * textValue} {c2}";

                }
            }
            else
            {
                MessageBox.Show("Vælg valutaer");
            }
        }
    }
}
