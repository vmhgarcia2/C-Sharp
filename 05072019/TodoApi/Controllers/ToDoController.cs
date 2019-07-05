
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.utils;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private Store store = Store.Instance;

        public ToDoController()
        {
        
        }

        [HttpGet]
        public List<ToDoItem> getTodoItems()
        {
            return this.store.todos;
        }

        [HttpPost]
        public ToDoItem PostTodo(ToDoItem item)
        {
            item.Id = this.store.todos.Count;
            this.store.todos.Add(item);
            return item;
        }

        //GET: api/Todo/5
        [HttpGet("{id}")]
        public ToDoItem buscar(int id)
        {
            return this.store.todos.Find(ToDoItem =>
            {
                Console.WriteLine(ToDoItem.Id);
                return ToDoItem.Id == id;
            });
        }

        //GET: api/Todo/busqueda/<palabra>
        [HttpGet("busqueda/{cadena}")]
        public List<ToDoItem> buscar(string cadena)
        {
            return this.store.todos.FindAll(ToDoItem => ToDoItem.Name.Contains(cadena));
        }
        //GET: api/Todo/DONE
        [HttpGet("DONE")]
        public List<ToDoItem> buscarCompletos(string cadena)
        {
            return this.store.todos.FindAll(ToDoItem => ToDoItem.isComplete);
        }

        //Devuelve elemento modificado
        [HttpPatch("DONE/{id}")]
        public ToDoItem marcarCompletado(int id)
        {
            int indice=this.store.todos.FindIndex(ToDoItem =>ToDoItem.Id==id);
            this.store.todos[indice].isComplete=true;
            return this.store.todos[indice];
        }

        [HttpDelete("{id}")]
        public void borrarElemento(int id){
            this.store.todos.RemoveAt(id);
        }
    }
}