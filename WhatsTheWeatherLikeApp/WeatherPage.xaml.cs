using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WhatsTheWeatherLikeApp
{
    public partial class WeatherMainPage : PhoneApplicationPage
    {
        // Constructor
        public WeatherMainPage()
        {
            InitializeComponent();
        }

        private void citySearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            citySearchBox.Text = "";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (citySearchBox.Text.Trim() == "" || citySearchBox.Text.Trim() == "City name") {
                MessageBox.Show("City name not given. Cannot search");
                return;
            }



        }
    }
}