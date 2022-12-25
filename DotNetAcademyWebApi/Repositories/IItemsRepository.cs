using DotNetAcademyWebApi.Entities_Models_;

namespace DotNetAcademyWebApi.Repositories
{
    public interface IItemsRepository //interface is used for dependency injection in ItemsController
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}