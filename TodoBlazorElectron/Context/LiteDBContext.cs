using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoBlazorElectron.Context
{
    public class LiteDBContext
    {
        public readonly LiteDatabase Context;
        public LiteDBContext()
        {
            var db = new LiteDatabase(@"ToDoData.db");
            Context = db;
        }
    }
}
