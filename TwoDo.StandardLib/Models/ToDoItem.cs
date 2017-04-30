using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDo.StandardLib.Models
{
  public class ToDoItem
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Complete { get; set; }
    public DateTime Expires { get; set; }
    public DateTime Created { get; set; }
    public bool Postponed { get; set; }
  }
}
