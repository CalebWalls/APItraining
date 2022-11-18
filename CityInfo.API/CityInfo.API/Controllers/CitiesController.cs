﻿using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {

        [HttpGet]
        public JsonResult GetCities()
        {
            

           return new JsonResult(CitiesDataStore.Current.Cities.OrderByDescending(c => c.Id));
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }

    }
}
