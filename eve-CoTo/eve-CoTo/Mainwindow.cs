using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
   
namespace eve_CoTo
{
    public partial class Mainwindow : Form
    {
        //Xml file path
        string path = "D:\\Visual Studio Projekte\\eve-CoTo\\eve-CoTo\\bin\\Debug\\Component.xml";
        //Init of the componentlist
        List<Component> comp = new List<Component>();

        public Mainwindow()
        {
            InitializeComponent();
        }

        public void GetComponentByName(string input)
        {

        }

        public void ReadXmlFile()
        {
            //init of xmltextreader
            XmlTextReader reader = new XmlTextReader("D:\\Visual Studio Projekte\\eve-CoTo\\eve-CoTo\\bin\\Debug\\Component.xml");

            if(reader == null)
            {
                MessageBox.Show("Failed to find component.xml.");
            }

            //temp string for race
            string race = String.Empty;
            //temp bool for component names
            bool isNewComponent = false;
            //temp string for component name
            string Component_Name = String.Empty;
            

            while (reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.Element:
                        //find out which race the component ist
                        if(reader.Name.Equals("caldari") | reader.Name.Equals("gallente") | reader.Name.Equals("minmatar") | reader.Name.Equals("amarr"))
                        {
                            race = reader.Name;
                        }
                        else
                        {
                            //Adding the component to list
                            comp.Add(new Component() { name = Convert.ToString(XmlNodeType.Element) });
                            isNewComponent = true;
                            Component_Name = Convert.ToString(XmlNodeType.Element);
                        }
                        break;

                    case XmlNodeType.Text:
                        if (isNewComponent == true)
                        {
                            Component found = comp.Find(x => x.name.Equals(Component_Name));

                            if(found != null)
                            {
                                found.MaterialNeeded.Add(new Material { name = reader.Name, amount = Int32.Parse(reader.Value) });
                            }
                        }

                        break;

                    case XmlNodeType.EndElement:
                        isNewComponent = false;
                        break;
                }
            }
        }
    }
}
