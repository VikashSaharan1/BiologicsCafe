using BiologicsCafe.Models;

namespace BiologicsCafe.Repository
{
    public interface IMenuRepository
    {
        IEnumerable<MenuItem> GetMenuItems();
    }
}
