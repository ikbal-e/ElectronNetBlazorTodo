using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoBlazorElectron.Entities
{
    public class ToDo
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? Deadline { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string Description { get; set; }
    }
}
