using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDo.Models
{
    public class ToDoItem
    {
        public string Name { get; set; }
        public bool Complete { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Created { get; set; }
        public bool Postponed { get; set; }
    }
}
