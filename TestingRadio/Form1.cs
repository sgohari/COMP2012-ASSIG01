using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
namespace TestingRadio
{
    public partial class TestDrawing : Form
    {
        private int diameter = (int)Sizes.MEDIUM; // set diameter of circle
        private Brush brushColor = Brushes.Black; // set the drawing color
        private bool shouldErase = false; // specify whether to erase
        private bool shouldPaint = false; // specify whether to paint
        public TestDrawing()
        {
            InitializeComponent();
        }
        private enum Sizes // constants for diameter of the circle
        {
            SMALL = 4,
            MEDIUM = 8,
            LARGE = 10
        } // end enum Sizes
        private void PaintCircle(Brush circleColor, Point position)
        {
            Ellipse newEllipse = new Ellipse(); // create an Ellipse   

            newEllipse.Fill = circleColor; // set Ellipse's color      
            newEllipse.Width = diameter; // set its horizontal diameter
            newEllipse.Height = diameter; // set its vertical diameter 

            // set the Ellipse's position            
            Canvas.SetTop(newEllipse, position.Y);
            Canvas.SetLeft(newEllipse, position.X);

            paintCanvas.Children.Add(newEllipse);
        } // end method PaintCircle

        private void rdRed_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Brushes.Red;
        }

        private void TestDrawing_Load(object sender, EventArgs e)
        {

        }

        private void paintCanvas_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void paintCanvas_MouseLeftButtonUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void paintCanvas_MouseRightButtonUp(object sender, EventArgs e)
        {
            shouldErase = false;
        }

        private void paintCanvas_MouseRightButtonDown(object sender, EventArgs e)
        {
            shouldPaint = true;
        }

        private void paintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                // draw a circle of selected color at current mouse position
                Point mousePosition = e.GetPosition(paintCanvas);
                PaintCircle(brushColor, mousePosition);
            } // end if
            else if (shouldErase)
            {
                // erase by drawing circles of the Canvas's background color
                Point mousePosition = e.GetPosition(paintCanvas);
                PaintCircle(paintCanvas.Background, mousePosition);
            }
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Brushes.Blue;

        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            brushColor = Brushes.Green;
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            brushColor=Brushes.Black;
        }
    }
}
