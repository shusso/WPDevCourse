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
using WhatsTheWeatherLikeApp;

namespace WhatsTheWeatherLikeApp
{
    public partial class WeatherInfoPage : PhoneApplicationPage
    {
        private string City_Name;
        private int City_Code;

        public WeatherInfoPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string msg;
            // get the city name from the search query from the mainPage
            if (NavigationContext.QueryString.TryGetValue("city", out msg))
            {
                City_Name = msg;
                MessageBox.Show("Weather for " + City_Name);
                cityTextBlock.Text = City_Name;
            }
        }
    }
}