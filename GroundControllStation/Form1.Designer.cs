namespace GroundControllStation
{
    partial class main_window
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missionPlanerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordinatesConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.missionPlanerToolStripMenuItem,
            this.liveToolStripMenuItem,
            this.accesoriesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // missionPlanerToolStripMenuItem
            // 
            this.missionPlanerToolStripMenuItem.Name = "missionPlanerToolStripMenuItem";
            this.missionPlanerToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.missionPlanerToolStripMenuItem.Text = "Mission planer";
            this.missionPlanerToolStripMenuItem.Click += new System.EventHandler(this.missionPlanerToolStripMenuItem_Click);
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.liveToolStripMenuItem.Text = "Live";
            // 
            // accesoriesToolStripMenuItem
            // 
            this.accesoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unitConverterToolStripMenuItem,
            this.coordinatesConverterToolStripMenuItem});
            this.accesoriesToolStripMenuItem.Name = "accesoriesToolStripMenuItem";
            this.accesoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.accesoriesToolStripMenuItem.Text = "Accesories";
            // 
            // unitConverterToolStripMenuItem
            // 
            this.unitConverterToolStripMenuItem.Name = "unitConverterToolStripMenuItem";
            this.unitConverterToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.unitConverterToolStripMenuItem.Text = "Unit converter";
            // 
            // coordinatesConverterToolStripMenuItem
            // 
            this.coordinatesConverterToolStripMenuItem.Name = "coordinatesConverterToolStripMenuItem";
            this.coordinatesConverterToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.coordinatesConverterToolStripMenuItem.Text = "Coordinates converter";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_window";
            this.Text = "Simple pilot ground controll station v1.0";
            this.Load += new System.EventHandler(this.main_window_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missionPlanerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accesoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordinatesConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

