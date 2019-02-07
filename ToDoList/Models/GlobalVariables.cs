using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Controllers;

namespace ToDoList.Models
{
    public static class GlobalVariables
    {
        public static List<ToDoList.Models.Chores> Chores { get; set; } = new List<Chores>();
    }
}
