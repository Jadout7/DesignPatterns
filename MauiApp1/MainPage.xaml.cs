namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        void OnContinueClicked(object sender, EventArgs e)
        {
            // Navigate to the order page
            Application.Current.MainPage = new Features();
        }

    }

}
