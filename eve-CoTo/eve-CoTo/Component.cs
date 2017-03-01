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
        public string name { get; set; }
        public string race { get; set; }

        //List
        public List<Material> MaterialNeeded = new List<Material>();

        
    }
}
