using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundControllStation
{
    class FpPoint
    {
       private int id;
       private double lat;
       private double lon;
       private float altitude;
       private float setspeed;
       private short special;
       private string name;
       private NextAction next; 


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Lon
        {
            get { return lon; }
            set { lon = value; }
        }

        public float Altitude
        {
            get { return altitude; }
            set { altitude = value; }
        }

        public float Setspeed
        {
            get { return setspeed; }
            set { setspeed = value; }
        }

        public short Special
        {
            get { return special; }
            set { special = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public NextAction Next
        {
            get { return next; }
            set { next = value; }
        }

        public enum NextAction : byte
        {
            GoToNextPoint = 0,
            GoHome = 1
        };

        
    }
}
