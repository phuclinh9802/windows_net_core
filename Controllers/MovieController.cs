using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using practice.Context;
using practice.Models;

namespace practice.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    public class MovieController : Controller
    {
        private readonly MovieContext _context;
        public MovieController(MovieContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var movies = _context.Movies.ToList();
                return Ok(movies);
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error: {e.Message}");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            if (movie != null)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(Guid? id)
        {
            var name = _context.Movies.Find(id);
            
            if (ModelState.IsValid)
            {
                _context.Movies.Remove(name);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();

        }
    }
}