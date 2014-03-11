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
    public partial class main_window : Form
    {
        

        
        setup_controll mySetupControll = new setup_controll();
        mp_control myMpControl = new mp_control();
        settupIO setup = new settupIO();
        
        public main_window()
        {
            InitializeComponent();
        }

        private void showUserControl(int control)
        {
            mySetupControll.Visible = false;
            myMpControl.Visible = false;

            mySetupControll.Enabled = false;
            myMpControl.Enabled = false;
            
            
            switch (control)
            {
                case (0): { mySetupControll.Visible = true; mySetupControll.Enabled = true; break; }
                case (1): { myMpControl.Visible = true; myMpControl.Enabled = true; break; }

            }

        }
        private void loadUserControlls()
        {
            mySetupControll.Width = this.Width;
            mySetupControll.Height = this.Height - 24;
            mySetupControll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mySetupControll.Location = new Point(0, 24);



            myMpControl.Width = this.Width;
            myMpControl.Height = this.Height - 24;
            myMpControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            myMpControl.Visible = false;
            myMpControl.Location = new Point(0, 24);

            Controls.Add(myMpControl);
            Controls.Add(mySetupControll);
        }

        private void main_window_Load(object sender, EventArgs e)
        {
            loadUserControlls();
            showUserControl(0);
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void missionPlanerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUserControl(1);
            
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          setup Setup = new setup();
          var result = Setup.ShowDialog();
          if(result == DialogResult.OK)
          {
              settupIO.homeLat = Setup.lat;
              settupIO.homeLon = Setup.lon;
              setup.addParameter("homelat", Setup.lat.ToString());
              setup.addParameter("homelon", Setup.lon.ToString());
          }
        }
    }
}
