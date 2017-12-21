using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Weather
{
    class Alert
    {
        public string stateName { get; set; }
        public string countyName { get; set; }
        public string alertZone { get; set; }
        private string zones { get; set; }
        private Dictionary<string, string> zoneIDs { get; set; }
        public string alerts { get; set; }

        //TODO create methods for setting up each alert and displaying the data.

        public Alert()
        {
            this.alertZone = alertZone;
            this.zoneIDs = zoneIDs;
            this.alerts = alerts;
        }

        protected JToken getFeatures(string json)
        {
            try
            {
                JToken o = JObject.Parse(json);
                var features = o["features"];
                return features;
            } catch (Exception e)
            {
                return e.Message;
            }

        }

        public JToken getProperties(JToken feature)
        {
            try
            {
                JToken o = feature[0]["properties"];
                return o;
            } catch (Exception e)
            {
                return e.Message;
            }

        }

        public List<string> getStateList()
        {
            JToken features = this.getFeatures(this.zones);
            JToken properties = this.getProperties(features);

            List<string> statesList = new List<string>();
            Dictionary<string, string> zoneIDs = new Dictionary<string, string>();

            foreach (JToken feature in features) {
                statesList.Add((string)feature["properties"]["state"]);
                try
                {
                    zoneIDs[(string)feature["properties"]["name"]] = (string)feature["properties"]["id"];
                } catch (Exception)
                {

                }
                
            }
            this.zoneIDs = zoneIDs;
            List<string> states = statesList.Distinct().ToList();

            return states;

        }

        public List<string> getCountyList(string stateName)
        {
            if (stateName != null)
            {
                JToken features = this.getFeatures(this.zones);
                JToken properties = this.getProperties(features);

                List<string> countyList = new List<string>();
                

                foreach (JToken feature in features)
                {
                    if ((string)feature["properties"]["state"] == stateName) {
                        countyList.Add((string)feature["properties"]["name"]);
                    }
                }
                List<string> counties = countyList.Distinct().ToList();
                return counties;
            }
            else
            {
                return null;
            }
        }

        public string getURL(string areaName)
        {
            if (areaName != null && areaName.Length == 2)
            {

                
                try
                {
                    string url = ("https://api.weather.gov/alerts/active/area/" + areaName);
                    return url;
                }
                catch
                {
                    string url = "https://api.weather.gov/alerts/active/";
                    return url;
                }
            } else if (areaName != null && areaName.Length > 2)
            {
                string url = ("https://api.weather.gov/alerts/active/zone/" + zoneIDs[areaName]);
                return url;
            } else if (areaName == null)
            {
                string url = "https://api.weather.gov/alerts/active/";
                return url;
            }
            return null;
        }

        private void saveZones(string json)
        {
            using (StreamWriter writetext = new StreamWriter("zones.json"))
            {
                writetext.WriteLine(json);
            }
        }

        public void loadZones()
        {
            using (StreamReader zones = new StreamReader("zones.json"))
            {
                this.zones = zones.ReadToEnd();
            }
        }

        public void fetchJson()
        {
            String url = "https://api.weather.gov/zones";

            try
            {
                System.Net.HttpWebRequest POSTRequest = (HttpWebRequest)WebRequest.Create(url);
                POSTRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";

                POSTRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36";
                POSTRequest.KeepAlive = true;

                HttpWebResponse response = POSTRequest.GetResponse() as HttpWebResponse;

                using (Stream responseStream = response.GetResponseStream())
                {
                    System.IO.StreamReader reader = new StreamReader(responseStream);
                    string json = reader.ReadToEnd();
                    this.saveZones(json);
                    //this.zones = json;
                }
            }
            catch (HttpRequestException e)
            {
                Object msg = MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                Object msg1 = MessageBox.Show(e.Message);
                Object msg = MessageBox.Show(e.StackTrace);
            }
        }

        public void fetchJson(string url)
        {
            try
            {
                System.Net.HttpWebRequest POSTRequest = (HttpWebRequest)WebRequest.Create(url);
                POSTRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";

                POSTRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/59.0.3071.115 Safari/537.36";
                POSTRequest.KeepAlive = true;

                HttpWebResponse response = POSTRequest.GetResponse() as HttpWebResponse;

                using (Stream responseStream = response.GetResponseStream())
                {
                    System.IO.StreamReader reader = new StreamReader(responseStream);
                    string json = reader.ReadToEnd();
                    this.alerts = json;
                }
            }
            catch (HttpRequestException e)
            {
                Object msg = MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                Object msg1 = MessageBox.Show(e.Message);
                Object msg = MessageBox.Show(e.StackTrace);
            }
        }

        public List<Event> makeEvent()
        {
            List<Event> events = new List<Event>();

            JToken features = this.getFeatures(this.alerts);
            foreach (JToken feature in features)
            {
                Event eve = new Event();

                eve.alertID = (string)feature["properties"]["id"];
                //eve.areaDesc = (string)feature["properties"]["areaDesc"];
                eve.eventName = (string)feature["properties"]["event"];
                //eve.eventHeadline = (string)feature["properties"]["headline"];
                //eve.expires = (string)feature["properties"]["expires"];
                events.Add(eve);
                
            }
            return events;
        }

        public string checkToken(JToken token)
        {
            if (token != null)
            {
                string strNWSHeadline = (string)token;
                return strNWSHeadline;
            }
            else
            {
                string strNWSHeadline = "";
                return strNWSHeadline;
            }
        }
    }
}
