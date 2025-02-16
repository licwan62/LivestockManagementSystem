namespace Task4_MVVE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();

            // forcely set the theme to light
            UserAppTheme = AppTheme.Light;
        }
    }
}
