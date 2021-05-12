using EasyConsole;

namespace Demo.Pages
{
    class MainPage : DynamicMenuPage
    {
        public MainPage(Program program, IMenuItemProvider menuItemProvider)
            : base("Main Page", program, menuItemProvider)
        {
        }
    }
}
