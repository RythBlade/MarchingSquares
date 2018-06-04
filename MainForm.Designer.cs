namespace MarchingSquaresUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cellSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.cellSizeTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.regenerateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.radiusTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.densityThresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.densityThresholdTextBox = new System.Windows.Forms.TextBox();
            this.marchingSquaresControl = new MarchingSquaresUI.MarchingSquaresControl();
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayDensityCheckBox = new System.Windows.Forms.CheckBox();
            this.displayLinesCheckBox = new System.Windows.Forms.CheckBox();
            this.displayParticlesCheckBox = new System.Windows.Forms.CheckBox();
            this.displayGridCheckBox = new System.Windows.Forms.CheckBox();
            this.displayDensityPointsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityThresholdTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cellSizeTrackBar
            // 
            this.cellSizeTrackBar.Location = new System.Drawing.Point(12, 40);
            this.cellSizeTrackBar.Maximum = 100;
            this.cellSizeTrackBar.Minimum = 1;
            this.cellSizeTrackBar.Name = "cellSizeTrackBar";
            this.cellSizeTrackBar.Size = new System.Drawing.Size(536, 45);
            this.cellSizeTrackBar.TabIndex = 1;
            this.toolTipControl.SetToolTip(this.cellSizeTrackBar, resources.GetString("cellSizeTrackBar.ToolTip"));
            this.cellSizeTrackBar.Value = 1;
            this.cellSizeTrackBar.Scroll += new System.EventHandler(this.cellSizeTrackBar_Scroll);
            // 
            // cellSizeTextBox
            // 
            this.cellSizeTextBox.Location = new System.Drawing.Point(554, 40);
            this.cellSizeTextBox.Name = "cellSizeTextBox";
            this.cellSizeTextBox.Size = new System.Drawing.Size(39, 20);
            this.cellSizeTextBox.TabIndex = 2;
            this.toolTipControl.SetToolTip(this.cellSizeTextBox, resources.GetString("cellSizeTextBox.ToolTip"));
            this.cellSizeTextBox.TextChanged += new System.EventHandler(this.cellSizeTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem1,
            this.toolStripSeparator1,
            this.regenerateToolStripMenuItem1});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Tools";
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.resetToolStripMenuItem1.Text = "Reset";
            this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // regenerateToolStripMenuItem1
            // 
            this.regenerateToolStripMenuItem1.Name = "regenerateToolStripMenuItem1";
            this.regenerateToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.regenerateToolStripMenuItem1.Text = "Regenerate";
            this.regenerateToolStripMenuItem1.Click += new System.EventHandler(this.regenerateToolStripMenuItem1_Click);
            // 
            // radiusTrackBar
            // 
            this.radiusTrackBar.Location = new System.Drawing.Point(12, 104);
            this.radiusTrackBar.Maximum = 100;
            this.radiusTrackBar.Minimum = 1;
            this.radiusTrackBar.Name = "radiusTrackBar";
            this.radiusTrackBar.Size = new System.Drawing.Size(536, 45);
            this.radiusTrackBar.TabIndex = 4;
            this.toolTipControl.SetToolTip(this.radiusTrackBar, "Adjusts the radius of the points added to the density field.\r\n\r\nThe larger their " +
        "radius, the greater their \"area of effect\" within the density field.");
            this.radiusTrackBar.Value = 1;
            this.radiusTrackBar.Scroll += new System.EventHandler(this.radiusTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cell Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Particle Radius";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(554, 104);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(39, 20);
            this.radiusTextBox.TabIndex = 7;
            this.toolTipControl.SetToolTip(this.radiusTextBox, "Adjusts the radius of the points added to the density field.\r\n\r\nThe larger their " +
        "radius, the greater their \"area of effect\" within the density field.\r\n\r\n\r\n");
            this.radiusTextBox.TextChanged += new System.EventHandler(this.radiusTextBox_TextChanged);
            // 
            // densityThresholdTrackBar
            // 
            this.densityThresholdTrackBar.Location = new System.Drawing.Point(15, 168);
            this.densityThresholdTrackBar.Maximum = 100;
            this.densityThresholdTrackBar.Minimum = 1;
            this.densityThresholdTrackBar.Name = "densityThresholdTrackBar";
            this.densityThresholdTrackBar.Size = new System.Drawing.Size(533, 45);
            this.densityThresholdTrackBar.TabIndex = 8;
            this.toolTipControl.SetToolTip(this.densityThresholdTrackBar, resources.GetString("densityThresholdTrackBar.ToolTip"));
            this.densityThresholdTrackBar.Value = 1;
            this.densityThresholdTrackBar.Scroll += new System.EventHandler(this.densityThresholdTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Density Threshold";
            // 
            // densityThresholdTextBox
            // 
            this.densityThresholdTextBox.Location = new System.Drawing.Point(554, 168);
            this.densityThresholdTextBox.Name = "densityThresholdTextBox";
            this.densityThresholdTextBox.Size = new System.Drawing.Size(39, 20);
            this.densityThresholdTextBox.TabIndex = 10;
            this.toolTipControl.SetToolTip(this.densityThresholdTextBox, resources.GetString("densityThresholdTextBox.ToolTip"));
            this.densityThresholdTextBox.TextChanged += new System.EventHandler(this.densityThresholdTextBox_TextChanged);
            // 
            // marchingSquaresControl
            // 
            this.marchingSquaresControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marchingSquaresControl.BackColor = System.Drawing.Color.AliceBlue;
            this.marchingSquaresControl.CellSize = 20;
            this.marchingSquaresControl.DensityThreshold = 0.5F;
            this.marchingSquaresControl.Location = new System.Drawing.Point(12, 232);
            this.marchingSquaresControl.Name = "marchingSquaresControl";
            this.marchingSquaresControl.ParticleRadius = 20;
            this.marchingSquaresControl.Size = new System.Drawing.Size(757, 364);
            this.marchingSquaresControl.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Click the grid below to add points!";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.displayDensityPointsCheckBox);
            this.groupBox1.Controls.Add(this.displayGridCheckBox);
            this.groupBox1.Controls.Add(this.displayParticlesCheckBox);
            this.groupBox1.Controls.Add(this.displayLinesCheckBox);
            this.groupBox1.Controls.Add(this.displayDensityCheckBox);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(599, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 173);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Render options";
            // 
            // displayDensityCheckBox
            // 
            this.displayDensityCheckBox.AutoSize = true;
            this.displayDensityCheckBox.Location = new System.Drawing.Point(6, 16);
            this.displayDensityCheckBox.Name = "displayDensityCheckBox";
            this.displayDensityCheckBox.Size = new System.Drawing.Size(118, 17);
            this.displayDensityCheckBox.TabIndex = 13;
            this.displayDensityCheckBox.Text = "Display density field";
            this.displayDensityCheckBox.UseVisualStyleBackColor = true;
            this.displayDensityCheckBox.CheckedChanged += new System.EventHandler(this.displayDensityCheckBox_CheckedChanged);
            // 
            // displayLinesCheckBox
            // 
            this.displayLinesCheckBox.AutoSize = true;
            this.displayLinesCheckBox.Location = new System.Drawing.Point(6, 39);
            this.displayLinesCheckBox.Name = "displayLinesCheckBox";
            this.displayLinesCheckBox.Size = new System.Drawing.Size(135, 17);
            this.displayLinesCheckBox.TabIndex = 14;
            this.displayLinesCheckBox.Text = "Display generated lines";
            this.displayLinesCheckBox.UseVisualStyleBackColor = true;
            this.displayLinesCheckBox.CheckedChanged += new System.EventHandler(this.displayLinesCheckBox_CheckedChanged);
            // 
            // displayParticlesCheckBox
            // 
            this.displayParticlesCheckBox.AutoSize = true;
            this.displayParticlesCheckBox.Location = new System.Drawing.Point(6, 85);
            this.displayParticlesCheckBox.Name = "displayParticlesCheckBox";
            this.displayParticlesCheckBox.Size = new System.Drawing.Size(102, 17);
            this.displayParticlesCheckBox.TabIndex = 15;
            this.displayParticlesCheckBox.Text = "Display particles";
            this.displayParticlesCheckBox.UseVisualStyleBackColor = true;
            this.displayParticlesCheckBox.CheckedChanged += new System.EventHandler(this.displayParticlesCheckBox_CheckedChanged);
            // 
            // displayGridCheckBox
            // 
            this.displayGridCheckBox.AutoSize = true;
            this.displayGridCheckBox.Location = new System.Drawing.Point(6, 62);
            this.displayGridCheckBox.Name = "displayGridCheckBox";
            this.displayGridCheckBox.Size = new System.Drawing.Size(80, 17);
            this.displayGridCheckBox.TabIndex = 16;
            this.displayGridCheckBox.Text = "Display grid";
            this.displayGridCheckBox.UseVisualStyleBackColor = true;
            this.displayGridCheckBox.CheckedChanged += new System.EventHandler(this.displayGridCheckBox_CheckedChanged);
            // 
            // displayDensityPointsCheckBox
            // 
            this.displayDensityPointsCheckBox.AutoSize = true;
            this.displayDensityPointsCheckBox.Location = new System.Drawing.Point(6, 108);
            this.displayDensityPointsCheckBox.Name = "displayDensityPointsCheckBox";
            this.displayDensityPointsCheckBox.Size = new System.Drawing.Size(127, 17);
            this.displayDensityPointsCheckBox.TabIndex = 17;
            this.displayDensityPointsCheckBox.Text = "Display density points";
            this.displayDensityPointsCheckBox.UseVisualStyleBackColor = true;
            this.displayDensityPointsCheckBox.CheckedChanged += new System.EventHandler(this.displayDensityPointsCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.densityThresholdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.densityThresholdTrackBar);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radiusTrackBar);
            this.Controls.Add(this.cellSizeTextBox);
            this.Controls.Add(this.cellSizeTrackBar);
            this.Controls.Add(this.marchingSquaresControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Marching Squares";
            ((System.ComponentModel.ISupportInitialize)(this.cellSizeTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityThresholdTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MarchingSquaresControl marchingSquaresControl;
        private System.Windows.Forms.TrackBar cellSizeTrackBar;
        private System.Windows.Forms.TextBox cellSizeTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem regenerateToolStripMenuItem1;
        private System.Windows.Forms.TrackBar radiusTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.TrackBar densityThresholdTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox densityThresholdTextBox;
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox displayLinesCheckBox;
        private System.Windows.Forms.CheckBox displayDensityCheckBox;
        private System.Windows.Forms.CheckBox displayDensityPointsCheckBox;
        private System.Windows.Forms.CheckBox displayGridCheckBox;
        private System.Windows.Forms.CheckBox displayParticlesCheckBox;
    }
}

