namespace GameOfLife
{
    partial class MainGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbGrid = new System.Windows.Forms.PictureBox();
            this.numCSize = new System.Windows.Forms.NumericUpDown();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.cbLiveCells = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGrid
            // 
            this.pbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGrid.Location = new System.Drawing.Point(12, 41);
            this.pbGrid.Name = "pbGrid";
            this.pbGrid.Size = new System.Drawing.Size(920, 454);
            this.pbGrid.TabIndex = 0;
            this.pbGrid.TabStop = false;
            // 
            // numCSize
            // 
            this.numCSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numCSize.Location = new System.Drawing.Point(82, 528);
            this.numCSize.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numCSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCSize.Name = "numCSize";
            this.numCSize.Size = new System.Drawing.Size(60, 23);
            this.numCSize.TabIndex = 1;
            this.numCSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(24, 532);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(52, 15);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Cell size:";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.Location = new System.Drawing.Point(532, 529);
            this.btnReset.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(852, 528);
            this.btnGo.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(156, 533);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(115, 15);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "Number of live cells:";
            // 
            // cbLiveCells
            // 
            this.cbLiveCells.FormattingEnabled = true;
            this.cbLiveCells.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cbLiveCells.Location = new System.Drawing.Point(276, 530);
            this.cbLiveCells.Name = "cbLiveCells";
            this.cbLiveCells.Size = new System.Drawing.Size(121, 23);
            this.cbLiveCells.TabIndex = 7;
            this.cbLiveCells.SelectedIndexChanged += new System.EventHandler(this.cbLiveCells_SelectedIndexChanged);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 581);
            this.Controls.Add(this.cbLiveCells);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.numCSize);
            this.Controls.Add(this.pbGrid);
            this.MinimumSize = new System.Drawing.Size(960, 620);
            this.Name = "MainGame";
            this.Text = "Conway\'s game of life";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGame_FormClosing);
            this.Load += new System.EventHandler(this.MainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbGrid;
        private NumericUpDown numCSize;
        private Label lb1;
        private Button btnReset;
        private Button btnGo;
        private Label lb2;
        private ComboBox cbLiveCells;
    }
}