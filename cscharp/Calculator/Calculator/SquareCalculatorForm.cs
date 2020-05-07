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
    public partial class SquareCalculatorForm : Form
    {
        double parsedValue;

        public SquareCalculatorForm()
        {
            InitializeComponent();
        }

        private void squareOutlineButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(squareOutlineTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Vergeet niet om de veld in te vulllen");
            }
            else
            {
                double squareoutline = double.Parse(squareOutlineTextBox.Text) * 4;
                squareOutlineLabel.Text = squareoutline.ToString();
            }
        }

        private void squareAreaButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(squareAreaTextBox.Text, out parsedValue))
            {
                MessageBox.Show("vergeet niet om de cijfers typen");
            }
            else
            {
                double squarearea = double.Parse(squareAreaTextBox.Text) * 2;
                squareAreaLabel.Text = squarearea.ToString();
            }
        }

        private void rectanglePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RectangleCalculatorForm rectanglecalculatorform = new RectangleCalculatorForm();
            rectanglecalculatorform.ShowDialog();
        }

        private void circlePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CircleCalculatorForm circlecalculatorform = new CircleCalculatorForm();
            circlecalculatorform.ShowDialog();
        }

        private void trianglePageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RightAngledTriangleCalculatorForm rightangledtrianglecalculatorForm = new RightAngledTriangleCalculatorForm();
            rightangledtrianglecalculatorForm.ShowDialog();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            squareOutlineTextBox.Top -= 10;
        }
    }
}
