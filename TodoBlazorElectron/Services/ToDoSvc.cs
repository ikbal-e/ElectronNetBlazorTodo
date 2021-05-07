using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TodoBlazorElectron.Context;
using TodoBlazorElectron.Entities;

namespace TodoBlazorElectron.Services
{
    public class ToDoSvc : IToDoSvc
    {
        private readonly LiteDatabase _liteDb;
        public ToDoSvc(LiteDBContext context)
        {
            _liteDb = context.Context;
        }
        public void Add(ToDo todoDto)
        {
            var todos = _liteDb.GetCollection<ToDo>("todos");

            var todo = new ToDo
            {
                Description = todoDto.Description,
                Deadline = todoDto.Deadline
            };

            todos.Insert(todo);
        }

        public List<ToDo> Get(Expression<Func<ToDo, bool>> predicate = null)
        {
            var todos = predicate is null 
                ?_liteDb.GetCollection<ToDo>("todos").FindAll().ToList()
                :_liteDb.GetCollection<ToDo>("todos").Find(predicate).ToList();

            return todos;
        }
    }
}
