using _4Container.Contracts;
using Microsoft.Practices.Unity;

namespace _4Container
{
    class BLogic
    {
        IRepository _repo;

        public BLogic(IRepository repo)
        {
            _repo = repo;
        }
        public BLogic(UnityContainer container)
        {
            _repo = container.Resolve<IRepository>();
        }

        public void DoSomeWork()
        {
            _repo.Update("Update test");
        }
    }
}
