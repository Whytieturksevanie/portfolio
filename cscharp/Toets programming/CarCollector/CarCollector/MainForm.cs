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
    public partial class MainForm : Form
    {
        public string[][] carDescription = new string[3][]
        {
            new string[] {"Ik bezit deze auto niet", "Ik bezit deze auto niet", "Ik bezit deze auto niet", "Ik bezit deze auto niet"},
            new string[] {"Ik bezit deze auto niet", "Ik bezit deze auto niet", "Ik bezit deze auto niet"},
            new string[] {"Ik bezit deze auto niet", "Ik bezit deze auto niet", "Ik bezit deze auto niet"}
        };

        string[][] carModels = new string[3][]
        {
            new string[] {"Chevrolet", "SS", "Impala", "Camaro", "Corvette" },
            new string[] {"Jaguar", "XJS", "XK 140", "Mark II"},
            new string[] {"Lotus", "Espirit", "Elise", "Evora"}
        };

        public MainForm()
        {
            InitializeComponent();
        }

        public void SetLabelText(string text)
        {
            descriptionLabelTwo.Text = text;
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AddCar addcar = new AddCar(this);
           addcar.ShowDialog();
        }

        private void brandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // (brandListBox.SelectedIndex); //

            modelListBox.Items.Clear();

            //System.Diagnostics.Debug.WriteLine(brandListBox.SelectedIndex);

            for (int i = 1; i < carModels[brandListBox.SelectedIndex].Length; i++)
            {
                modelListBox.Items.Add(carModels[brandListBox.SelectedIndex][i]);
            }

            /* switch (brandListBox.SelectedIndex) 
            {
                case 2:
                    modelListBox.Items.Add("Espirit");
                    modelListBox.Items.Add("Elise");
                    modelListBox.Items.Add("Evora");
                    break;
                case 1:
                    modelListBox.Items.Add("XJS");
                    modelListBox.Items.Add("XK 140");
                    modelListBox.Items.Add("Mark II");
                    break;
                case 0:
                    modelListBox.Items.Add("SS");
                    modelListBox.Items.Add("Impala");
                    modelListBox.Items.Add("Camaro");
                    modelListBox.Items.Add("Corvette");
                    break;
            }
            */
        }

        internal void SetCarDescription(int brandindex, int modelindex, string text)
        {
            carDescription[brandindex][modelindex] = text;

            SetlabelDesctrition();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {   /*
            brandListBox.Items.Add("Chevrolet");
            brandListBox.Items.Add("Jaguar");
            brandListBox.Items.Add("Lotus");
            */

            for (int i = 0; i < carModels.Length; i++)
            {
                brandListBox.Items.Add(carModels[i][0]);
            }
        }

        private void modelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine( modelListBox.SelectedIndex);

            SetlabelDesctrition();
        }

        private void SetlabelDesctrition()
        {
            if (modelListBox.SelectedItems != null && modelListBox.SelectedIndex != -1)
            {
                descriptionLabelTwo.Text = carDescription[brandListBox.SelectedIndex][modelListBox.SelectedIndex];
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Deze code heb ik van deze link:https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form vandaan gehaald en de namen verandert//
            this.Hide();
            var mainform = new MainForm();
            mainform.Closed += (s, args) => this.Close();
        }
    }
}