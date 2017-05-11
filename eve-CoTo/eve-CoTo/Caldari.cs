using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eve_CoTo
{
    class Caldari : Component
    {
        public Component comp;
        public List<Component> ComponentList = new List<Component>();

        //Constructor
        public Caldari()
        {
            //adding a new Component with name & race
            comp = new Component { Name = "titanium_diborite_armor_plates", Race = "caldari" };
            //adding the name & amount of materials
            comp.AddToList("titanium_carbide", 39);
            comp.AddToList("sylramic_fibers", 9.9);
            //adding the component to the componentlist
            ComponentList.Add(comp);





        }
    }
}
