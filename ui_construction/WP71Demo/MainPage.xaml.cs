using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;

namespace WP71Demo
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // clear the default text when user moves focus to username/password box
        private void usernameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            usernameBox.Text = "";
        }
        private void passwordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            passwordBox.Text = "";
        }

        // make small checks in on Click Event
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (usernameBox.Text.Trim() == "" || passwordBox.Text.Trim() == "")
            {
                MessageBox.Show("Username or Password incorrect.");
            }
            else
            {
                if (liteCheckBox.IsChecked.Value)
                {
                    MessageBox.Show("Login To Lite Version");
                }
                else
                {
                    MessageBox.Show("Login Successfull");
                }

                
            }
        }

    }
}