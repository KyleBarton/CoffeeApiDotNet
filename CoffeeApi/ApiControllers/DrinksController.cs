using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using CoffeeApi.DataAccess;
using CoffeeApi.Models.MenuModels;

namespace CoffeeApi.ApiControllers
{
    public interface IDrinksController
    {
        [HttpGet]
        List<Drink> GetAllDrinks();

        [HttpPost]
        Drink AddDrink(Drink drinkToAdd);

        [HttpGet]
        Drink GetDrink(int drinkId);

        [HttpPut]
        Drink ChangeDrink(int drinkId, Drink drinkToChange);

        [HttpDelete]
        void DeleteDrink(int drinkId);
    }

    public class DrinksController : ApiController, IDrinksController
    {
        private readonly IDrinkRepository _drinkRepository;

        public DrinksController() : this(new DrinkRepository()) { }

        private DrinksController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        [HttpGet]
        public List<Drink> GetAllDrinks()
        {
            try
            {
                return _drinkRepository.GetDrinks();
            }
            catch (Exception ex)
            {
                //TODO: Handle response to client more gracefully. Log.
                throw;
            }
        }

        [HttpPost]
        public Drink AddDrink(Drink drinkToAdd)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            try
            {
                return _drinkRepository.AddDrink(drinkToAdd);
            }
            catch (Exception ex)
            {
                //handle error gracefully. Have a rollback scenario ready. Log.
                throw;
            }
        }

        [HttpGet]
        public Drink GetDrink(int drinkId)
        {
            try
            {
                return _drinkRepository.GetDrinkById(drinkId);
            }
            catch (Exception ex)
            {
                //TODO: Handle reponse to client more gracefully. Log.
                throw;
            }
        }

        [HttpPut]
        public Drink ChangeDrink(int drinkId, Drink drinkToChange)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            try
            {
                if (_drinkRepository.GetDrinkById(drinkId) == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NoContent);
                }
                return _drinkRepository.ChangeDrink(drinkId, drinkToChange);
            }
            catch (Exception ex)
            {
                //Handle this gracefully or something. Log.
                throw;
            }
        }

        [HttpDelete]
        public void DeleteDrink(int drinkId)
        {
            try
            {
                if (_drinkRepository.GetDrinkById(drinkId) == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NoContent);
                }
                _drinkRepository.DeleteDrink(drinkId);
            }
            catch (Exception ex)
            {
                //TODO: handle gracefully. Log.
                throw;
            }
        }
    }
}