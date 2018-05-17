using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JdLogistics
{
    public partial class MainView : UserControl
    {
        public Image Content { get; set; }

        internal bool ShowLaserLine = false;
        internal List<Point> LaserPoints = new List<Point>();

        private Matrix modelMatrix = new Matrix();

        private Matrix worldMatrix = new Matrix();

        private Matrix imageMatrix = new Matrix();

        private int pan = 0;

        private bool click = false;

        private PointF prev = new PointF();

        public MainView()
        {
            InitializeComponent();
            InitializeInterface();
            InitializeCallbacks();
        }

        public PointF toWorld(PointF pos)
        {
            PointF[] points = new PointF[] { pos };

            imageMatrix.TransformPoints(points);

            return points[0];
        }

        public PointF toImage(PointF pos)
        {
            PointF[] points = new PointF[] { pos };

            worldMatrix.TransformPoints(points);

            return points[0];
        }

        public void zoomActure()
        {
            this.worldMatrix = new Matrix();
            this.imageMatrix = new Matrix();
            this.Invalidate();
        }

        public void zoomWindow()
        {
            int bw = Content != null ? Content.Width : 100;
            int bh = Content != null ? Content.Height : 100;

            if (bw != 0 && bh != 0)
            {
                float ww = this.Width;
                float wh = this.Height;

                float iw = bw;
                float ih = bh;

                float wRatio = 1.0f * ww / iw;
                float hRatio = 1.0f * wh / ih;

                if (wRatio > hRatio)
                {
                    float dw = iw * hRatio;

                    worldMatrix = new Matrix();
                    worldMatrix.Translate((ww - dw) / 2.0f + 5.0f, 5.0f);

                    modelMatrix = new Matrix();
                    modelMatrix.Scale(hRatio, hRatio);

                    worldMatrix.Multiply(modelMatrix);
                }
                else
                {
                    float dh = ih * wRatio;

                    worldMatrix = new Matrix();
                    worldMatrix.Translate(5.0f, (wh - dh) / 2.0f + 5.0f);

                    modelMatrix = new Matrix();
                    modelMatrix.Scale(wRatio, wRatio);

                    worldMatrix.Multiply(modelMatrix);
                }

                imageMatrix = worldMatrix.Clone();
                imageMatrix.Invert();

                this.Invalidate();
            }
        }

        private void InitializeInterface()
        {
        }

        private void InitializeCallbacks()
        {
            this.MouseWheel += new MouseEventHandler(this.MainView_Wheel);
        }

        private void MainView_Wheel(object sender, MouseEventArgs e)
        {
            PointF pos = e.Location;

            PointF[] points = new PointF[] { e.Location };

            imageMatrix.TransformPoints(points);

            if (e.Delta > 0)
            {
                float xOffset = -points[0].X * 0.2f;
                float yOffset = -points[0].Y * 0.2f;

                modelMatrix = new Matrix();
                modelMatrix.Translate(xOffset, yOffset);
                worldMatrix.Multiply(modelMatrix);

                modelMatrix = new Matrix();
                modelMatrix.Scale(1.0f * 1.2f, 1.0f * 1.2f);
                worldMatrix.Multiply(modelMatrix);
            }
            else
            {
                float xOffset = +points[0].X * 0.2f;
                float yOffset = +points[0].Y * 0.2f;

                modelMatrix = new Matrix();
                modelMatrix.Translate(xOffset, yOffset);
                worldMatrix.Multiply(modelMatrix);

                modelMatrix = new Matrix();
                modelMatrix.Scale(1.0f / 1.25f, 1.0f / 1.25f);
                worldMatrix.Multiply(modelMatrix);
            }

            imageMatrix = worldMatrix.Clone();

            imageMatrix.Invert();

            this.Invalidate();
        }

        private void MainView_Paint(object sender, PaintEventArgs e)
        {
            float factor = 1.0f / worldMatrix.Elements[0];

            e.Graphics.Clear(Color.FromArgb(0, 0, 0));

            e.Graphics.Transform = worldMatrix;

            if (Content != null)
            {
                e.Graphics.DrawImage(Content, new Point(0, 0));
            }

            if (ShowLaserLine && LaserPoints.Count > 0)
            {
                foreach (Point point in LaserPoints)
                {
                    if(point.X == 0|| point.Y == 0)
                        continue;
                    e.Graphics.DrawRectangle(Pens.Red, point.X, point.Y, 1, 1);
                }
            }
        }

        private void MainView_MouseEnter(object sender, EventArgs e)
        {
        }

        private void MainView_MouseHover(object sender, EventArgs e)
        {

        }

        private void MainView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                pan = 1; this.Cursor = Cursors.SizeAll; prev = e.Location;
            }

            click = true;
        }

        private void MainView_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                Point curr = e.Location;

                if (pan == 1)
                {
                    PointF[] points = new PointF[] { prev, curr };

                    imageMatrix.TransformPoints(points);

                    float xOffset = points[1].X - points[0].X;
                    float yOffset = points[1].Y - points[0].Y;

                    Matrix objectMatrix = new Matrix();
                    objectMatrix.Translate(xOffset, yOffset);
                    worldMatrix.Multiply(objectMatrix);

                    imageMatrix = worldMatrix.Clone();
                    imageMatrix.Invert();

                    this.Invalidate();
                }

                prev = curr;
            }
        }

        private void MainView_MouseUp(object sender, MouseEventArgs e)
        {
            if (!click)
            {
                return;
            }

            if (e.Button == MouseButtons.Middle)
            {
                if (pan == 1)
                {
                    pan = 0; this.Cursor = Cursors.Arrow;
                }
            }

            click = false;
        }

        private void MainView_DoubleClick(object sender, EventArgs e)
        {
        }

        private void MainView_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void MainView_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tsmiFitSize_Click(object sender, EventArgs e)
        {
            zoomWindow();
        }
    }
}
