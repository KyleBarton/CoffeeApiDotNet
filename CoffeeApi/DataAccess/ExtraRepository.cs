using System.Collections.Generic;
using CoffeeApi.Models.MenuModels;

namespace CoffeeApi.DataAccess
{
    internal interface IExtraRepository
    {
        List<Extra> GetAllExtras();
        Extra AddExtra(Extra extraToAdd);
        Extra GetExtraById(int extraId);
        Extra ChangeExtra(int extraId, Extra newExtra);
        void DeleteExtra(int extraId);
    }

    internal class ExtraRepository : IExtraRepository
    {
        public List<Extra> GetAllExtras()
        {
            throw new System.NotImplementedException();
        }

        public Extra AddExtra(Extra extraToAdd)
        {
            throw new System.NotImplementedException();
        }

        public Extra GetExtraById(int extraId)
        {
            throw new System.NotImplementedException();
        }

        public Extra ChangeExtra(int extraId, Extra newExtra)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteExtra(int extraId)
        {
            throw new System.NotImplementedException();
        }
    }
}