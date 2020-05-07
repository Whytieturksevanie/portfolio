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
    public partial class RectangleCalculatorForm : Form
    {
        double parsedValue;

        public RectangleCalculatorForm()
        {
            InitializeComponent();
        }

        private void rectangleOutlineButton_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(rectangleOutlineTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else if (!double.TryParse(rectangleTwoOutlineTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else
            {
                double rectangleoutline = double.Parse(rectangleOutlineTextBox.Text) + double.Parse(rectangleTwoOutlineTextBox.Text) * 2;
                rectangleOutlineLabel.Text = rectangleoutline.ToString();
            }
        }

        private void rectangleAreaButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(rectangleAreaTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else if (!double.TryParse(rectangleTwoAreaTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Typ alleen cijfers");
            }
            else
            {
                int rectanglearea = int.Parse(rectangleAreaTextBox.Text) * int.Parse(rectangleTwoAreaTextBox.Text);
                rectangleAreaLabel.Text = rectanglearea.ToString();
            }
        }

        private void squarePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SquareCalculatorForm squarecalculatorform = new SquareCalculatorForm();
            squarecalculatorform.ShowDialog();
        }

        private void trianglePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RightAngledTriangleCalculatorForm rightangledtrianglecalculatorForm = new RightAngledTriangleCalculatorForm();
            rightangledtrianglecalculatorForm.ShowDialog();
        }

        private void cirlePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CircleCalculatorForm circlecalculatorform = new CircleCalculatorForm();
            circlecalculatorform.ShowDialog();
        }
    }
}
