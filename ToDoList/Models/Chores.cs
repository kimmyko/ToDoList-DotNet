using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Controllers;

namespace ToDoList.Models
{
    public class Chores
    {
        public string Item;

        public static void Create(string itemName)
        {
            var chore = new Chores();
            chore.Item = itemName;
            if (GlobalVariables.Chores == null)
                GlobalVariables.Chores = new List<Chores>();
            GlobalVariables.Chores.Add(chore);
        }

        public static List<Chores> GetAll()
        {
            if (GlobalVariables.Chores == null)
                GlobalVariables.Chores = new List<Chores>();
            return GlobalVariables.Chores;
        }
    }
}
