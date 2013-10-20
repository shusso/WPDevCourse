using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;

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
    public partial class MainPage : PhoneApplicationPage
    {
        private string City_Name;
        private int City_Code;
        bool _isNewPageInstance = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            _isNewPageInstance = true;
            (Application.Current as WhatsTheWeatherLikeApp.App).ApplicationDataObjectChanged +=
                new EventHandler(MainPage_ApplicationDataObjectChanged);
        }



        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (_isNewPageInstance)
            {
                if ((Application.Current as WhatsTheWeatherLikeApp.App).ApplicationDataObject != null)
                {
                    MessageBox.Show("Updating DataUI");
                    UpdateApplicationDataUI();
                }
                else
                {
                    MessageBox.Show("Getting DataAsync");
                    (Application.Current as WhatsTheWeatherLikeApp.App).GetDataAsync();

                    MessageBox.Show("AppDataObj " + (Application.Current as WhatsTheWeatherLikeApp.App).ApplicationDataStatus.ToString());
                    
                }
            }
            _isNewPageInstance = false;

        }

        void MainPage_ApplicationDataObjectChanged(object sender, EventArgs e)
        {
            MessageBox.Show("data object changed");
            Dispatcher.BeginInvoke(() => UpdateApplicationDataUI());
        }

        void UpdateApplicationDataUI()
        {
            //cityTextBlock.Text = (Application.Current as WhatsTheWeatherLikeApp.App).ApplicationDataObject;
            MessageBox.Show("AppDataObj " + (Application.Current as WhatsTheWeatherLikeApp.App).ApplicationDataStatus.ToString());
        }

        private bool isNetworkAvailable()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Network Not Available");
                return false;
            }
        }

        private void doHTTPRequest() 
        {
        }

        private void handleJSON()
        {
        }

        private void citySearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            citySearchBox.Text = "";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (citySearchBox.Text.Trim() == "" || citySearchBox.Text.Trim() == "city name") {
                MessageBox.Show("City name not given. Cannot search");
                return;
            }

            City_Name = citySearchBox.Text;

            /* Do the actual stuff here */
            /* @TODO fetch the city data with JSON */
            /* @TODO parse the data */
            /* @TODO pass the parsed data to the WeatherInfoPage*/

            // at this point, send the given name to the subpage
            NavigationService.Navigate(new Uri("/WeatherInfoPage.xaml?city="+ citySearchBox.Text, UriKind.Relative));
        }
    }
}