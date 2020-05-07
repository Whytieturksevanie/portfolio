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
    public partial class CircleCalculatorForm : Form
    {
        double parsedValue;

        public CircleCalculatorForm()
        {
            InitializeComponent();
        }

        private void squarePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SquareCalculatorForm squarecalculatorform = new SquareCalculatorForm();
            squarecalculatorform.ShowDialog();
        }

        private void rectanglePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RectangleCalculatorForm rectanglecalculatorform = new RectangleCalculatorForm();
            rectanglecalculatorform.ShowDialog();
        }

        private void trianglePagebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RightAngledTriangleCalculatorForm rightangledtrianglecalculatorForm = new RightAngledTriangleCalculatorForm();
            rightangledtrianglecalculatorForm.ShowDialog();
        }

        private void circleOutlineButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(circleoutlineTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else
            {
                double circleoutline = double.Parse(circleoutlineTextBox.Text) * 3.141592653589793;
                circleOutlineLabel.Text = circleoutline.ToString();
            }
        }

        private void circleTwoOutlineButton_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(circleOutlineTwoTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else if (!double.TryParse(circleOutlineThreeTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else
            {
                double circletwooutline = double.Parse(circleOutlineTwoTextBox.Text) + double.Parse(circleOutlineThreeTextBox.Text) * 3.141592653589793;
                circleTwolabel.Text = circletwooutline.ToString();
            }
        }

        private void circleAreaButton_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(circleAreaTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else if (!double.TryParse(circleAreaTwoTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else
            {
                double circlearea = double.Parse(circleAreaTextBox.Text) * double.Parse(circleAreaTwoTextBox.Text) * 3.141592653589793;
                circleAreaLabel.Text = circlearea.ToString();
            }
        }
    }
}
