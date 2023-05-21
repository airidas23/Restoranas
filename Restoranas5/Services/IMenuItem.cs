using Restoranas5.Models;

namespace Restoranas5.Services
{
    public interface IMenuItem
    {

        
        IEnumerable<MenuItem> MenuItems { get; }
        IEnumerable<MenuItem> PreferredMenuItems { get; }
        MenuItem GetMenuItemById(int menuItemId);

    }
}
