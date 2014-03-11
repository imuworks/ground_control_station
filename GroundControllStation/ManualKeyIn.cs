using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroundControllStation
{
    public partial class ManualKeyIn : Form
    {

        public double Lat { get; set; }
        public double Lon { get; set; }
        public float Altitude { get; set; }
        public float Setspeed { get; set; }
        public short Special { get; set; }
        public string Name { get; set; }
        FpPoint.NextAction Next { get; set; }

        public ManualKeyIn()
        {
            InitializeComponent();
        }

        private void ManualKeyIn_Load(object sender, EventArgs e)
        {
            comboBoxAltUnit.Text = "m";
            comboBoxSpeedUnit.Text = "m/s";
            comboBoxNextAction.Text = "Go to next";

            buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double temp1;
            float temp2;
            short temp3;
            
            if (double.TryParse(textBoxLat.Text, out temp1)) // lat
            {
                this.Lat = temp1;
            }
            else
            {
            }


            if (double.TryParse(textBoxLon.Text, out temp1)) // lon
            {
                this.Lon = temp1;
            }
            else
            {
            }


            if (float.TryParse(textBoxAlt.Text, out temp2)) // alt
            {
                this.Altitude = temp2;
            }
            else
            {
            }



            if (float.TryParse(textBoxSpeed.Text, out temp2)) // speed
            {
                this.Setspeed = temp2;
            }
            else
            {
            }

            if (short.TryParse(textBoxLat.Text, out temp3)) // special
            {
                this.Special = temp3;
            }
            else
            {
            }


            switch (comboBoxNextAction.Text)
            {
                case ("Go to next"): this.Next = FpPoint.NextAction.GoToNextPoint; break;
                case ("Go home"): this.Next = FpPoint.NextAction.GoHome; break;
            }

            this.Name = textBoxName.Text;
            this.Close();
        }
    }
}
