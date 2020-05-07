using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCollector
{
    public partial class AddCar : Form
    {
        public MainForm mainform;
        /*
        string[] chevrolet = new string[4]
        {
            "SS",
            "Impala",
            "Camaro",
            "Corvette"
        };

        string[] Jaguar = new string[3]
        {
            "XJS",
            "XK 140",
            "Mark II"
        };

        string[] Lotus = new string[3]
        {
            "Espirit",
            "Elise",
            "Evora"
        };
        */

        string[][] carModels = new string[3][]
        {
           new string[] {"Chevrolet", "SS", "Impala", "Camaro", "Corvette" },
           new string[] {"Jaguar", "XJS", "XK 140", "Mark II"},
           new string[] {"Lotus", "Espirit", "Elise", "Evora"}
        };

        public AddCar(MainForm mf)
        {
            InitializeComponent();
            mainform = mf;
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            /*
            brandComboBox.Items.Add("Chevrolet");
            brandComboBox.Items.Add("Jaguar");
            brandComboBox.Items.Add("Lotus");
            */

            for (int i = 0; i < carModels.Length; i++)
            {
                brandComboBox.Items.Add(carModels[i][0]);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(mainform.carDescription[brandComboBox.SelectedIndex][modelComboBox.SelectedIndex] != "Ik bezit deze auto niet")
            {
                MessageBox.Show("Je mag niet dezelfde auto toevoegen");
                return;
            }

            if (brandComboBox.SelectedItem != null && modelComboBox.SelectedItem != null && descriptionRichTextBox.Text != null)
            {
                mainform.SetCarDescription(brandComboBox.SelectedIndex, modelComboBox.SelectedIndex, descriptionRichTextBox.Text);
                this.Close();
            }
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelComboBox.Items.Clear();

            for (int i = 1; i < carModels[brandComboBox.SelectedIndex].Length; i++)
            {
                modelComboBox.Items.Add(carModels[brandComboBox.SelectedIndex][i]);
            }

            /*

            switch (brandComboBox.SelectedIndex)
            {
                case 2:
                    modelComboBox.Items.Add("Espirit");
                    modelComboBox.Items.Add("Elise");
                    modelComboBox.Items.Add("Evora");
                    break;
                case 1:
                    modelComboBox.Items.Add("XJS");
                    modelComboBox.Items.Add("XK 140");
                    modelComboBox.Items.Add("Mark II");
                    break;
                case 0:
                    modelComboBox.Items.Add("SS");
                    modelComboBox.Items.Add("Impala");
                    modelComboBox.Items.Add("Camaro");
                    modelComboBox.Items.Add("Corvette");
                    break;
            }

            */
        }
    }
}
