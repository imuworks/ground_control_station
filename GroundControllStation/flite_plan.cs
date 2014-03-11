using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroundControllStation
{
    class FlitePlan
    {

        public static List<FpPoint> fplan = new List<FpPoint>();
        

        private int pointsInflitePlan = 0;
        private int currentPoint = 0;
        DateTime timeCreated = new DateTime();

        public int PointsInflitePlan
        {
            get { return pointsInflitePlan; }
            set { pointsInflitePlan = value; }
        }


        public int CurrentPoint
        {
            get { return currentPoint; }
            set { currentPoint = value; }
        }
        
        

        public void Init()
        {
            pointsInflitePlan = 0;
            currentPoint = 0;
            timeCreated = DateTime.Now;
        }


        public int GetPointsInFp()
        {
            return pointsInflitePlan;
        }


        // creates new point in flight plan
        public bool Create(double lat, double lon, float alt, float speed, short special, string name, FpPoint.NextAction next)
        {
            FpPoint Point = new FpPoint();
            Point.Id = CurrentPoint;
            Point.Lat = lat;
            Point.Lon = lon;
            Point.Altitude = alt;
            Point.Setspeed = speed;
            Point.Special = special;

            if (string.Compare(name, "") == 0)
            {
                Point.Name = "Waypoint " + this.CurrentPoint;
            }
            else
            {
                Point.Name = name;
            }

            Point.Next = next;


            fplan.Add(Point);

            pointsInflitePlan++;
            currentPoint++;
            return true;
        }



        public bool Delite(int index)
        {
            bool retval = false;
            if (pointsInflitePlan > 1)
            {
                int i;
                FpPoint point = new FpPoint();
                fplan.RemoveAt(index);
                PointsInflitePlan--;
                currentPoint--;
                for (i = 0; i < fplan.Count; i++)
                {
                    EditID(i, i);
                    point = fplan.ElementAt(i);
                    if (point.Name.Contains("Waypoint "))
                    {
                        EditName(i, "Waypoint " + i.ToString());
                    }
                }
                EditAction(fplan.Count - 1, FpPoint.NextAction.GoHome);
                retval = true;
            }
            retval = false;
            return retval;

        }
            

        public bool Get(int i, out int id, out double lat, out double lon, out float alt, out float speed, out short special, out string name, out FpPoint.NextAction next)
        {
            bool retval = false;
            FpPoint point = new FpPoint();
            point = fplan.ElementAt(i);
            if (i < fplan.Count)
            {
                id = point.Id;
                lat = point.Lat;
                lon = point.Lon;
                alt = point.Altitude;
                speed = point.Setspeed;
                special = point.Special;
                name = point.Name;
                next = point.Next;
                retval = true;
            }
            else
            {
                id = 0;
                lat = 0;
                lon = 0;
                alt = 0;
                speed = 0;
                special = 0;
                name = "";
                next = FpPoint.NextAction.GoHome;
                retval = false;
            }
            return retval;
        }

        public bool Insert(int place, double lat, double lon, float alt, float speed, short special, string name, FpPoint.NextAction next)
        {
            FpPoint Point = new FpPoint();
            bool retval = false;
            if (place < PointsInflitePlan)
            {
                int i;
                Point.Id = place + 1;
                Point.Lat = lat;
                Point.Lon = lon;
                Point.Altitude = alt;
                Point.Setspeed = speed;
                Point.Special = special;
                Point.Name = "Waypoint ";
                
                fplan.Insert(place + 1, Point);

                for (i = 0; i < fplan.Count; i++)
                {
                    EditID(i, i);
                    Point = fplan.ElementAt(i);
                    if (Point.Name.Contains("Waypoint "))
                    {
                        EditName(i, "Waypoint " + i.ToString());
                    }
                }
                EditAction(fplan.Count - 1, FpPoint.NextAction.GoHome);
                PointsInflitePlan++;
                CurrentPoint++;
                retval = true;

            }
            else
            {
                retval = false;
            }
            return retval;
        }


        public bool GetLocation(int i, out double lat, out double lon)
        {
            bool retval = false;
            FpPoint point = new FpPoint();
            point = fplan.ElementAt(i);
            if (i < fplan.Count)
            {
                lat = point.Lat;
                lon = point.Lon;
                retval = true;
            }
            else
            {
                lat = 0;
                lon = 0;
                retval = false;
            }
            return retval;
        }

        
        public bool EditAction(int element, FpPoint.NextAction next)
        {
            FpPoint myPoint = new FpPoint();
            myPoint = fplan.ElementAt(element);
            myPoint.Next = next;
            fplan.RemoveAt(element);
            fplan.Insert(element, myPoint);
            return true;
        }

        public bool EditID (int element, int newval)
        {
            FpPoint myPoint = new FpPoint();
            myPoint = fplan.ElementAt(element);
            myPoint.Id = newval;
            fplan.RemoveAt(element);
            fplan.Insert(element, myPoint);
            return true;

        }

        public bool EditName(int element, string newName)
        {
            FpPoint myPoint = new FpPoint();
            myPoint = fplan.ElementAt(element);
            myPoint.Name = newName;
            fplan.RemoveAt(element);
            fplan.Insert(element, myPoint);
            return true;
        }

        public bool EditAlt(int element, float newVal)
        {
            FpPoint myPoint = new FpPoint();
            myPoint = fplan.ElementAt(element);
            myPoint.Altitude = newVal;
            fplan.RemoveAt(element);
            fplan.Insert(element, myPoint);
            return true;
        }

        public bool EditSpeed(int element, float newVal)
        {
            FpPoint myPoint = new FpPoint();
            myPoint = fplan.ElementAt(element);
            myPoint.Setspeed = newVal;
            fplan.RemoveAt(element);
            fplan.Insert(element, myPoint);
            return true;
        }

        public bool EditLat(int element, double newVal)
        {
            FpPoint myPoint = new FpPoint();
            myPoint = fplan.ElementAt(element);
            myPoint.Lat = newVal;
            fplan.RemoveAt(element);
            fplan.Insert(element, myPoint);
            return true;
        }

        public bool EditLon(int element, double newVal)
        {
            FpPoint myPoint = new FpPoint();
            myPoint = fplan.ElementAt(element);
            myPoint.Lon = newVal;
            fplan.RemoveAt(element);
            fplan.Insert(element, myPoint);
            return true;
        }


        public void Clear()
        {
            fplan.Clear();
            pointsInflitePlan = 0;
            currentPoint = 0;
        }


    }
}
