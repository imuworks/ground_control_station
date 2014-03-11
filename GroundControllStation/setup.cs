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
    public partial class setup : Form
    {
        public double lat, lon;
        settupIO mySetup = new settupIO();
       
        
        public setup()
        {
            InitializeComponent();

            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void setup_Load(object sender, EventArgs e)
        {
            mySetup.Read();
            textBoxLat.Text = settupIO.homeLat.ToString();
            textBoxLon.Text = settupIO.homeLon.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            double temp1;
            if (double.TryParse(textBoxLat.Text, out temp1))
            {
                this.lat = temp1;
            }

            if (double.TryParse(textBoxLon.Text, out temp1))
            {
                this.lon = temp1;
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
