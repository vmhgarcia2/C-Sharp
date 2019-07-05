
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
    public class ToDoController: ControllerBase
    {
            private Store store=Store.Instance;

            public ToDoController(){
                Console.WriteLine("Cantidad:" +  store.todos.Count);
            }

            [HttpGet]
            public List<ToDoItem> getTodoItems(){
                return this.store.todos;
            }

            [HttpPost]
            public ToDoItem PostTodo(ToDoItem item){
                this.store.todos.Add(item);
                return item;
            }


    }
}