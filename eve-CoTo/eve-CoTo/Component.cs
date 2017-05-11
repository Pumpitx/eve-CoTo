using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eve_CoTo
{
    class Component
    {

        //Properties
        public string Name { get; set; }
        public string Race { get; set; }

        //List
        public List<Material> MaterialNeeded = new List<Material>();

        public void AddToList(string name, double amount)
        {
            this.MaterialNeeded.Add(new Material { Name = name, Amount = amount });
        }

        
    }
}
