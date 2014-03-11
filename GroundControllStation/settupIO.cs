using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GroundControllStation
{
    class settupIO
    {
     
        public static bool settingsRead = false;
        public static double homeLat = 46;
        public static double homeLon = 14;
        


        public bool Exists ()
        {
            return File.Exists("setup.con");
        }

        public bool Create ()
        {
            StreamWriter writer = new StreamWriter("setup.con");
            try 
            { 
            writer.WriteLine("homelat=" + homeLat.ToString());
            writer.WriteLine("homelon=" + homeLon.ToString());
            writer.Dispose();
            }
            catch 
            {
                    System.Windows.Forms.MessageBox.Show("Error creating configuration file");
            }

            
            return true;
        }

        public bool Read()
        {
            try
            {
                int count = File.ReadAllLines("setup.con").Count();
                StreamReader reader = new StreamReader("setup.con");
                string line;
                string[] split;
                for(int i = 0; i < count; i++)
                {
                    line = reader.ReadLine();
                    split = line.Split(new[] { "=" }, StringSplitOptions.None);
                    switch (split[0])
                    {
                        case ("homelat"): homeLat = double.Parse(split[1]); break;
                        case ("homelon"): homeLon = double.Parse(split[1]); break;
                        
                    }

                }
                reader.Dispose();
                settingsRead = true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error reading configuration file");
            }
            return true;            
        }

        public bool addParameter(string parameter, string value)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                string [] file = File.ReadAllLines("setup.con");
                string[] split;
           
                foreach(string line in file)
                {
                    split = line.Split(new[] { "=" }, StringSplitOptions.None);
                    if (string.Compare(parameter, split[0]) == 0)
                    {
                        sb.Append(parameter + "=" + value + "\n");
                    }
                    else
                    {
                        sb.Append(line + "\n");
                    }
                }
                File.WriteAllText("setup.con", sb.ToString());
            }
            catch
            {
               System.Windows.Forms.MessageBox.Show("Error editing configuration file"); 
            }
            return true;
        }

    }
 
	
}
