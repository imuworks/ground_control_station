namespace GroundControllStation
{
    partial class ManualKeyIn
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.textBoxLon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAlt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSpeedUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxAltUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNextAction = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOK.Location = new System.Drawing.Point(196, 95);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(78, 24);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancle
            // 
            this.buttonCancle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancle.Location = new System.Drawing.Point(280, 95);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(78, 24);
            this.buttonCancle.TabIndex = 12;
            this.buttonCancle.Text = "Cancle";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.buttonCancle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Latitude:";
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(66, 6);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(108, 20);
            this.textBoxLat.TabIndex = 14;
            // 
            // textBoxLon
            // 
            this.textBoxLon.Location = new System.Drawing.Point(66, 32);
            this.textBoxLon.Name = "textBoxLon";
            this.textBoxLon.Size = new System.Drawing.Size(108, 20);
            this.textBoxLon.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Longitue:";
            // 
            // textBoxAlt
            // 
            this.textBoxAlt.Location = new System.Drawing.Point(238, 32);
            this.textBoxAlt.Name = "textBoxAlt";
            this.textBoxAlt.Size = new System.Drawing.Size(61, 20);
            this.textBoxAlt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(187, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Altitude:";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(238, 6);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(61, 20);
            this.textBoxSpeed.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(187, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Speed:";
            // 
            // comboBoxSpeedUnit
            // 
            this.comboBoxSpeedUnit.FormattingEnabled = true;
            this.comboBoxSpeedUnit.Items.AddRange(new object[] {
            "m/s",
            "km/h",
            "knt",
            "mph"});
            this.comboBoxSpeedUnit.Location = new System.Drawing.Point(305, 5);
            this.comboBoxSpeedUnit.Name = "comboBoxSpeedUnit";
            this.comboBoxSpeedUnit.Size = new System.Drawing.Size(51, 21);
            this.comboBoxSpeedUnit.TabIndex = 21;
            // 
            // comboBoxAltUnit
            // 
            this.comboBoxAltUnit.FormattingEnabled = true;
            this.comboBoxAltUnit.Items.AddRange(new object[] {
            "m",
            "ft"});
            this.comboBoxAltUnit.Location = new System.Drawing.Point(305, 32);
            this.comboBoxAltUnit.Name = "comboBoxAltUnit";
            this.comboBoxAltUnit.Size = new System.Drawing.Size(51, 21);
            this.comboBoxAltUnit.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(187, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Next Action:";
            // 
            // comboBoxNextAction
            // 
            this.comboBoxNextAction.FormattingEnabled = true;
            this.comboBoxNextAction.Items.AddRange(new object[] {
            "Go to next",
            "Go Home",
            "Loiter"});
            this.comboBoxNextAction.Location = new System.Drawing.Point(259, 59);
            this.comboBoxNextAction.Name = "comboBoxNextAction";
            this.comboBoxNextAction.Size = new System.Drawing.Size(97, 21);
            this.comboBoxNextAction.TabIndex = 24;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(66, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(108, 20);
            this.textBoxName.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Name:";
            // 
            // ManualKeyIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(370, 127);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxNextAction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxAltUnit);
            this.Controls.Add(this.comboBoxSpeedUnit);
            this.Controls.Add(this.textBoxAlt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonOK);
            this.Name = "ManualKeyIn";
            this.Text = "Create new point";
            this.Load += new System.EventHandler(this.ManualKeyIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.TextBox textBoxLon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSpeedUnit;
        private System.Windows.Forms.ComboBox comboBoxAltUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNextAction;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
    }
}