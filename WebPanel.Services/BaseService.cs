using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebPanel.Model;

namespace WebPanel.Services
{
    public class BaseService<T> : IBaseService<T> where T: BaseItem
    {
        public T GetItemById(long id) => ApplicationContext.Instance.Dao.Set<T>().AsEnumerable().FirstOrDefault(t => t.ID == id);

        public IList<T> GetAllItems() => ApplicationContext.Instance.Dao.Set<T>().ToList();
        public IList<T> GetItems(int skip, int chunk) => ApplicationContext.Instance.Dao.Set<T>().AsEnumerable().Skip(skip).Take(chunk).ToList();

        public void CreateNew(T item) => ApplicationContext.Instance.Dao.Set<T>().Add(item);
    }
}
