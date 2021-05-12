using Demo.Pages;
using EasyConsole;
using Demo.Providers;

namespace Demo
{
    class DemoProgram : Program
    {
        public DemoProgram()
            : base("EasyConsole Demo", breadcrumbHeader: true)
        {
            AddPage(new MainPage(this, new MenuProvider(this)));

            SetPage<MainPage>();
        }
    }
}
