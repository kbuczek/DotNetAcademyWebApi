using DotNetAcademyWebApi.Entities_Models_;
using DotNetAcademyWebApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using DotNetAcademyWebApi.DTOs;


namespace DotNetAcademyWebApi.Controllers
{
    [ApiController] //mark this class as ApiController, brings a bunch of additional default behaviours
    [Route("[controller]")] //"/items"
    public class ItemsController : ControllerBase
    {
        //private readonly InMemItemsRepository repository; explicit dependency, bad practice
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            //repository = new InMemItemsRepository(); explicit dependency, bad practice
            this.repository = repository; //dependency injection
        }

        [HttpGet] //when somebody performs GET "/items"
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select( item => item.AsDto());
            return items;
        }

        //GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if(item is null)
            {
                return NotFound();
            }

            return Ok(item.AsDto());
        }
    }
}
