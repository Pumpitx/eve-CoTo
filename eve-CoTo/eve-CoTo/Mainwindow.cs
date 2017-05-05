using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
   
namespace eve_CoTo
{
    public partial class Mainwindow : Form
    {
        //creating variables for the paths of the XML files
        string pathCaldari = String.Empty;
        string pathMinmatar = String.Empty;
        string pathGallente = String.Empty;
        string pathAmarr = String.Empty;

        //Init of the componentlist
        List<Component> comp = new List<Component>();
        //private string for choosed race
        private string race = String.Empty;

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

        }

        public bool CheckXmlFiles()
        {
            //All Component paths are temporary
            pathAmarr = "D:\\Visual Studio Projekte\\eve-CoTo\\eve-CoTo\\eve-CoTo\\bin\\Debug\\Minmatar_Components.xml";
            pathCaldari = "D:\\Visual Studio Projekte\\eve - CoTo\\eve - CoTo\\eve - CoTo\\bin\\Debug\\Caldari_Components.xml";
            pathGallente = "D:\\Visual Studio Projekte\\eve-CoTo\\eve-CoTo\\eve-CoTo\\bin\\Debug\\Gallente_Components.xml";
            pathMinmatar = "D:\\Visual Studio Projekte\\eve-CoTo\\eve-CoTo\\eve-CoTo\\bin\\Debug\\Minmatar_Components.xml";

            //checking if files are existing and permissions are valid
            if(File.Exists(pathAmarr) && File.Exists(pathCaldari) && File.Exists(pathGallente) && File.Exists(pathMinmatar))
            {
                return true;
            }
            else
            {
                //return a message box if the files are invalid and return false
                MessageBox.Show("Error! Component Files are not found or wrong permissions!, Error!");
                return false;
            }
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

        public void ReadXmlFile(string race)
        {
            string path = String.Empty;

            switch(race)
            {
                case "amarr":
                    path = pathAmarr;
                    break;
                case "caldari":
                    path = pathCaldari;
                    break;
                case "gallente":
                    path = pathGallente;
                    break;
                case "minmatar":
                    path = pathMinmatar;
                    break;
            }

            //init of XmlTextReader with path of Race
            XmlTextReader reader = new XmlTextReader(path);
            //temp string for component name to find it in the list
            string Component_Name = String.Empty;
            
            //reading the xml file
            while (reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.Element:
                            //adding the new component to the list
                            comp.Add(new Component() { Name = Convert.ToString(reader.Name),Race = this.race});
                            Component_Name = Convert.ToString(reader.Name);                        
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
