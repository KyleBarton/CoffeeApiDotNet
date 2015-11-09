using System;
using System.Collections.Generic;
using System.Web.Http;
using CoffeeApi.Models.MenuModels;

namespace CoffeeApi.ApiControllers
{
    public interface IMenuController
    {
        [HttpGet]
        Menu GetMenu();

        List<Drink> GetDrinks();

        List<Extra> GetExtras();


    }
    //going to punt on this one for a minute
    public class MenuController : ApiController, IMenuController
    {
        [HttpGet]
        public Menu GetMenu()
        {
            throw new NotImplementedException();
        }

        public List<Drink> GetDrinks()
        {
            //Call /Drinks as a service
            throw new NotImplementedException();
        }

        public List<Extra> GetExtras()
        {
            //Call /Extras as a service
            throw new NotImplementedException();
        }
    }
}