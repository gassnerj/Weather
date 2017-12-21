using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Feature : Event
    {
        public List<string> geometry { get; set; }
        public string areaDesc { get; set; }
        public List<string> geocode { get; set; }
        public List<string> same { get; set; }
        public string sent { get; set; }
        public string effective { get; set; }
        public string onset { get; set; }
        public string expires { get; set; }
        public string ends { get; set; }
        public string status { get; set; }
        public string messageType { get; set; }
        public string category { get; set; }
        public string severity { get; set; }
        public string certainty { get; set; }
        public string urgency { get; set; }
        public string eventName { get; set; }
        public string sender { get; set; }
        public string eventDescription { get; set; }
        public string eventInstruction { get; set; }
        public string response { get; set; }

        Feature(string id)
        {

        }
    }


}
