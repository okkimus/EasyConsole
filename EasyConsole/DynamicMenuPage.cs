using System.Runtime.InteropServices;

namespace EasyConsole
{
    public class DynamicMenuPage : MenuPage
    {
        private readonly IMenuItemProvider _menuItemProvider;
        
        public DynamicMenuPage(string title, Program program, IMenuItemProvider menuItemProvider)
            : base(title, program, menuItemProvider.GetMenuItems())
        {
            _menuItemProvider = menuItemProvider;
        }

        public void UpdateMenuItems()
        {
            var menuItems = _menuItemProvider.GetMenuItems();
            InitializeMenu(menuItems);
        }
    }
}