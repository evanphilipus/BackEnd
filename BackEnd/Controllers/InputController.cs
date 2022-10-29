using BackEnd.Models;
using BackEnd.SQL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class InputController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public InputController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<ms_storage_location> GetLocation()
        {
            IEnumerable<ms_storage_location> Location = _db.ms_storage_location;
            return Location;

            //return new string[] { "get", "test" };
        }
    }
}
