namespace MauiApp1
{
    public partial class App : Application
    {
        public static FlyoutPage flyoutPage { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new Inicial();
        }
    }
}
