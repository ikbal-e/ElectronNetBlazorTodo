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

        public LiteDBContext(string fileName)
        {
            var db = new LiteDatabase(@$"{fileName}.db");
            Context = db;
        }
    }
}
