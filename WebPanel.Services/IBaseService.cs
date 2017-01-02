using WebPanel.Model;

namespace WebPanel.Services
{
    public interface IBaseService<T> where T : BaseItem
    {
        T GetItemById(long id);
    }
}