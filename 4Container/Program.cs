using _4Container.Contracts;
using Microsoft.Practices.Unity;

namespace _4Container
{
    class Program
    {
        static void MainWithOutContainer(string[] args) // Without Container
        {
            IRepository repo = new Repo();

            BLogic bl = new BLogic(repo);
            bl.DoSomeWork();
        }




        static void Main(string[] args)     // With Container
        {
            UnityContainer container = new UnityContainer();
            container.RegisterInstance<IRepository>(new Repo());

            BLogic bl = new BLogic(container);
            bl.DoSomeWork();
        }
    }
}
