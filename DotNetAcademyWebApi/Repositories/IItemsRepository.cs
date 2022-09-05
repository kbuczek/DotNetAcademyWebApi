using DotNetAcademyWebApi.Entities_Models_;

namespace DotNetAcademyWebApi.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}