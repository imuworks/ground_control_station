namespace GroundControllStation
{
    partial class mp_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxOnclick = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelite = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLoadFP = new System.Windows.Forms.Button();
            this.buttonSaveFP = new System.Windows.Forms.Button();
            this.buttonNewFP = new System.Windows.Forms.Button();
            this.dataGridViewFliteplan = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Special = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Next = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gMapControlFlightPlaner = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxLon = new System.Windows.Forms.TextBox();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMapSource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarMapZoom = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFliteplan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapZoom)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxOnclick);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonDelite);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.buttonLoadFP);
            this.groupBox1.Controls.Add(this.buttonSaveFP);
            this.groupBox1.Controls.Add(this.buttonNewFP);
            this.groupBox1.Controls.Add(this.dataGridViewFliteplan);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(553, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight plan";
            // 
            // checkBoxOnclick
            // 
            this.checkBoxOnclick.AutoSize = true;
            this.checkBoxOnclick.Location = new System.Drawing.Point(9, 292);
            this.checkBoxOnclick.Name = "checkBoxOnclick";
            this.checkBoxOnclick.Size = new System.Drawing.Size(108, 17);
            this.checkBoxOnclick.TabIndex = 11;
            this.checkBoxOnclick.Text = "Add poin on click";
            this.checkBoxOnclick.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.Location = new System.Drawing.Point(177, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 24);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelite
            // 
            this.buttonDelite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDelite.Location = new System.Drawing.Point(93, 262);
            this.buttonDelite.Name = "buttonDelite";
            this.buttonDelite.Size = new System.Drawing.Size(78, 24);
            this.buttonDelite.TabIndex = 9;
            this.buttonDelite.Text = "Delite";
            this.buttonDelite.UseVisualStyleBackColor = true;
            this.buttonDelite.Click += new System.EventHandler(this.buttonDelite_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClear.Location = new System.Drawing.Point(9, 262);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 24);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLoadFP
            // 
            this.buttonLoadFP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoadFP.Location = new System.Drawing.Point(177, 20);
            this.buttonLoadFP.Name = "buttonLoadFP";
            this.buttonLoadFP.Size = new System.Drawing.Size(78, 24);
            this.buttonLoadFP.TabIndex = 7;
            this.buttonLoadFP.Text = "Load";
            this.buttonLoadFP.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFP
            // 
            this.buttonSaveFP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSaveFP.Location = new System.Drawing.Point(93, 20);
            this.buttonSaveFP.Name = "buttonSaveFP";
            this.buttonSaveFP.Size = new System.Drawing.Size(78, 24);
            this.buttonSaveFP.TabIndex = 6;
            this.buttonSaveFP.Text = "Save";
            this.buttonSaveFP.UseVisualStyleBackColor = true;
            // 
            // buttonNewFP
            // 
            this.buttonNewFP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNewFP.Location = new System.Drawing.Point(9, 20);
            this.buttonNewFP.Name = "buttonNewFP";
            this.buttonNewFP.Size = new System.Drawing.Size(78, 24);
            this.buttonNewFP.TabIndex = 5;
            this.buttonNewFP.Text = "New";
            this.buttonNewFP.UseVisualStyleBackColor = true;
            this.buttonNewFP.Click += new System.EventHandler(this.buttonNewFP_Click);
            // 
            // dataGridViewFliteplan
            // 
            this.dataGridViewFliteplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFliteplan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Altitude,
            this.Speed,
            this.Lat,
            this.Lon,
            this.ID,
            this.Special,
            this.Next});
            this.dataGridViewFliteplan.Location = new System.Drawing.Point(6, 50);
            this.dataGridViewFliteplan.MultiSelect = false;
            this.dataGridViewFliteplan.Name = "dataGridViewFliteplan";
            this.dataGridViewFliteplan.Size = new System.Drawing.Size(348, 206);
            this.dataGridViewFliteplan.TabIndex = 0;
            this.dataGridViewFliteplan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFliteplan_CellValueChanged);
            // 
            // Name
            // 
            this.Name.FillWeight = 70F;
            this.Name.HeaderText = "WPT";
            this.Name.Name = "Name";
            // 
            // Altitude
            // 
            this.Altitude.FillWeight = 40F;
            this.Altitude.HeaderText = "Altitude";
            this.Altitude.Name = "Altitude";
            // 
            // Speed
            // 
            this.Speed.FillWeight = 40F;
            this.Speed.HeaderText = "Speed";
            this.Speed.Name = "Speed";
            // 
            // Lat
            // 
            this.Lat.FillWeight = 70F;
            this.Lat.HeaderText = "Latitude";
            this.Lat.Name = "Lat";
            // 
            // Lon
            // 
            this.Lon.FillWeight = 70F;
            this.Lon.HeaderText = "Longitude";
            this.Lon.Name = "Lon";
            // 
            // ID
            // 
            this.ID.FillWeight = 30F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Special
            // 
            this.Special.FillWeight = 30F;
            this.Special.HeaderText = "Special";
            this.Special.Name = "Special";
            // 
            // Next
            // 
            this.Next.HeaderText = "Next";
            this.Next.Name = "Next";
            // 
            // gMapControlFlightPlaner
            // 
            this.gMapControlFlightPlaner.Bearing = 0F;
            this.gMapControlFlightPlaner.CanDragMap = true;
            this.gMapControlFlightPlaner.GrayScaleMode = false;
            this.gMapControlFlightPlaner.LevelsKeepInMemmory = 5;
            this.gMapControlFlightPlaner.Location = new System.Drawing.Point(3, 3);
            this.gMapControlFlightPlaner.MarkersEnabled = true;
            this.gMapControlFlightPlaner.MaxZoom = 18;
            this.gMapControlFlightPlaner.MinZoom = 0;
            this.gMapControlFlightPlaner.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControlFlightPlaner.Name = "gMapControlFlightPlaner";
            this.gMapControlFlightPlaner.NegativeMode = false;
            this.gMapControlFlightPlaner.PolygonsEnabled = true;
            this.gMapControlFlightPlaner.RetryLoadTile = 0;
            this.gMapControlFlightPlaner.RoutesEnabled = true;
            this.gMapControlFlightPlaner.ShowTileGridLines = false;
            this.gMapControlFlightPlaner.Size = new System.Drawing.Size(400, 471);
            this.gMapControlFlightPlaner.TabIndex = 0;
            this.gMapControlFlightPlaner.Zoom = 0D;
            this.gMapControlFlightPlaner.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControlFlightPlaner_OnMarkerClick);
            this.gMapControlFlightPlaner.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMapControlFlightPlaner_OnMapZoomChanged);
            this.gMapControlFlightPlaner.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControlFlightPlaner_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonGo);
            this.groupBox3.Controls.Add(this.textBoxLon);
            this.groupBox3.Controls.Add(this.textBoxLat);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(553, 580);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 73);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jump to";
            // 
            // buttonGo
            // 
            this.buttonGo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGo.Location = new System.Drawing.Point(254, 29);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(78, 24);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxLon
            // 
            this.textBoxLon.Location = new System.Drawing.Point(154, 32);
            this.textBoxLon.Name = "textBoxLon";
            this.textBoxLon.Size = new System.Drawing.Size(94, 20);
            this.textBoxLon.TabIndex = 3;
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(34, 32);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(94, 20);
            this.textBoxLat.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "lon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "lat";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxMapSource);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.trackBarMapZoom);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(553, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 97);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Map settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(243, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Use cache";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Map source";
            // 
            // comboBoxMapSource
            // 
            this.comboBoxMapSource.FormattingEnabled = true;
            this.comboBoxMapSource.Items.AddRange(new object[] {
            "Google maps",
            "Google satelite",
            "Google hybrid",
            "Bing maps",
            "Bing hybrid",
            "OSM"});
            this.comboBoxMapSource.Location = new System.Drawing.Point(100, 19);
            this.comboBoxMapSource.Name = "comboBoxMapSource";
            this.comboBoxMapSource.Size = new System.Drawing.Size(125, 21);
            this.comboBoxMapSource.TabIndex = 2;
            this.comboBoxMapSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxMapSource_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map zoom";
            // 
            // trackBarMapZoom
            // 
            this.trackBarMapZoom.Location = new System.Drawing.Point(100, 46);
            this.trackBarMapZoom.Maximum = 18;
            this.trackBarMapZoom.Name = "trackBarMapZoom";
            this.trackBarMapZoom.Size = new System.Drawing.Size(221, 45);
            this.trackBarMapZoom.TabIndex = 0;
            this.trackBarMapZoom.Scroll += new System.EventHandler(this.trackBarMapZoom_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.labelDistance);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(553, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 123);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Statistics";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(64, 16);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(45, 13);
            this.labelDistance.TabIndex = 1;
            this.labelDistance.Text = "0,00 km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Distance:";
            // 
            // mp_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gMapControlFlightPlaner);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);

            this.Size = new System.Drawing.Size(930, 674);
            this.Load += new System.EventHandler(this.mp_control_Load);
            this.Resize += new System.EventHandler(this.mp_control_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFliteplan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMapZoom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private GMap.NET.WindowsForms.GMapControl gMapControlFlightPlaner;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxLon;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMapSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarMapZoom;
        private System.Windows.Forms.Button buttonLoadFP;
        private System.Windows.Forms.Button buttonSaveFP;
        private System.Windows.Forms.Button buttonNewFP;
        public System.Windows.Forms.DataGridView dataGridViewFliteplan;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Special;
        private System.Windows.Forms.DataGridViewTextBoxColumn Next;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Button buttonDelite;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxOnclick;


    }
}
