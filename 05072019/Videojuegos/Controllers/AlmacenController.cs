using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Videojuegos.Models;

namespace Videojuegos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideojuegosController : ControllerBase
    {
        private Almacen almacen = Almacen.Instance;

        public VideojuegosController()
        {
            Console.WriteLine("hola");
        }

        public List<Videojuegos> GetVideojuegos()
        {
            return this.almacen.Videojuegos;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Videojuegos Get(int anyo)
        {
            return Almacen.Videojuegos.Find(Videojuegos => Videojuegos.anyo == anyo);
        }
    }
}