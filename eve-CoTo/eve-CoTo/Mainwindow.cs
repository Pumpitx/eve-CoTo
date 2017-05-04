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
        //Xml file path --> temporary
        string path = "D:\\Visual Studio Projekte\\eve-CoTo\\eve-CoTo\\eve-CoTo\\bin\\Debug\\Components.xml";
        //Init of the componentlist
        List<Component> comp = new List<Component>();
        //private string for choosed race
        string race = String.Empty;

        public Mainwindow()
        {
            InitializeComponent();

            labelIntro.ForeColor = Color.Red;
            //hiding the component box
            BoxComponents.Visible = false;
            //hiding AddComponent button
            buttonAdd.Visible = false;
            //hiding component combobox
            comboComponent.Visible = false;

            ReadXmlFile();
            

        }

        public void GetComponentByName(string input)
        {
            //find input in list
            var result = comp.Find(x => x.Name.Equals(input));

            if (result != null)
            {

            }
            else
            {
                //for debug
                MessageBox.Show("ComponentName not found!");
            }
            
        }

        public void ReadXmlFile()
        {
            //init of xmltextreader
            XmlTextReader reader = new XmlTextReader(path);

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
            
            //reading the xml file
            while (reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.Element:
                        //set the race the component is
                     if(reader.Name.Equals("caldari") | reader.Name.Equals("gallente") | reader.Name.Equals("minmatar") | reader.Name.Equals("amarr"))
                        {
                            race = reader.Name;
                        }
                        //else
                        {
                            //Adding the component to list
                            comp.Add(new Component() { Name = Convert.ToString(reader.Name),Race = this.race });
                            isNewComponent = true;
                            Component_Name = Convert.ToString(reader.Name);
                        }
                        break;

                    case XmlNodeType.Text:
                        if (isNewComponent == true)
                        {
                            Component found = comp.Find(x => x.Name.Equals(Component_Name));

                            if(found != null)
                            {
                                found.MaterialNeeded.Add(new Material { Name = reader.Name, Amount = float.Parse(reader.Value) });
                            }
                        }

                        break;

                    case XmlNodeType.EndElement:
                        isNewComponent = false;
                        break;
                }
            }
        }

        private void ActivateGUI()
        {
            comboComponent.Visible = true;
            buttonAdd.Visible = true;
            BoxComponents.Visible = true;
            labelIntro.Visible = false;
        }

        private void FillComboBox()
        {
            foreach(Component tempComp in comp)
            {
                if (tempComp.Race == race)
                {
                    comboComponent.Items.Add(tempComp.Name);
                }
            }
        }

        private void radioCaldari_CheckedChanged(object sender, EventArgs e)
        {
            if(radioCaldari.Checked)
            {
                race = "caldari";
            }
            ActivateGUI();
            FillComboBox();
        }

        private void radioGallente_CheckedChanged(object sender, EventArgs e)
        {
            if(radioGallente.Checked)
            {
                race = "gallente";
            }
            ActivateGUI();
            FillComboBox();
        }

        private void radioMinmatar_CheckedChanged(object sender, EventArgs e)
        {
             if(radioMinmatar.Checked)
            {
                race = "minmatar";
            }
            ActivateGUI();
            FillComboBox();

        }

        private void radioAmarr_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAmarr.Checked)
            {
                race = "amarr";
            }
            ActivateGUI();
            FillComboBox();
        }
    }
}
