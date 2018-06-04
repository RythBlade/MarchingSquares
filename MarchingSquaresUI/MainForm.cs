using System;
using System.Windows.Forms;

namespace MarchingSquaresUI
{
    public partial class MainForm : Form
    {
        private const float densityMaxValue = 2.0f;

        public MainForm()
        {
            InitializeComponent();

            cellSizeTextBox.Text = marchingSquaresControl.CellSize.ToString();
            radiusTextBox.Text = marchingSquaresControl.ParticleRadius.ToString();
            densityThresholdTextBox.Text = marchingSquaresControl.DensityThreshold.ToString();
        }

        private void cellSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            marchingSquaresControl.CellSize = cellSizeTrackBar.Value;

            cellSizeTextBox.Text = marchingSquaresControl.CellSize.ToString();
        }

        private void cellSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            int cellSize = 0;
            int.TryParse(cellSizeTextBox.Text, out cellSize);

            marchingSquaresControl.CellSize = cellSize;

            cellSizeTrackBar.Value = marchingSquaresControl.CellSize;
            cellSizeTextBox.Text = marchingSquaresControl.CellSize.ToString();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            marchingSquaresControl.Reset();
        }

        private void regenerateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            marchingSquaresControl.DataChanged();
        }

        private void radiusTextBox_TextChanged(object sender, EventArgs e)
        {
            int particleRadius = 0;
            int.TryParse(radiusTextBox.Text, out particleRadius);

            marchingSquaresControl.ParticleRadius = particleRadius;

            radiusTrackBar.Value = marchingSquaresControl.ParticleRadius;
            radiusTextBox.Text = marchingSquaresControl.ParticleRadius.ToString();
        }

        private void radiusTrackBar_Scroll(object sender, EventArgs e)
        {
            marchingSquaresControl.ParticleRadius = radiusTrackBar.Value;

            radiusTextBox.Text = marchingSquaresControl.ParticleRadius.ToString();
        }

        private void densityThresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            marchingSquaresControl.DensityThreshold = densityMaxValue * (float)(densityThresholdTrackBar.Value - densityThresholdTrackBar.Minimum) / (float)(densityThresholdTrackBar.Maximum - densityThresholdTrackBar.Minimum);

            densityThresholdTextBox.Text = marchingSquaresControl.DensityThreshold.ToString();
        }

        private void densityThresholdTextBox_TextChanged(object sender, EventArgs e)
        {
            float densityThreshold = 0.0f;
            float.TryParse(densityThresholdTextBox.Text, out densityThreshold);

            if( densityThreshold < 0.0f )
            {
                densityThreshold = 0.0f;
            }

            if(densityThreshold > densityMaxValue)
            {
                densityThreshold = densityMaxValue;
            }
            
            marchingSquaresControl.DensityThreshold = densityThreshold;

            float densityThresholdRatio = marchingSquaresControl.DensityThreshold / densityMaxValue;

            densityThresholdTrackBar.Value = (int)((float)densityThresholdTrackBar.Minimum + densityThresholdRatio * (float)(densityThresholdTrackBar.Maximum - densityThresholdTrackBar.Minimum));
            densityThresholdTextBox.Text = marchingSquaresControl.DensityThreshold.ToString();
        }
    }
}
