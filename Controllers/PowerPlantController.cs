using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using IgnitisHomework.Models;
using IgnitisHomework.Data;
using IgnitisHomework.DTOs;

namespace IgnitisHomework.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PowerPlantController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PowerPlantController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var plants = _context.PowerPlants
                                 .Select(plant => DTOs.PowerPlantDto.FromEntity(plant))
                                 .ToList();

            var wrapper = new PowerPlantsWrapperDto { PowerPlants = plants };

            return Ok(wrapper);
        }
    }
}
