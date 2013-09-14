using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Controls;

namespace WP71Demo
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainPage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            anotherButton.Click += anotherButton_Click;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void anotherButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show(AppResources.MessageBoxString);
            //MessageBoxResult msgResult = MessageBox.Show(AppResources.MessageBoxString, "", MessageBoxButton.OKCancel);
            //if (msgResult == MessageBoxResult.OK)
            //{
            //    System.Diagnostics.Debug.WriteLine("OK");

            //    // make sure that navigation is performed in UI thread.
            //    Deployment.Current.Dispatcher.BeginInvoke(() =>
            //    {
            //        NavigationService.Navigate(new Uri("/View/SecondPage.xaml?param=yes", UriKind.Relative));                    
            //    });
            //}
            //else if (msgResult == MessageBoxResult.Cancel)
            //{
            //    System.Diagnostics.Debug.WriteLine("Cancel");
            //}
        }

        /// <summary>
        /// Shared button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SharedButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sender != null)
            {
                Button button = sender as Button;
                if (button != null)
                {
                    if (SharedButton1.Name.Equals(button.Name))
                    {
                        System.Diagnostics.Debug.WriteLine("Shared button 1");
                    }
                    else if (SharedButton2.Name.Equals(button.Name))
                    {
                        System.Diagnostics.Debug.WriteLine("Shared button 2");
                    }
                }            
            }
        }



    }
}