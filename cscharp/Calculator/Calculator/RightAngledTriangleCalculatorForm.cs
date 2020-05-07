using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class RightAngledTriangleCalculatorForm : Form
    {
        double parsedValue;

        public RightAngledTriangleCalculatorForm()
        {
            InitializeComponent();
        }

        private void squarePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SquareCalculatorForm squarecalculatorform = new SquareCalculatorForm();
            squarecalculatorform.ShowDialog();
        }

        private void circlePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CircleCalculatorForm circlecalculatorform = new CircleCalculatorForm();
            circlecalculatorform.ShowDialog();
        }

        private void triangleOutlineButton_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(triangleOutlineTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else if (!double.TryParse(triangleOutlineTwoTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else if (!double.TryParse(triangleOutlineThreeTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else
            {
                double triangleoutline = double.Parse(triangleOutlineTextBox.Text) + double.Parse(triangleOutlineTwoTextBox.Text) + double.Parse(triangleOutlineThreeTextBox.Text);
                triangleOutlineLabel.Text = triangleoutline.ToString();
            }
        }

        private void triangleAreaButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(triangleAreaTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else
            {
                double trianglearea = double.Parse(triangleAreaTextBox.Text) * double.Parse(triangleAreaTwoTextBox.Text) / 2;
                triangleAreaLabel.Text = trianglearea.ToString();
            }   
        }
    }
}
