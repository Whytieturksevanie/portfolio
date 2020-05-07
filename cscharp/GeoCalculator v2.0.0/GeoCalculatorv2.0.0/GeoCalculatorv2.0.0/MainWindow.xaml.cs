using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeoCalculatorv2._0._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double parsedValue;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SquareButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(squareOutlineTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Vergeet niet de cijfers te typen.");
            }
            else if (squareOutlineTextBox.Text != "")
            {
                double squareoutline = double.Parse(squareOutlineTextBox.Text) * 2;
                squareOutlineLabel.Content = squareoutline;
            }
        }

        private void SquarAreaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(squareAreaTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Vergeet niet de cijfers te typen.");
            }
            else if (squareAreaTextBox.Text != "")
            {
                double squareArea = double.Parse(squareAreaTextBox.Text) * 4;
                squareAreaLabel.Content = squareArea;
            }
        }

        private void RectangleOutlineButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(rectangleOutlineTextBox.Text, out parsedValue) || !double.TryParse(rectangleWidthOutlineTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Vergeet niet de cijfers te typen.");
            }
            else if (rectangleOutlineTextBox.Text != "" && rectangleWidthOutlineTextBox.Text != "")
            {
                double rectangleoutline = double.Parse(rectangleOutlineTextBox.Text) * double.Parse(rectangleWidthOutlineTextBox.Text);
                rectangleOutlineLabel.Content = rectangleoutline;
            }
        }

        private void RectangleAreaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(rectangleAreaTextBox.Text, out parsedValue) && !double.TryParse(rectangleWithAreaTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Vergeet niet de cijfers te typen.");
            }
            else if (rectangleAreaTextBox.Text != "" && rectangleWithAreaTextBox.Text != "")
            {
                double rectanglearea = double.Parse(rectangleAreaTextBox.Text) * double.Parse(rectangleWithAreaTextBox.Text);
                rectangleAreaLabel.Content = rectanglearea;
            }
        }

        private void CircleOutlineButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(circleOutlineTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Vergeet niet de cijfers te typen.");
            }
            else if (circleOutlineTextBox.Text != "")
            {
                double circleOutline = double.Parse(circleOutlineTextBox.Text) * 3.14159265359;
                circleOutlineLabel.Content = circleOutline;
            }
        }

        private void CircleAreaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(circleAreaTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Vergeet niet de cijfers te typen.");
            }
            else if (circleAreaTextBox.Text != "")
            {
                double circlearea = double.Parse(circleAreaTextBox.Text) * double.Parse(circleAreaTextBox.Text) * 3.14159265359;
                circleAreaLabel.Content = circlearea;
            }
        }

        private void TraingleOutlineButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(traingleOutlineTextBox.Text, out parsedValue) || !double.TryParse(traingleWithOutlineTextBox.Text, out parsedValue) || !double.TryParse(traingleHeightOutlineTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Vergeet niet de cijfers te typen.");
            }
            else if (traingleOutlineTextBox.Text != "" && traingleWithOutlineTextBox.Text !="" && traingleHeightOutlineTextBox.Text != "")
            {
                double traingleoutline = double.Parse(traingleOutlineTextBox.Text) + double.Parse(traingleWithOutlineTextBox.Text) + double.Parse(traingleHeightOutlineTextBox.Text);
                traingleOutlineLabel.Content = traingleoutline;
            }
        }

        private void TraingleAreaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(traingleAreaTextBox.Text, out parsedValue) || !double.TryParse(traingleWithAreaTextBox.Text, out parsedValue))
            {
                MessageBox.Show("Vergeet niet de cijfers te typen.");
            }
            else if (traingleAreaTextBox.Text != "" && traingleWithAreaTextBox.Text != "")
            {
                double trainglearea = double.Parse(traingleAreaTextBox.Text) * double.Parse(traingleWithAreaTextBox.Text) / 2;
                traingleAreaLabel.Content = trainglearea;
            }
        }
    }
}
