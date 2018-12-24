using System;
using System.Drawing;
using System.Windows.Forms;


namespace DrawingPanel
{
    public partial class fmDrawing : Form
    {
        private Color SelecteColor;
        private int SelectedSize;

        private Brush brushColor = Brushes.Black;

        bool shouldPaint { get; set; } = false;

        public fmDrawing()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            SelectedSize = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SelecteColor = Color.Red;
        }

        private void rdBlue_CheckedChanged(object sender, EventArgs e)
        {
            SelecteColor = Color.Blue;
        }

        private void rdGreen_CheckedChanged(object sender, EventArgs e)
        {
            SelecteColor = Color.Green;
        }

        private void rdBlack_CheckedChanged(object sender, EventArgs e)
        {
            SelecteColor = Color.Black;
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            SelectedSize = 10;
        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            SelectedSize = 15;
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics graphics = drawingPanel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(SelecteColor), e.X, e.Y, SelectedSize, SelectedSize);
                }

            }
        }
    }
}
