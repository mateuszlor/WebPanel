using System.Linq;
using WebPanel.Model;

namespace WebPanel.Services
{
    public class BaseService<T> : IBaseService<T> where T: BaseItem
    {
        public T GetItemById(long id) => ApplicationContext.Instance.Dao.Set<T>().AsEnumerable().FirstOrDefault(t => t.ID == id);
    }
}
