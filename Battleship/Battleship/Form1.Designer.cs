namespace Battleship
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.playerBoard = new buttonBoard();
            this.Play = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AC = new System.Windows.Forms.RadioButton();
            this.BATT = new System.Windows.Forms.RadioButton();
            this.DEST = new System.Windows.Forms.RadioButton();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.PTB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Horizontal = new System.Windows.Forms.RadioButton();
            this.Vertical = new System.Windows.Forms.RadioButton();
            this.Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.playerBoard);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.Play);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.Clear);
            this.splitContainer1.Size = new System.Drawing.Size(289, 473);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 103;
            // 
            // playerBoard
            // 
            this.playerBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerBoard.Location = new System.Drawing.Point(0, 0);
            this.playerBoard.Name = "playerBoard";
            this.playerBoard.Size = new System.Drawing.Size(289, 311);
            this.playerBoard.TabIndex = 0;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(200, 100);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 108;
            this.Play.Text = "Play!";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.AC);
            this.panel2.Controls.Add(this.BATT);
            this.panel2.Controls.Add(this.DEST);
            this.panel2.Controls.Add(this.Sub);
            this.panel2.Controls.Add(this.PTB);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 74);
            this.panel2.TabIndex = 107;
            // 
            // AC
            // 
            this.AC.AutoSize = true;
            this.AC.Location = new System.Drawing.Point(183, 16);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(91, 17);
            this.AC.TabIndex = 4;
            this.AC.Text = "Aircraft Carrier";
            this.AC.UseVisualStyleBackColor = true;
            // 
            // BATT
            // 
            this.BATT.AutoSize = true;
            this.BATT.Location = new System.Drawing.Point(150, 45);
            this.BATT.Name = "BATT";
            this.BATT.Size = new System.Drawing.Size(71, 17);
            this.BATT.TabIndex = 3;
            this.BATT.Text = "Battleship";
            this.BATT.UseVisualStyleBackColor = true;
            // 
            // DEST
            // 
            this.DEST.AutoSize = true;
            this.DEST.Location = new System.Drawing.Point(99, 16);
            this.DEST.Name = "DEST";
            this.DEST.Size = new System.Drawing.Size(70, 17);
            this.DEST.TabIndex = 2;
            this.DEST.Text = "Destroyer";
            this.DEST.UseVisualStyleBackColor = true;
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(43, 45);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(75, 17);
            this.Sub.TabIndex = 1;
            this.Sub.Text = "Submarine";
            this.Sub.UseVisualStyleBackColor = true;
            // 
            // PTB
            // 
            this.PTB.AutoSize = true;
            this.PTB.Checked = true;
            this.PTB.Location = new System.Drawing.Point(9, 16);
            this.PTB.Name = "PTB";
            this.PTB.Size = new System.Drawing.Size(64, 17);
            this.PTB.TabIndex = 0;
            this.PTB.TabStop = true;
            this.PTB.Text = "PT Boat";
            this.PTB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Horizontal);
            this.panel1.Controls.Add(this.Vertical);
            this.panel1.Location = new System.Drawing.Point(3, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 74);
            this.panel1.TabIndex = 106;
            // 
            // Horizontal
            // 
            this.Horizontal.AutoSize = true;
            this.Horizontal.Checked = true;
            this.Horizontal.Location = new System.Drawing.Point(9, 21);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(72, 17);
            this.Horizontal.TabIndex = 103;
            this.Horizontal.TabStop = true;
            this.Horizontal.Text = "Horizontal";
            this.Horizontal.UseVisualStyleBackColor = true;
            // 
            // Vertical
            // 
            this.Vertical.AutoSize = true;
            this.Vertical.Location = new System.Drawing.Point(9, 44);
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(60, 17);
            this.Vertical.TabIndex = 104;
            this.Vertical.Text = "Vertical";
            this.Vertical.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(118, 100);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 105;
            this.Clear.Text = "Clear Ships";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(289, 24);
            this.menuStrip1.TabIndex = 104;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(289, 497);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Play;
        public System.Windows.Forms.RadioButton Vertical;
        public System.Windows.Forms.RadioButton Horizontal;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton AC;
        public System.Windows.Forms.RadioButton BATT;
        public System.Windows.Forms.RadioButton DEST;
        public System.Windows.Forms.RadioButton Sub;
        public System.Windows.Forms.RadioButton PTB;
        public System.Windows.Forms.Panel panel1;
        public buttonBoard playerBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

