using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace GroundControllStation
{
    public partial class mp_control : UserControl
    {

        private const int defaultAlt = 300;
        private const int defaultSpeed = 12;
        

        private bool addNewPoint = true; // used for figuring out if click was on existing point or new point hold be made



     FlitePlan MyFlitePlan = new FlitePlan();
     settupIO Setup = new settupIO();

        
        public mp_control()
        {
            InitializeComponent();
        }

       
        
        private void setSizes() // sets the sizes of controlls on form
        {
            gMapControlFlightPlaner.Height = this.Height;
            gMapControlFlightPlaner.Width = (int)(this.Width - 400);
        }
        
       
        
        private void mp_control_Load(object sender, EventArgs e)
        {
            setSizes();

            if (!Setup.Exists())
            {
                Setup.Create();
            }
            else
            {
                Setup.Read();
                if (MyFlitePlan.PointsInflitePlan == 0) // create home point if new fliteplan is being created
                {
                    MyFlitePlan.Create(settupIO.homeLat, settupIO.homeLon, defaultAlt, defaultSpeed, 0, "", FpPoint.NextAction.GoHome);
                }
                updateAll();
            }
            
            
            gMapControlFlightPlaner.MapProvider = GMapProviders.GoogleMap;
            gMapControlFlightPlaner.Position = new PointLatLng(settupIO.homeLat, settupIO.homeLon);
            gMapControlFlightPlaner.Zoom = 14;
            comboBoxMapSource.Text = "Google Maps";
            trackBarMapZoom.Value = (int)gMapControlFlightPlaner.Zoom;
            checkBoxOnclick.Checked = true;

           
        }
        

        private void mp_control_Resize(object sender, EventArgs e)
        {
            setSizes();
        }

        private void trackBarMapZoom_Scroll(object sender, EventArgs e)
        {
            gMapControlFlightPlaner.Zoom = trackBarMapZoom.Value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            
            double lat, lon = 0;
            if (double.TryParse(textBoxLat.Text, out lat) && double.TryParse(textBoxLon.Text, out lon))
                gMapControlFlightPlaner.Position = new PointLatLng(lat, lon);
            else
            {
                textBoxLat.Clear();
                textBoxLon.Clear();
            }

        }

        private void comboBoxMapSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMapSource.Text)
            {
                case ("Google maps"): gMapControlFlightPlaner.MapProvider = GMapProviders.GoogleMap; break;
                case ("Google satelite"): gMapControlFlightPlaner.MapProvider = GMapProviders.GoogleSatelliteMap; break;
                case ("Google hybrid"): gMapControlFlightPlaner.MapProvider = GMapProviders.GoogleHybridMap; break;
                case ("Bing maps"): gMapControlFlightPlaner.MapProvider = GMapProviders.BingMap; break;
                case ("Bing hybrid"): gMapControlFlightPlaner.MapProvider = GMapProviders.BingHybridMap; break;
                case ("OSM"): gMapControlFlightPlaner.MapProvider = GMapProviders.OpenStreetOsm; break;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            }
            else
            {
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            }
        }

        private void placePointOnMap(double lat, double lon, int type) //Draws sinle point on map
        {
            GMapMarkerGoogleRed waypoint = new GMapMarkerGoogleRed(new PointLatLng(lat, lon));
            GMapOverlay pointsOvetlay = new GMapOverlay(gMapControlFlightPlaner, "points");

            pointsOvetlay.Markers.Add(waypoint);
            gMapControlFlightPlaner.Overlays.Add(pointsOvetlay);
        }

        private void redrawPoints() // clears and draws all points in flightplan. Very useful, when you remove some points
        {
            
            GMapOverlay pointsOvetlay = new GMapOverlay(gMapControlFlightPlaner, "points");

            int i ;
            int id;
            double lat;
            double lon;
            float altitude;
            float setspeed;
            short special;
            string name;
            FpPoint.NextAction next;

           

            for (i = 0; i < MyFlitePlan.PointsInflitePlan; i++)
            {
                MyFlitePlan.Get(i, out id, out lat, out lon, out altitude, out setspeed, out special, out name, out next);
                GMapMarkerGoogleRed waypoint = new GMapMarkerGoogleRed(new PointLatLng(lat, lon));
                waypoint.ToolTipText = i.ToString();
                waypoint.ToolTipMode = MarkerTooltipMode.Always;
                pointsOvetlay.Markers.Add(waypoint);
            }
            
            gMapControlFlightPlaner.Overlays.Add(pointsOvetlay);

        }

        private void redrawRoutes()
        {
            int i;
            int id;
            double lat;
            double lon;
            float altitude;
            float setspeed;
            short special;
            string name;
            FpPoint.NextAction next;

            double len;
            
            List<PointLatLng> tracklist = new List<PointLatLng>();
            GMapOverlay routes = new GMapOverlay(gMapControlFlightPlaner, "routes");

            for (i = 0; i < MyFlitePlan.PointsInflitePlan; i++)
            {
                MyFlitePlan.Get(i, out id, out lat, out lon, out altitude, out setspeed, out special, out name, out next);
                tracklist.Add(new PointLatLng(lat, lon));
            }
            GMapRoute r = new GMapRoute(tracklist, "flight");
            r.Stroke.Width = 3;
            r.Stroke.Color = Color.Red;
            routes.Routes.Add(r);
            gMapControlFlightPlaner.Overlays.Add(routes);
            len = r.Distance;
            labelDistance.Text = (r.Distance.ToString("0.00 ") + "km");
        }

       
        
        private void updateAll()
        {
            gMapControlFlightPlaner.Overlays.Clear(); // delite points and tracks that are curently on the map
            redrawPoints(); // draw points
            redrawRoutes(); // draw routes
            updateGriView();//refresh grid view
        }

       
        
        private void gMapControlFlightPlaner_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                double lat = gMapControlFlightPlaner.FromLocalToLatLng(e.X, e.Y).Lat;
                double lon = gMapControlFlightPlaner.FromLocalToLatLng(e.X, e.Y).Lng;

                textBoxLat.Text = lat.ToString();
                textBoxLon.Text = lon.ToString();

                if (checkBoxOnclick.Checked)
                {
                    if (addNewPoint == true)
                    {
                        

                        if (dataGridViewFliteplan.SelectedRows.Count == 1) // insert point
                        {
                            DataGridViewCell cell;
                            DataGridViewSelectedRowCollection selected = dataGridViewFliteplan.SelectedRows;
                            int id;
                            string str;
                            foreach (DataGridViewRow row in selected)
                            {
                                if (row.Index != (MyFlitePlan.GetPointsInFp() - 1)) // if last row is selscted inser new point with go home directive
                                {
                                    cell = row.Cells[5];
                                    str = dataGridViewFliteplan.Rows[row.Index].Cells[5].Value.ToString();
                                    id = int.Parse(str);
                                    MyFlitePlan.Insert(id, lat, lon, defaultAlt, defaultSpeed, 0, "", FpPoint.NextAction.GoToNextPoint);
                                }
                                else
                                {
                                    MyFlitePlan.EditAction((MyFlitePlan.CurrentPoint - 1), FpPoint.NextAction.GoToNextPoint);
                                    MyFlitePlan.Create(lat, lon, defaultAlt, defaultSpeed, 0, "", FpPoint.NextAction.GoHome);
                                }

                            }

                        }

                        else // place new point
                        {
                            //place new point
                            if (MyFlitePlan.PointsInflitePlan == 0)
                            {
                                MyFlitePlan.Create(lat, lon, defaultAlt, defaultSpeed, 0, "", FpPoint.NextAction.GoHome);
                            }
                            else
                            {
                                MyFlitePlan.EditAction((MyFlitePlan.CurrentPoint - 1), FpPoint.NextAction.GoToNextPoint);
                                MyFlitePlan.Create(lat, lon, defaultAlt, defaultSpeed, 0, "", FpPoint.NextAction.GoHome);
                            }
                        }
                        updateAll();
                    }
                    else
                    {
                        addNewPoint = true;
                    }
                    
                }
            }
        }

        
        
         private void updateGriView()
        {
            int i;
            int id;
            double lat;
            double lon;
            float altitude;
            float setspeed;
            short special;
            string name;
            FpPoint.NextAction next;
            string tmp = "";

            dataGridViewFliteplan.Rows.Clear();
            for (i = 0; i < MyFlitePlan.PointsInflitePlan; i++)
            {
                MyFlitePlan.Get(i, out id, out lat, out lon, out altitude, out setspeed, out special, out name, out next);
                
                switch (next)
                {
                    case (FpPoint.NextAction.GoHome): tmp = "Go home"; break;
                    case(FpPoint.NextAction.GoToNextPoint):tmp = "Go to next point"; break;
                }

                dataGridViewFliteplan.Rows.Add(name, altitude.ToString(), setspeed.ToString(), lat.ToString(), lon.ToString(), id.ToString(), special.ToString(), tmp);
                
            }
        }

         
         
         private void buttonClear_Click(object sender, EventArgs e)
         {
             MessageBox.Show("Are you shure you want to delite all points in current flight plan?", "Delite everithing", MessageBoxButtons.YesNo);
             MyFlitePlan.Clear(); // clears all datapoints
             gMapControlFlightPlaner.Overlays.Clear(); // removes points from map
             gMapControlFlightPlaner.Refresh();
             dataGridViewFliteplan.Rows.Clear(); // clear data grid view
             labelDistance.Text = "0,00 km"; // reset distance meter
            
         }

         private void buttonDelite_Click(object sender, EventArgs e)
         {
             int id;
             string str;
             DataGridViewCell cell;
             DataGridViewSelectedRowCollection selected = dataGridViewFliteplan.SelectedRows;
             if (selected.Count != 0)
             {
                 foreach (DataGridViewRow row in selected)
                 {
                     //DataRow myRow = (row.DataBoundItem as DataRowView).Row;
                     cell = row.Cells[5];
                     str = dataGridViewFliteplan.Rows[row.Index].Cells[5].Value.ToString();
                     id = int.Parse(str);
                     MyFlitePlan.Delite(id);
         
                 }
                 updateAll();
             }
         }

         private void dataGridViewFliteplan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
         {
             if (e.ColumnIndex == 1 && e.RowIndex != -1) // alt  // if RowIndex == -1 that means value is being changed in hedding of gridDataView
             {
                 float temp;
                 if(float.TryParse((dataGridViewFliteplan.Rows[e.RowIndex].Cells[1].Value.ToString()),out temp) == true)
                 {
                     if (temp > 0)
                     {
                         MyFlitePlan.EditAlt(e.RowIndex, temp);
                     }
                 } 
             }
             else if (e.ColumnIndex == 3 && e.RowIndex != -1) // lat 
             {
                 double temp;
                 if(double.TryParse((dataGridViewFliteplan.Rows[e.RowIndex].Cells[3].Value.ToString()),out temp) == true)
                 {
                     if (-90 < temp && temp < 90)
                     {
                         MyFlitePlan.EditLat(e.RowIndex, temp);
                     }
                 }         
             }
             else if (e.ColumnIndex == 4 && e.RowIndex != -1) // lon
             {
                double temp;
                 if(double.TryParse((dataGridViewFliteplan.Rows[e.RowIndex].Cells[4].Value.ToString()),out temp) == true)
                 {
                     if (-180 < temp && temp < 180)
                     {
                         MyFlitePlan.EditLon(e.RowIndex, temp);
                     }
                 }
             }
             else if (e.ColumnIndex == 0 && e.RowIndex != -1) // name
             {
                MyFlitePlan.EditName(e.RowIndex, dataGridViewFliteplan.Rows[e.RowIndex].Cells[0].Value.ToString());
             }
             updateAll();  
             

         }

 

         private void buttonAdd_Click(object sender, EventArgs e)
         {
             ManualKeyIn mki = new ManualKeyIn();
             var result = mki.ShowDialog();
             if (result == DialogResult.OK)
             {
                 if (MyFlitePlan.PointsInflitePlan == 0)
                 {
                     MyFlitePlan.Create(mki.Lat, mki.Lon, mki.Altitude, mki.Setspeed, mki.Special, mki.Name, FpPoint.NextAction.GoHome);
                 }
                 else
                 {
                     MyFlitePlan.EditAction((MyFlitePlan.CurrentPoint - 1), FpPoint.NextAction.GoToNextPoint);
                     MyFlitePlan.Create(mki.Lat, mki.Lon, mki.Altitude, mki.Setspeed, mki.Special, mki.Name, FpPoint.NextAction.GoHome);
                     updateAll();
                 }
             }
         }

         private void gMapControlFlightPlaner_OnMapZoomChanged()
         {
             trackBarMapZoom.Value = (int)gMapControlFlightPlaner.Zoom;
         }

         private void gMapControlFlightPlaner_OnMarkerClick(GMapMarker item, MouseEventArgs e)
         {
             double lat;
             double lon;


             int n;
             addNewPoint = false; // prevents gmap.clik event from creating new point
             for (n = 0; n < MyFlitePlan.GetPointsInFp() - 1; n++)
             {
                 MyFlitePlan.GetLocation(n, out lat, out lon);
                 if (lat == item.Position.Lat && lon == item.Position.Lng) { break; }

             }

             dataGridViewFliteplan.Rows[n].Selected = true;

         }

         private void buttonNewFP_Click(object sender, EventArgs e)
         {
             dataGridViewFliteplan.Rows[1].Selected = true;
         }

    }
}
