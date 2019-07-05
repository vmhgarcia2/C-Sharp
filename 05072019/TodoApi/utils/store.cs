using System.Collections.Generic;
using TodoApi.Models;
using TodoApi.Controllers;

namespace TodoApi.utils
 {
    
        public sealed class Store
        {
            private readonly static Store _instance = new Store();
            public List<ToDoItem> todos = new List<ToDoItem>();

            public Store() { }

            public static Store Instance
            {
                get
                {
                    return _instance;
                }
            }
        }
    
}