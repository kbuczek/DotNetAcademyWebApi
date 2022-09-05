using DotNetAcademyWebApi.DTOs;
using DotNetAcademyWebApi.Entities_Models_;

namespace DotNetAcademyWebApi
{
    //extends a definition of a one type by adding some method that can be executed in that type
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item) //'this Item' makes it an Item static method
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate,

            };
        }
    }
}
