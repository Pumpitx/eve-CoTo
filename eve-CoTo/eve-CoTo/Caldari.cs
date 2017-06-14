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
        private const string race = "Caldari";

        //Constructor
        public Caldari()
        {

        }


        /// <summary>
        /// Adds a new Component with amount of Materials to the list 
        /// </summary>
        /// <param name="compname">Name of the new Component.</param>
        /// <param name="firstmatname">Name of the first Material.</param>
        /// <param name="firstmatamount">Amount of the first Material.</param>
        /// <param name="secondmatname">Name of the second Material.</param>
        /// <param name="secondmatamount">Amount of the second Material.</param>
        /// <param name="thirdmatname">Name of the second Material.</param>
        /// <param name="thirdmatamount">Amount of the second Material.</param>
        /// <param name="fourthmatname">Name of the fourth Material.</param>
        /// <param name="fourthmatamount">Amount of the fourth Material.</param>
        private void AddComponentToList(string compname, string firstmatname, double firstmatamount, string secondmatname, double secondmatamount, string thirdmatname = "null", double thirdmatamount = 0, string fourthmatname = "null", double fourthmatamount = 0)
        {
            //adding a new Component with name & race
            comp = new Component { Name = compname };
            //adding the name & amount of materials
            comp.AddToList(firstmatname, firstmatamount);
            comp.AddToList(secondmatname, secondmatamount);

            //Checking if input parameters are empty
            if (!thirdmatname.Contains("null"))
            {
                comp.AddToList(thirdmatname, thirdmatamount);
            }

            if(!fourthmatname.Contains("null"))
            {
                comp.AddToList(fourthmatname, fourthmatamount);
            }

            //adding the component to the componentlist
            ComponentList.Add(comp);
        }
    }
}
