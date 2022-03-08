using MenuItemListingWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MenuItemListingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        List<MenuItem> menuItems;
        MenuItem i1;
        public MenuItemController()
        {
            i1 = new MenuItem { Id = 1, Name = "pizza", freeDelivery = true, Price = 200, dateOfLaunch = Convert.ToDateTime("2/2/2030"), Active = true };
            menuItems = new List<MenuItem>()
            {
                new MenuItem(){Id=1,Name="pizza",freeDelivery=true,Price=200,dateOfLaunch=Convert.ToDateTime("2/2/2030"),Active=true},
                 new MenuItem(){Id=2,Name="pizza1",freeDelivery=false,Price=100,dateOfLaunch=Convert.ToDateTime("2/2/2030"),Active=true},
                  new MenuItem(){Id=3,Name="pizza2",freeDelivery=true,Price=400,dateOfLaunch=Convert.ToDateTime("1/2/2030"),Active=false}
            };
        }
        [HttpGet]
        public ActionResult<List<MenuItem>> Get()
        {
            
            return menuItems;
        }
        [HttpGet("id")]
        public ActionResult<MenuItem> GetById(int id)
        {
            var i2=menuItems.FirstOrDefault(mi => mi.Id == id);
            return i2;
        }
    }
}
