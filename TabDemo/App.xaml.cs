namespace TabDemo
{
    using System.Windows;
    using Gu.Inject;

    public partial class App : Application
    {
        public static readonly Kernel Kernel = new Kernel();

        protected override void OnStartup(StartupEventArgs e)
        {
            Kernel.Get<MainWindow>().Show();
        }
    }
}
