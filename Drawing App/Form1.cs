using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_App
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint;
        private Bitmap drawingBitmap;
        private Graphics drawingGraphics;
        public Form1()
        {
            InitializeComponent();
            InitializeDrawingComponents();
        }

        private void InitializeDrawingComponents()
        {
            drawingBitmap = new Bitmap(drawingPanel.Width, drawingPanel.Height);
            drawingGraphics = Graphics.FromImage(drawingBitmap);
            drawingGraphics.Clear(Color.White);
            drawingPanel.BackgroundImage = drawingBitmap;
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point endPoint = e.Location;
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    drawingGraphics.DrawLine(pen, startPoint, endPoint);
                }
                startPoint = endPoint;
                drawingPanel.Invalidate(); // Refresh the panel to show the drawing
            }
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }
    }
}
