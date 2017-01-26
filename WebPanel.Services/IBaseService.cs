using System.Collections.Generic;
using WebPanel.Model;

namespace WebPanel.Services
{
    public interface IBaseService<T> where T : BaseItem
    {
        T GetItemById(long id);
        IList<T> GetAllItems();
        void CreateNew(T item);
        void UpdateItem(T item);
        void DeleteAllItems();
    }
}