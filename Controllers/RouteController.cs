using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CHRobinsonWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CHRobinsonWebAPI.Controllers
{
    [ApiController]
    [Route("/")]
    
    public class RouteController : ControllerBase
    {
        // GET: api/BLZ
        [HttpGet("{destination}")]
        public List<string> Get(string destination)
        {
            // run the search and return list
            BFSearch search = new BFSearch();
            return search.goTo(destination);
        }

        // GET api/
        [HttpGet]
        public string Get()
        {
            return "Add \"/{country}\" for results";
        }
    }
}
