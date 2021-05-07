using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TodoBlazorElectron.Entities;

namespace TodoBlazorElectron.Services
{
    public interface IToDoSvc
    {
        void Add(ToDo todoDto);
        List<ToDo> Get(Expression<Func<ToDo, bool>> predicate = null);
    }
}