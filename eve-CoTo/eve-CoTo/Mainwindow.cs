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


        public void GetComponentByName(string input, string race)
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
