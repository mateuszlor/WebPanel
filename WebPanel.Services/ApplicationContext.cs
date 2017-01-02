using Spring.Context;
using Spring.Context.Support;

namespace WebPanel.Services
{
    public class ApplicationContext
    {
        #region Singleton
        
        public static ApplicationContext Instance => _instance ?? (_instance = new ApplicationContext());

        private static ApplicationContext _instance;

        #endregion

        #region Actual context

        public Dao Dao => ContextRegistry.GetContext().GetObject<Dao>("dao");

        public ITaskService TaskService => ContextRegistry.GetContext().GetObject<ITaskService>("taskService");

        #endregion
    }
}
