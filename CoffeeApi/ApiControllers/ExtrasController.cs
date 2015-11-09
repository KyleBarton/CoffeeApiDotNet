using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using CoffeeApi.DataAccess;
using CoffeeApi.Models.MenuModels;

//TODO: Make a generic MenuItemController that can handle a drink or an extra, and then map on appstart somehow
namespace CoffeeApi.ApiControllers
{
    public interface IExtrasController
    {
        //Extras
        [HttpGet]
        List<Extra> GetAllExtras();

        [HttpPost]
        Extra AddExtra(Extra extraToAdd);

        //Extras/{ExtraId}
        [HttpGet]
        Extra GetExtra(int extraId);

        [HttpPut]
        Extra ChangeExtra(int extraId, Extra newExtra);

        [HttpDelete]
        void DeleteExtra(int extraId);
    }

    public class ExtrasController : ApiController, IExtrasController
    {
        private readonly IExtraRepository _extraRepository;

        public ExtrasController() : this(new ExtraRepository()) { }

        private ExtrasController(IExtraRepository extraRepository)
        {
            _extraRepository = extraRepository;
        }

        [HttpGet]
        public List<Extra> GetAllExtras()
        {
            try
            {
                return _extraRepository.GetAllExtras();
            }
            catch (Exception ex)
            {
                //TODO. handle gracefully. Log.
                throw;
            }
        }

        [HttpPost]
        public Extra AddExtra(Extra extraToAdd)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            try
            {
                return _extraRepository.AddExtra(extraToAdd);
            }
            catch (Exception ex)
            {
                //TODO. handle gracefully. Log.
                throw;
            }
        }

        [HttpGet]
        public Extra GetExtra(int extraId)
        {
            try
            {
                return _extraRepository.GetExtraById(extraId);
            }
            catch
            {
                //Todo: handle gracefully. Log
                throw;
            }
        }

        [HttpPut]
        public Extra ChangeExtra(int extraId, Extra newExtra)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            try
            {
                if (_extraRepository.GetExtraById(extraId) == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NoContent);
                }
                return _extraRepository.ChangeExtra(extraId, newExtra);
            }
            catch (Exception ex)
            {
                //TODO: handle gracefully. Log
                throw;
            }
        }

        [HttpDelete]
        public void DeleteExtra(int extraId)
        {
            try
            {
                if (_extraRepository.GetExtraById(extraId) == null)
                {
                    throw new HttpResponseException(HttpStatusCode.NoContent);
                }
                _extraRepository.DeleteExtra(extraId);
            }
            catch (Exception ex)
            {
                //TODO: handle gracefully. Log
                throw;
            }
        }
    }
}