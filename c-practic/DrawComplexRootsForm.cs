using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_practic
{
    public partial class DrawComplexRootsForm : Form
    {
        private readonly Pen _graphicPen = new Pen(Color.Black, 2);
        private readonly Pen _polygonPen = new Pen(Color.Black, 3);
        private readonly Pen _circlePen = new Pen(Color.Black, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
        private Complex[] ComplexRoots;
        private int ScalePixel = 100;
        private const int ScaleDiff = 10;
        private PointF[] ScaleCentredPoints => ComplexRoots?.Select(c => new PointF((float)c.Real * ScalePixel + (float)Width / 2,
            -1 * (float)c.Imaginary * ScalePixel + (float)Height / 2)).ToArray();

        private double CircleRadius
        {
            get
            {
                Complex? complex = ComplexRoots?.FirstOrDefault();
                if (complex == null)
                {
                    return 0;
                }
                return Math.Sqrt(Math.Pow(complex.Value.Real, 2) + Math.Pow(complex.Value.Imaginary, 2));
            }
        }
        public DrawComplexRootsForm()
        {
            InitializeComponent();
            this.MouseWheel += DrawComplexRootsForm_MouseWheel;
        }

        private void DrawComplexRootsForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                btnScaleDdecrease_Click(null, null);
            }
            else
            {
                btnScaleRise_Click(null, null);
            }
        }

        public DrawComplexRootsForm(Complex[] complexRoots, int scalePixel = 100, string title = "Полигон") : this()
        {
            ComplexRoots = complexRoots?.Length > 1 ? complexRoots : throw new ArgumentException("Обязательно миниму 2 корня", nameof(complexRoots));
            ScalePixel = scalePixel;
            Text = title;
        }


        private void DrawPolygonForm_Paint(object sender, PaintEventArgs e)
        {
            if (cbShowGrid.Checked)
            {
                DrawGrid(e.Graphics);
            }
            DrawCoorinatesLine2D(e.Graphics);

            e.Graphics.DrawPolygon(_polygonPen, ScaleCentredPoints);
            float radius = (float)CircleRadius;
            e.Graphics.DrawEllipse(_circlePen, new RectangleF((float)Width / 2 - radius * ScalePixel, (float)Height / 2 - radius * ScalePixel, radius * ScalePixel * 2, radius * ScalePixel * 2));

            PointF[] points = ScaleCentredPoints;
            for (int i = 0; i < points?.Length; i++)
            {
                e.Graphics.FillEllipse(Brushes.Red, points[i].X - 5, points[i].Y - 5, 10, 10);
                e.Graphics.DrawString($"( {ComplexRoots[i].Real}; {ComplexRoots[i].Imaginary} )", new Font(Font.FontFamily, 12, FontStyle.Bold), new SolidBrush(Color.Red), points[i].X + 5, points[i].Y + 5);
            }
        }

        private void DrawGrid(Graphics g)
        {
            Pen gridPen = new Pen(Color.Black, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            PointF startPoint = new PointF((float)Width / 2, (float)Height / 2);
            float pointLeftX = startPoint.X, pointRightX = startPoint.X,
                pointTopY = startPoint.Y, poinBottomY = startPoint.Y;
            while (pointLeftX >= 0)
            {
                pointLeftX -= ScalePixel;
                g.DrawLine(gridPen, pointLeftX, 0, pointLeftX, Height);
            }
            while (pointRightX <= Width)
            {
                pointRightX += ScalePixel;
                g.DrawLine(gridPen, pointRightX, 0, pointRightX, Height);
            }

            while (pointTopY >= 0)
            {
                pointTopY -= ScalePixel;
                g.DrawLine(gridPen, 0, pointTopY, Width, pointTopY);
            }

            while (pointTopY <= Height)
            {
                pointTopY += ScalePixel;
                g.DrawLine(gridPen, 0, pointTopY, Width, pointTopY);
            }
        }

        private void DrawCoorinatesLine2D(Graphics g)
        {
            g.DrawLine(_graphicPen, 0, Height / 2, Width, Height / 2);
            g.DrawLine(_graphicPen, Width / 2, 0, Width / 2, Height);
            int lineSize = 20;
            g.DrawLine(_graphicPen, Width / 2, 0, Width / 2 - lineSize, lineSize);
            g.DrawLine(_graphicPen, Width / 2, 0, Width / 2 + lineSize, lineSize);
            g.DrawLine(_graphicPen, Width - lineSize, Height / 2, Width - lineSize * 2, Height / 2 - lineSize);
            g.DrawString("Im z", new Font(Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, Width / 2 + 20, 10);
            g.DrawLine(_graphicPen, Width - lineSize, Height / 2, Width - lineSize * 2, Height / 2 + lineSize);
            g.DrawString("Re z", new Font(Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, Width - 90, Height / 2);

            g.DrawString("0", new Font(Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, Width / 2, Height / 2);
            g.DrawLine(_graphicPen, Width / 2 - lineSize, Height / 2 - ScalePixel, Width / 2 + lineSize, Height / 2 - ScalePixel);
            g.DrawString("1", new Font(Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, Width / 2, Height / 2 - ScalePixel - 20);
            g.DrawLine(_graphicPen, Width / 2 + ScalePixel, Height / 2 - lineSize, Width / 2 + ScalePixel, Height / 2 + lineSize);
            g.DrawString("1", new Font(Font.FontFamily, 12, FontStyle.Bold), Brushes.Black, Width / 2 + ScalePixel, Height / 2);
        }

        private void cbShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnScaleRise_Click(object sender, EventArgs e)
        {
            ScalePixel += ScaleDiff;
            Refresh();
            if (!btnScaleDdecrease.Enabled)
            {
                btnScaleDdecrease.Enabled = true;
            }
        }

        private void btnScaleDdecrease_Click(object sender, EventArgs e)
        {
            if (ScalePixel - ScaleDiff * 2 < 0)
            {
                btnScaleDdecrease.Enabled = false;
            }
            if (ScalePixel - ScaleDiff > 0)
            {
                ScalePixel -= ScaleDiff;
                Refresh();
            }
        }
    }
}
