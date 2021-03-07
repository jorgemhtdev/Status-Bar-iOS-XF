namespace iOSStatusBarXF
{
    using Xamarin.Forms;
    using Xamarin.Forms.PlatformConfiguration;

    public static class StatusBar
    {
        public static readonly BindableProperty StatusBarStyleProperty = BindableProperty.CreateAttached(
            "StatusBarStyle",
            typeof(StatusBarStyle),
            typeof(Page),
            StatusBarStyle.Default);

        public static void SetStatusBarStyle(BindableObject page, StatusBarStyle value)
                             => page.SetValue(StatusBarStyleProperty, value);

        public static IPlatformElementConfiguration<iOS, Page> SetStatusBarStyle(this IPlatformElementConfiguration<iOS, Page> config, StatusBarStyle value)
        {
            SetStatusBarStyle(config.Element, value);
            return config;
        }

        public static StatusBarStyle GetStatusBarStyle(BindableObject page) => (StatusBarStyle)page.GetValue(StatusBarStyleProperty);
        public static StatusBarStyle GetStatusBarStyle(this IPlatformElementConfiguration<iOS, Page> config) => GetStatusBarStyle(config.Element);

    }
}
