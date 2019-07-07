using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideojuegosApi.Models;
using VideojuegosApi.utils;

namespace VideojuegosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideojuegosController:ControllerBase
    {        
        private Almacen almacen = Almacen.Instance;

        public VideojuegosController()
        {
        }

        //LISTADO TOTAL
        [HttpGet]
        public List<VideojuegosItem> getVideojuegositems()
        {
            return this.almacen.bibliotecaVideojuegos;
        }

        //Detalle por id
        [HttpGet("{id}")]
        public VideojuegosItem getVideojuegosPorId(int id){            
            return this.almacen.bibliotecaVideojuegos.Find(VideojuegosItem =>VideojuegosItem.id == id);
        }

        [HttpPost]
        public VideojuegosItem PostTodo(VideojuegosItem item)
        {
            item.id=1;
            item.anyoLanzamiento=item.anyoLanzamiento;
            this.almacen.bibliotecaVideojuegos.Add(item);
            return item;
        }

        public List<VideojuegosItem> GetVideojuegos()
        {
            return this.almacen.bibliotecaVideojuegos;
        }

        // GET api/values/2009
        [HttpGet("/anyo/{anyo}")]
        public List<VideojuegosItem> obtener(int anyo)
        {
            System.Console.WriteLine(anyo);
            return almacen.bibliotecaVideojuegos.FindAll(VideojuegosItem=>VideojuegosItem.anyoLanzamiento==anyo);
        }
    }
}