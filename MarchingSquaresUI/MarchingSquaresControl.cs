using MarchingSquares;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MarchingSquaresUI
{
    public partial class MarchingSquaresControl : UserControl
    {
        private MSParticleField particleField = new MSParticleField(100);
        private MSGenerator generator = new MSGenerator();

        private Bitmap densityFieldBitMap = null;
        
        public int CellSize
        {
            get { return generator.CellSize; }
            set
            {
                generator.CellSize = value;

                DataChanged();
            }
        }

        private int particleRadius = 20;

        public int ParticleRadius
        {
            get { return particleRadius; }
            set
            {
                particleRadius = value;

                if( particleRadius < 1)
                {
                    particleRadius = 1;
                }

                if( particleRadius > 100)
                {
                    particleRadius = 100;
                }

                foreach(MSParticle particle in particleField.ParticleList)
                {
                    particle.Radius = particleRadius;
                }

                DataChanged();
            }
        }

        public float DensityThreshold
        {
            get { return generator.DensityThreshold; }
            set
            {
                generator.DensityThreshold = value;
                DataChanged();
            }
        }

        public MarchingSquaresControl()
        {
            InitializeComponent();
            BackColor = Color.AliceBlue;
            CellSize = 20;

            densityFieldBitMap = new Bitmap(Width, Height);
        }

        public void Reset()
        {
            particleField.ParticleList.Clear();
            generator.ResetData();

            DataChanged();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            RenderDensityField(e);
            RenderGrid(e);
            RenderDensityPoints(e);

            RenderParticles(e);

            RenderExtractedLines(e);
        }

        private void RenderDensityPoints(PaintEventArgs e)
        {
            if (generator.DensityArray != null)
            {
                Pen dotPen = new Pen(Color.Pink, 3);

                for (int x = 0; x < generator.DensityArray.GetLength(0); x++)
                {
                    for (int y = 0; y < generator.DensityArray.GetLength(1); y++)
                    {
                        if (generator.DensityArray[x, y] > 0.0f)
                        {
                            e.Graphics.DrawEllipse(dotPen, -1 + generator.MinExtent.X + generator.CellSize * (float)x, -1 + generator.MinExtent.Y + generator.CellSize * (float)y, 1, 1);
                        }
                    }
                }
            }
        }
        
        private void RenderExtractedLines(PaintEventArgs e)
        {
            Pen dotPen = new Pen(Color.Green, 2);

            foreach(MSLine line in generator.GeneratedLines)
            {
                e.Graphics.DrawLine(dotPen, line.Start.X, line.Start.Y, line.End.X, line.End.Y);
            }
        }

        private void RenderDensityField(PaintEventArgs e)
        {
            MSPoint point = new MSPoint(0.0f, 0.0f);
            
            const float maxDensity = 10.0f;

            int xBound = e.ClipRectangle.X + e.ClipRectangle.Width;
            int yBound = e.ClipRectangle.Y + e.ClipRectangle.Height;

            for (int x = e.ClipRectangle.X; x < xBound; ++x)
            {
                for (int y = e.ClipRectangle.Y; y < yBound; ++y)
                {
                    point.X = x;
                    point.Y = y;

                    float density = particleField.DensityAtLocation(point);

                    int alpha = (int)(128.0f + (density / maxDensity) * 127.0f);

                    Color renderColour = Color.FromArgb(alpha, Color.Red);

                    densityFieldBitMap.SetPixel(x, y, renderColour);
                }
            }

            e.Graphics.DrawImageUnscaled(densityFieldBitMap, 0, 0);
        }

        private void RenderParticles(PaintEventArgs e)
        {
            Pen dotPen = new Pen(Color.Black, 1);
            
            foreach (MSParticle particle in particleField.ParticleList)
            {
                float radiusOver2 = particle.Radius / 2.0f;
                e.Graphics.DrawEllipse(dotPen, particle.Position.X - particle.Radius, particle.Position.Y - particle.Radius, particle.Radius * 2.0f, particle.Radius * 2.0f);
                e.Graphics.DrawEllipse(dotPen, particle.Position.X, particle.Position.Y, 1, 1);
            }
        }

        private void RenderGrid(PaintEventArgs e)
        {
            Pen linePen = new Pen(Color.FromArgb(64, Color.Blue), 1);

            int lineHeightPos = e.ClipRectangle.Height + e.ClipRectangle.Y;

            for (int x = e.ClipRectangle.X; x < (e.ClipRectangle.X + e.ClipRectangle.Width); ++x)
            {
                if ((x % CellSize) == 0)
                {
                    e.Graphics.DrawLine(linePen, new Point(x, e.ClipRectangle.Y), new Point(x, lineHeightPos));
                }
            }

            int lineWidthPos = e.ClipRectangle.Width + e.ClipRectangle.X;

            for (int y = e.ClipRectangle.Y; y < (e.ClipRectangle.Y + e.ClipRectangle.Height); ++y)
            {
                if ((y % CellSize) == 0)
                {
                    e.Graphics.DrawLine(linePen, new Point(e.ClipRectangle.X, y), new Point(lineWidthPos, y));
                }
            }
        }

        private void MarchinSquaresControl_Click(object sender, EventArgs e)
        {
            Point controlPosition = PointToClient(MousePosition);
            particleField.AddParticle(controlPosition.X, controlPosition.Y, particleRadius);

            DataChanged();
        }

        private void MarchingSquaresControl_Resize(object sender, EventArgs e)
        {
            densityFieldBitMap = new Bitmap(Width, Height);
        }

        public void DataChanged()
        {
            generator.GenerateLines(particleField);

            Invalidate();
        }
    }
}
