using System;
using System.Collections.Generic;
using CoffeeApi.Models.MenuModels;

namespace CoffeeApi.DataAccess
{
    internal interface IDrinkRepository
    {
        List<Drink> GetDrinks();
        Drink GetDrinkById(int drinkId);
        Drink AddDrink(Drink drinkToAdd);
        Drink ChangeDrink(int drinkId, Drink drinkToChange);
        void DeleteDrink(int drinkId);
    }

    internal class DrinkRepository : IDrinkRepository
    {
        public List<Drink> GetDrinks()
        {
            throw new NotImplementedException();
        }

        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }

        public Drink AddDrink(Drink drinkToAdd)
        {
            throw new NotImplementedException();
        }

        public Drink ChangeDrink(int drinkId, Drink drinkToChange)
        {
            throw new NotImplementedException();
        }

        public void DeleteDrink(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}