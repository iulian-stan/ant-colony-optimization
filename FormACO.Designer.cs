namespace ACO
{
    partial class FormACO
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
            this.panelMap = new System.Windows.Forms.PictureBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonOptimal = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonAnt = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelOptimal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelOptimalVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelAlfa = new System.Windows.Forms.Label();
            this.textBoxAlfa = new System.Windows.Forms.TextBox();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.labelBeta = new System.Windows.Forms.Label();
            this.textBoxRo = new System.Windows.Forms.TextBox();
            this.labelRo = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabelCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCurrentVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.Iterations = new ACO.BarCounter();
            this.Ants = new ACO.BarCounter();
            this.Delay = new ACO.BarCounter();
            this.Cities = new ACO.BarCounter();
            ((System.ComponentModel.ISupportInitialize)(this.panelMap)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // panelMap
            //
            this.panelMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMap.Location = new System.Drawing.Point(0, 25);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(275, 271);
            this.panelMap.TabIndex = 0;
            this.panelMap.TabStop = false;
            this.panelMap.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMapPaint);
            //
            // buttonGenerate
            //
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(279, 244);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerateClick);
            //
            // buttonOptimal
            //
            this.buttonOptimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOptimal.Enabled = false;
            this.buttonOptimal.Location = new System.Drawing.Point(279, 273);
            this.buttonOptimal.Name = "buttonOptimal";
            this.buttonOptimal.Size = new System.Drawing.Size(75, 23);
            this.buttonOptimal.TabIndex = 5;
            this.buttonOptimal.Text = "Optimal";
            this.buttonOptimal.UseVisualStyleBackColor = true;
            this.buttonOptimal.Click += new System.EventHandler(this.ButtonOptimalClick);
            //
            // backgroundWorker
            //
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
            //
            // buttonAnt
            //
            this.buttonAnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnt.Enabled = false;
            this.buttonAnt.Location = new System.Drawing.Point(360, 273);
            this.buttonAnt.Name = "buttonAnt";
            this.buttonAnt.Size = new System.Drawing.Size(75, 23);
            this.buttonAnt.TabIndex = 9;
            this.buttonAnt.Text = "Ant system";
            this.buttonAnt.UseVisualStyleBackColor = true;
            this.buttonAnt.Click += new System.EventHandler(this.ButtonAntClick);
            //
            // buttonCancel
            //
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(360, 244);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            //
            // menuStrip
            //
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(448, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            //
            // fileToolStripMenuItem
            //
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            //
            // saveToolStripMenuItem
            //
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsToolStripMenuItem,
            this.imageToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            //
            // pointsToolStripMenuItem
            //
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pointsToolStripMenuItem.Text = "Points";
            this.pointsToolStripMenuItem.Click += new System.EventHandler(this.PointsToolStripMenuItemClick);
            //
            // imageToolStripMenuItem
            //
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.ImageToolStripMenuItemClick);
            //
            // loadToolStripMenuItem
            //
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsToolStripMenuItem1});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            //
            // pointsToolStripMenuItem1
            //
            this.pointsToolStripMenuItem1.Name = "pointsToolStripMenuItem1";
            this.pointsToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.pointsToolStripMenuItem1.Text = "Points";
            this.pointsToolStripMenuItem1.Click += new System.EventHandler(this.PointsToolStripMenuItem1Click);
            //
            // statusStrip
            //
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelOptimal,
            this.toolStripStatusLabelOptimalVal,
            this.toolStripStatusLabelCurrent,
            this.toolStripStatusLabelCurrentVal});
            this.statusStrip.Location = new System.Drawing.Point(0, 299);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(448, 22);
            this.statusStrip.TabIndex = 17;
            //
            // toolStripStatusLabelOptimal
            //
            this.toolStripStatusLabelOptimal.Name = "toolStripStatusLabelOptimal";
            this.toolStripStatusLabelOptimal.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabelOptimal.Text = "Optimal cost";
            //
            // toolStripStatusLabelOptimalVal
            //
            this.toolStripStatusLabelOptimalVal.Name = "toolStripStatusLabelOptimalVal";
            this.toolStripStatusLabelOptimalVal.Size = new System.Drawing.Size(0, 17);
            //
            // labelAlfa
            //
            this.labelAlfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlfa.AutoSize = true;
            this.labelAlfa.Location = new System.Drawing.Point(296, 167);
            this.labelAlfa.Name = "labelAlfa";
            this.labelAlfa.Size = new System.Drawing.Size(25, 13);
            this.labelAlfa.TabIndex = 18;
            this.labelAlfa.Text = "Alfa";
            //
            // textBoxAlfa
            //
            this.textBoxAlfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAlfa.Location = new System.Drawing.Point(360, 157);
            this.textBoxAlfa.Name = "textBoxAlfa";
            this.textBoxAlfa.Size = new System.Drawing.Size(66, 20);
            this.textBoxAlfa.TabIndex = 19;
            this.textBoxAlfa.Text = "1";
            //
            // textBoxBeta
            //
            this.textBoxBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBeta.Location = new System.Drawing.Point(360, 183);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(66, 20);
            this.textBoxBeta.TabIndex = 21;
            this.textBoxBeta.Text = "2";
            //
            // labelBeta
            //
            this.labelBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBeta.AutoSize = true;
            this.labelBeta.Location = new System.Drawing.Point(296, 186);
            this.labelBeta.Name = "labelBeta";
            this.labelBeta.Size = new System.Drawing.Size(29, 13);
            this.labelBeta.TabIndex = 20;
            this.labelBeta.Text = "Beta";
            //
            // textBoxRo
            //
            this.textBoxRo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRo.Location = new System.Drawing.Point(360, 208);
            this.textBoxRo.Name = "textBoxRo";
            this.textBoxRo.Size = new System.Drawing.Size(66, 20);
            this.textBoxRo.TabIndex = 23;
            this.textBoxRo.Text = "0.5";
            //
            // labelRo
            //
            this.labelRo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRo.AutoSize = true;
            this.labelRo.Location = new System.Drawing.Point(300, 211);
            this.labelRo.Name = "labelRo";
            this.labelRo.Size = new System.Drawing.Size(21, 13);
            this.labelRo.TabIndex = 22;
            this.labelRo.Text = "Ro";
            //
            // toolStripStatusLabelCurrent
            //
            this.toolStripStatusLabelCurrent.Name = "toolStripStatusLabelCurrent";
            this.toolStripStatusLabelCurrent.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabelCurrent.Text = "Current cost";
            //
            // toolStripStatusLabelCurrentVal
            //
            this.toolStripStatusLabelCurrentVal.Name = "toolStripStatusLabelCurrentVal";
            this.toolStripStatusLabelCurrentVal.Size = new System.Drawing.Size(0, 17);
            //
            // Iterations
            //
            this.Iterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Iterations.Location = new System.Drawing.Point(360, 91);
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(90, 60);
            this.Iterations.TabIndex = 24;
            this.Iterations.Value = 0;
            //
            // Ants
            //
            this.Ants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ants.Location = new System.Drawing.Point(360, 25);
            this.Ants.Name = "Ants";
            this.Ants.Size = new System.Drawing.Size(90, 60);
            this.Ants.TabIndex = 16;
            this.Ants.Value = 0;
            //
            // Delay
            //
            this.Delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delay.Location = new System.Drawing.Point(273, 91);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(90, 60);
            this.Delay.TabIndex = 15;
            this.Delay.Value = 0;
            //
            // Cities
            //
            this.Cities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cities.Location = new System.Drawing.Point(273, 25);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(90, 60);
            this.Cities.TabIndex = 14;
            this.Cities.Value = 0;
            //
            // FormACO
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 321);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.textBoxRo);
            this.Controls.Add(this.labelRo);
            this.Controls.Add(this.textBoxBeta);
            this.Controls.Add(this.labelBeta);
            this.Controls.Add(this.textBoxAlfa);
            this.Controls.Add(this.labelAlfa);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Ants);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAnt);
            this.Controls.Add(this.buttonOptimal);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.panelMap);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.Cities);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormACO";
            this.Text = "ACO";
            ((System.ComponentModel.ISupportInitialize)(this.panelMap)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox panelMap;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonOptimal;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button buttonAnt;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem1;
        private BarCounter Cities;
        private BarCounter Delay;
        private BarCounter Ants;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label labelAlfa;
        private System.Windows.Forms.TextBox textBoxAlfa;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.Label labelBeta;
        private System.Windows.Forms.TextBox textBoxRo;
        private System.Windows.Forms.Label labelRo;
        private BarCounter Iterations;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOptimal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOptimalVal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrent;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentVal;
    }
}

