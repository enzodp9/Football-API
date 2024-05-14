using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pruebas.Data;
using Pruebas.Models;
using Pruebas.Services;
using Pruebas.Services.DTOs;
using System;
using System.Net.Http.Headers;

namespace Pruebas.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FootballController : ControllerBase

    {
        private readonly FootballServices _footballServices;

        public FootballController(FootballServices footballServices)
        {
            _footballServices = footballServices;
        }

        [HttpGet]
        public async Task Initialize()
        {
            await _footballServices.PoblateDatabase();
        }



    }

}
