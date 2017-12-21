using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Event
    {
        private string jsonAlerts { get; set; }
        //[System.ComponentModel.Browsable(false)]
        public string alertID { get; set; }

        //public string eventHeadline { get; set; }

        public string eventName { get; set; }
        //public Dictionary<string, string> events { get; set; }

        public Event()
        {
        }
    }
}
