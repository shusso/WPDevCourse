using Microsoft.Phone.Controls;

namespace WP71Demo.Views
{
    public partial class SecondPage : PhoneApplicationPage
    {

        public SecondPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            string val = string.Empty;
            if (NavigationContext.QueryString.ContainsKey("param"))
            {
                val = NavigationContext.QueryString["param"];
            }

            System.Diagnostics.Debug.WriteLine(string.IsNullOrEmpty(val)  ? "No such value." : val);
            base.OnNavigatedTo(e);
        }

    }
}