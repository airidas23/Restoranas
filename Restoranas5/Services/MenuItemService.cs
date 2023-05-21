using Restoranas5.Data;
using Restoranas5.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restoranas5.Services
{
    public class MenuItemService : IMenuItem
    {
        private readonly ApplicationDbContext _context;
        public MenuItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<MenuItem> MenuItems
        {
            get
            {
                return _context.MenuItem;
            }
        }

        public IEnumerable<MenuItem> PreferredMenuItems
        {
            get
            {
                // Throw new NotImplementedException(), jei šis metodas dar neįgyvendintas
                //throw new NotImplementedException();

                // Grąžinkite visus MenuItems, kurie laikomi "Preferred"
                return _context.MenuItem.Where(m => m.IsPreferred);
            }
        }

        public MenuItem GetMenuItemById(int menuItemId)
        {
            return _context.MenuItem.FirstOrDefault(p => p.Id == menuItemId);
        }
    }
}
