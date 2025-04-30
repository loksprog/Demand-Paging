namespace Demand_Paging
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            lblMemorySize = new Label();
            lblFrames = new Label();
            lblJobs = new Label();
            btnGenerate = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            btnReplacePage = new Krypton.Toolkit.KryptonButton();
            btnLoadPages = new Krypton.Toolkit.KryptonButton();
            pnlJobTable = new Panel();
            dgvJobTable = new DataGridView();
            txtbMemorySize = new Krypton.Toolkit.KryptonTextBox();
            txtbJobs = new Krypton.Toolkit.KryptonTextBox();
            txtbFrames = new Krypton.Toolkit.KryptonTextBox();
            pnlMemory = new Panel();
            pnlPageMapTable = new Panel();
            dgvPageMapTable = new DataGridView();
            panel1.SuspendLayout();
            pnlJobTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobTable).BeginInit();
            pnlPageMapTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPageMapTable).BeginInit();
            SuspendLayout();
            // 
            // lblMemorySize
            // 
            lblMemorySize.AutoSize = true;
            lblMemorySize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMemorySize.ForeColor = Color.White;
            lblMemorySize.Location = new Point(72, 146);
            lblMemorySize.Name = "lblMemorySize";
            lblMemorySize.Size = new Size(110, 21);
            lblMemorySize.TabIndex = 0;
            lblMemorySize.Text = "Memory Size";
            // 
            // lblFrames
            // 
            lblFrames.AutoSize = true;
            lblFrames.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrames.ForeColor = Color.White;
            lblFrames.Location = new Point(118, 182);
            lblFrames.Name = "lblFrames";
            lblFrames.Size = new Size(64, 21);
            lblFrames.TabIndex = 2;
            lblFrames.Text = "Frames";
            // 
            // lblJobs
            // 
            lblJobs.AutoSize = true;
            lblJobs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJobs.ForeColor = Color.White;
            lblJobs.Location = new Point(138, 218);
            lblJobs.Name = "lblJobs";
            lblJobs.Size = new Size(44, 21);
            lblJobs.TabIndex = 5;
            lblJobs.Text = "Jobs";
            // 
            // btnGenerate
            // 
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Location = new Point(115, 271);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.OverrideDefault.Back.Color1 = Color.FromArgb(39, 150, 255);
            btnGenerate.OverrideDefault.Back.Color2 = Color.FromArgb(39, 150, 255);
            btnGenerate.OverrideDefault.Border.Color1 = Color.FromArgb(39, 150, 255);
            btnGenerate.OverrideDefault.Border.Color2 = Color.FromArgb(39, 150, 255);
            btnGenerate.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGenerate.OverrideDefault.Border.Rounding = 20F;
            btnGenerate.OverrideDefault.Border.Width = 1;
            btnGenerate.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnGenerate.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnGenerate.OverrideDefault.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGenerate.Size = new Size(143, 42);
            btnGenerate.StateCommon.Back.Color1 = Color.FromArgb(39, 150, 255);
            btnGenerate.StateCommon.Back.Color2 = Color.FromArgb(39, 150, 255);
            btnGenerate.StateCommon.Border.Color1 = Color.FromArgb(39, 150, 255);
            btnGenerate.StateCommon.Border.Color2 = Color.FromArgb(39, 150, 255);
            btnGenerate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGenerate.StateCommon.Border.Rounding = 20F;
            btnGenerate.StateCommon.Border.Width = 1;
            btnGenerate.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGenerate.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.StatePressed.Back.Color1 = Color.FromArgb(100, 180, 255);
            btnGenerate.StatePressed.Back.Color2 = Color.FromArgb(100, 180, 255);
            btnGenerate.StatePressed.Border.Color1 = Color.FromArgb(100, 180, 255);
            btnGenerate.StatePressed.Border.Color2 = Color.FromArgb(100, 180, 255);
            btnGenerate.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGenerate.StatePressed.Border.Rounding = 20F;
            btnGenerate.StatePressed.Border.Width = 1;
            btnGenerate.StatePressed.Content.ShortText.Color1 = Color.White;
            btnGenerate.StatePressed.Content.ShortText.Color2 = Color.White;
            btnGenerate.StatePressed.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.StateTracking.Back.Color1 = Color.FromArgb(63, 162, 255);
            btnGenerate.StateTracking.Back.Color2 = Color.FromArgb(63, 162, 255);
            btnGenerate.StateTracking.Border.Color1 = Color.FromArgb(63, 162, 255);
            btnGenerate.StateTracking.Border.Color2 = Color.FromArgb(63, 162, 255);
            btnGenerate.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGenerate.StateTracking.Border.Rounding = 20F;
            btnGenerate.StateTracking.Border.Width = 1;
            btnGenerate.StateTracking.Content.ShortText.Color1 = Color.White;
            btnGenerate.StateTracking.Content.ShortText.Color2 = Color.White;
            btnGenerate.StateTracking.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.TabIndex = 4;
            btnGenerate.Values.DropDownArrowColor = Color.Empty;
            btnGenerate.Values.Text = "Generate";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 10, 45);
            panel1.Controls.Add(btnReplacePage);
            panel1.Controls.Add(btnLoadPages);
            panel1.Controls.Add(pnlJobTable);
            panel1.Controls.Add(txtbMemorySize);
            panel1.Controls.Add(txtbJobs);
            panel1.Controls.Add(txtbFrames);
            panel1.Controls.Add(btnGenerate);
            panel1.Controls.Add(lblMemorySize);
            panel1.Controls.Add(lblJobs);
            panel1.Controls.Add(lblFrames);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 854);
            panel1.TabIndex = 6;
            // 
            // btnReplacePage
            // 
            btnReplacePage.Cursor = Cursors.Hand;
            btnReplacePage.Location = new Point(115, 744);
            btnReplacePage.Name = "btnReplacePage";
            btnReplacePage.OverrideDefault.Back.Color1 = Color.FromArgb(39, 150, 255);
            btnReplacePage.OverrideDefault.Back.Color2 = Color.FromArgb(39, 150, 255);
            btnReplacePage.OverrideDefault.Border.Color1 = Color.FromArgb(39, 150, 255);
            btnReplacePage.OverrideDefault.Border.Color2 = Color.FromArgb(39, 150, 255);
            btnReplacePage.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnReplacePage.OverrideDefault.Border.Rounding = 20F;
            btnReplacePage.OverrideDefault.Border.Width = 1;
            btnReplacePage.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnReplacePage.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnReplacePage.OverrideDefault.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReplacePage.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnReplacePage.Size = new Size(143, 42);
            btnReplacePage.StateCommon.Back.Color1 = Color.FromArgb(39, 150, 255);
            btnReplacePage.StateCommon.Back.Color2 = Color.FromArgb(39, 150, 255);
            btnReplacePage.StateCommon.Border.Color1 = Color.FromArgb(39, 150, 255);
            btnReplacePage.StateCommon.Border.Color2 = Color.FromArgb(39, 150, 255);
            btnReplacePage.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnReplacePage.StateCommon.Border.Rounding = 20F;
            btnReplacePage.StateCommon.Border.Width = 1;
            btnReplacePage.StateCommon.Content.ShortText.Color1 = Color.White;
            btnReplacePage.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReplacePage.StatePressed.Back.Color1 = Color.FromArgb(100, 180, 255);
            btnReplacePage.StatePressed.Back.Color2 = Color.FromArgb(100, 180, 255);
            btnReplacePage.StatePressed.Border.Color1 = Color.FromArgb(100, 180, 255);
            btnReplacePage.StatePressed.Border.Color2 = Color.FromArgb(100, 180, 255);
            btnReplacePage.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnReplacePage.StatePressed.Border.Rounding = 20F;
            btnReplacePage.StatePressed.Border.Width = 1;
            btnReplacePage.StatePressed.Content.ShortText.Color1 = Color.White;
            btnReplacePage.StatePressed.Content.ShortText.Color2 = Color.White;
            btnReplacePage.StatePressed.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReplacePage.StateTracking.Back.Color1 = Color.FromArgb(63, 162, 255);
            btnReplacePage.StateTracking.Back.Color2 = Color.FromArgb(63, 162, 255);
            btnReplacePage.StateTracking.Border.Color1 = Color.FromArgb(63, 162, 255);
            btnReplacePage.StateTracking.Border.Color2 = Color.FromArgb(63, 162, 255);
            btnReplacePage.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnReplacePage.StateTracking.Border.Rounding = 20F;
            btnReplacePage.StateTracking.Border.Width = 1;
            btnReplacePage.StateTracking.Content.ShortText.Color1 = Color.White;
            btnReplacePage.StateTracking.Content.ShortText.Color2 = Color.White;
            btnReplacePage.StateTracking.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReplacePage.TabIndex = 11;
            btnReplacePage.Values.DropDownArrowColor = Color.Empty;
            btnReplacePage.Values.Text = "Replace Page";
            btnReplacePage.Visible = false;
            btnReplacePage.Click += btnReplacePage_Click;
            // 
            // btnLoadPages
            // 
            btnLoadPages.Cursor = Cursors.Hand;
            btnLoadPages.Location = new Point(115, 684);
            btnLoadPages.Name = "btnLoadPages";
            btnLoadPages.OverrideDefault.Back.Color1 = Color.FromArgb(39, 150, 255);
            btnLoadPages.OverrideDefault.Back.Color2 = Color.FromArgb(39, 150, 255);
            btnLoadPages.OverrideDefault.Border.Color1 = Color.FromArgb(39, 150, 255);
            btnLoadPages.OverrideDefault.Border.Color2 = Color.FromArgb(39, 150, 255);
            btnLoadPages.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLoadPages.OverrideDefault.Border.Rounding = 20F;
            btnLoadPages.OverrideDefault.Border.Width = 1;
            btnLoadPages.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btnLoadPages.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btnLoadPages.OverrideDefault.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadPages.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLoadPages.Size = new Size(143, 42);
            btnLoadPages.StateCommon.Back.Color1 = Color.FromArgb(39, 150, 255);
            btnLoadPages.StateCommon.Back.Color2 = Color.FromArgb(39, 150, 255);
            btnLoadPages.StateCommon.Border.Color1 = Color.FromArgb(39, 150, 255);
            btnLoadPages.StateCommon.Border.Color2 = Color.FromArgb(39, 150, 255);
            btnLoadPages.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLoadPages.StateCommon.Border.Rounding = 20F;
            btnLoadPages.StateCommon.Border.Width = 1;
            btnLoadPages.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLoadPages.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadPages.StatePressed.Back.Color1 = Color.FromArgb(100, 180, 255);
            btnLoadPages.StatePressed.Back.Color2 = Color.FromArgb(100, 180, 255);
            btnLoadPages.StatePressed.Border.Color1 = Color.FromArgb(100, 180, 255);
            btnLoadPages.StatePressed.Border.Color2 = Color.FromArgb(100, 180, 255);
            btnLoadPages.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLoadPages.StatePressed.Border.Rounding = 20F;
            btnLoadPages.StatePressed.Border.Width = 1;
            btnLoadPages.StatePressed.Content.ShortText.Color1 = Color.White;
            btnLoadPages.StatePressed.Content.ShortText.Color2 = Color.White;
            btnLoadPages.StatePressed.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadPages.StateTracking.Back.Color1 = Color.FromArgb(63, 162, 255);
            btnLoadPages.StateTracking.Back.Color2 = Color.FromArgb(63, 162, 255);
            btnLoadPages.StateTracking.Border.Color1 = Color.FromArgb(63, 162, 255);
            btnLoadPages.StateTracking.Border.Color2 = Color.FromArgb(63, 162, 255);
            btnLoadPages.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLoadPages.StateTracking.Border.Rounding = 20F;
            btnLoadPages.StateTracking.Border.Width = 1;
            btnLoadPages.StateTracking.Content.ShortText.Color1 = Color.White;
            btnLoadPages.StateTracking.Content.ShortText.Color2 = Color.White;
            btnLoadPages.StateTracking.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadPages.TabIndex = 10;
            btnLoadPages.Values.DropDownArrowColor = Color.Empty;
            btnLoadPages.Values.Text = "Load Pages";
            btnLoadPages.Visible = false;
            btnLoadPages.Click += btnLoadPages_Click;
            // 
            // pnlJobTable
            // 
            pnlJobTable.AutoScroll = true;
            pnlJobTable.Controls.Add(dgvJobTable);
            pnlJobTable.Location = new Point(46, 388);
            pnlJobTable.Name = "pnlJobTable";
            pnlJobTable.Size = new Size(282, 265);
            pnlJobTable.TabIndex = 9;
            // 
            // dgvJobTable
            // 
            dgvJobTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJobTable.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvJobTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobTable.Dock = DockStyle.Fill;
            dgvJobTable.GridColor = Color.FromArgb(217, 217, 217);
            dgvJobTable.Location = new Point(0, 0);
            dgvJobTable.Name = "dgvJobTable";
            dgvJobTable.ScrollBars = ScrollBars.Vertical;
            dgvJobTable.Size = new Size(282, 265);
            dgvJobTable.TabIndex = 0;
            // 
            // txtbMemorySize
            // 
            txtbMemorySize.Cursor = Cursors.IBeam;
            txtbMemorySize.Location = new Point(200, 146);
            txtbMemorySize.Name = "txtbMemorySize";
            txtbMemorySize.Size = new Size(82, 23);
            txtbMemorySize.StateCommon.Back.Color1 = Color.White;
            txtbMemorySize.StateCommon.Border.Color1 = Color.White;
            txtbMemorySize.StateCommon.Border.Color2 = Color.White;
            txtbMemorySize.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtbMemorySize.StateCommon.Border.Rounding = 5F;
            txtbMemorySize.StateCommon.Content.Color1 = Color.FromArgb(37, 37, 37);
            txtbMemorySize.StateCommon.Content.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbMemorySize.StateCommon.Content.Padding = new Padding(5, 1, 5, 1);
            txtbMemorySize.TabIndex = 1;
            // 
            // txtbJobs
            // 
            txtbJobs.Cursor = Cursors.IBeam;
            txtbJobs.Location = new Point(200, 218);
            txtbJobs.Name = "txtbJobs";
            txtbJobs.Size = new Size(82, 23);
            txtbJobs.StateCommon.Back.Color1 = Color.White;
            txtbJobs.StateCommon.Border.Color1 = Color.White;
            txtbJobs.StateCommon.Border.Color2 = Color.White;
            txtbJobs.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtbJobs.StateCommon.Border.Rounding = 5F;
            txtbJobs.StateCommon.Content.Color1 = Color.FromArgb(37, 37, 37);
            txtbJobs.StateCommon.Content.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbJobs.StateCommon.Content.Padding = new Padding(5, 1, 5, 1);
            txtbJobs.TabIndex = 3;
            // 
            // txtbFrames
            // 
            txtbFrames.Cursor = Cursors.IBeam;
            txtbFrames.Location = new Point(200, 182);
            txtbFrames.Name = "txtbFrames";
            txtbFrames.Size = new Size(82, 23);
            txtbFrames.StateCommon.Back.Color1 = Color.White;
            txtbFrames.StateCommon.Border.Color1 = Color.White;
            txtbFrames.StateCommon.Border.Color2 = Color.White;
            txtbFrames.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtbFrames.StateCommon.Border.Rounding = 5F;
            txtbFrames.StateCommon.Content.Color1 = Color.FromArgb(37, 37, 37);
            txtbFrames.StateCommon.Content.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbFrames.StateCommon.Content.Padding = new Padding(5, 1, 5, 1);
            txtbFrames.TabIndex = 2;
            // 
            // pnlMemory
            // 
            pnlMemory.AutoScroll = true;
            pnlMemory.BorderStyle = BorderStyle.FixedSingle;
            pnlMemory.Location = new Point(467, 182);
            pnlMemory.Name = "pnlMemory";
            pnlMemory.Size = new Size(292, 544);
            pnlMemory.TabIndex = 7;
            // 
            // pnlPageMapTable
            // 
            pnlPageMapTable.AutoScroll = true;
            pnlPageMapTable.Controls.Add(dgvPageMapTable);
            pnlPageMapTable.Location = new Point(828, 317);
            pnlPageMapTable.Name = "pnlPageMapTable";
            pnlPageMapTable.Size = new Size(729, 315);
            pnlPageMapTable.TabIndex = 8;
            // 
            // dgvPageMapTable
            // 
            dgvPageMapTable.BackgroundColor = Color.FromArgb(217, 217, 217);
            dgvPageMapTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPageMapTable.Dock = DockStyle.Fill;
            dgvPageMapTable.GridColor = Color.FromArgb(217, 217, 217);
            dgvPageMapTable.Location = new Point(0, 0);
            dgvPageMapTable.Name = "dgvPageMapTable";
            dgvPageMapTable.Size = new Size(729, 315);
            dgvPageMapTable.TabIndex = 100;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(1586, 854);
            Controls.Add(pnlPageMapTable);
            Controls.Add(pnlMemory);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demand-Paging Memory Allocation Simulator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlJobTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvJobTable).EndInit();
            pnlPageMapTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPageMapTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMemorySize;
        private Label lblFrames;
        private Label lblJobs;
        private Krypton.Toolkit.KryptonButton btnGenerate;
        private Panel panel1;
        private Krypton.Toolkit.KryptonTextBox txtbJobs;
        private Krypton.Toolkit.KryptonTextBox txtbFrames;
        private Krypton.Toolkit.KryptonTextBox txtbMemorySize;
        private Panel pnlJobTable;
        private DataGridView dgvJobTable;
        private Panel pnlMemory;
        private Panel pnlPageMapTable;
        private DataGridView dgvPageMapTable;
        private Krypton.Toolkit.KryptonButton btnLoadPages;
        private Krypton.Toolkit.KryptonButton btnReplacePage;
    }
}