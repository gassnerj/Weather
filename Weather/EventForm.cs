using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class EventForm : Form
    {
        private string alerts;

        public EventForm(string alerts)
        {
            InitializeComponent();
            this.Font = new Font("Arial", 12, FontStyle.Bold);
            this.descTextBox.Font = new Font("Arial", 10, FontStyle.Regular);
            this.instrctTextBox.Font = new Font("Arial", 10, FontStyle.Regular);
            this.areaTextBox.Font = new Font("Arial", 10, FontStyle.Regular);

            Alert a = new Alert();
            this.alerts = alerts;

            JToken eve = JToken.Parse(this.alerts);

            this.Text = (string)eve["properties"]["headline"];
            string strEvent = (string)eve["properties"]["event"];
            string strDesc = (string)eve["properties"]["description"];
            string strInstruct = (string)eve["properties"]["instruction"];
            string strExpires = (string)eve["properties"]["expires"];
            string strSeverity = (string)eve["properties"]["severity"];
            string strSender = (string)eve["properties"]["sender"];
            string strArea = (string)eve["properties"]["areaDesc"];

            //if (eve["properties"]["parameters"]["NWSheadline"][0] != null)
            //{
            //    string strNWSHeadline = (string)eve["properties"]["parameters"]["NWSheadline"][0];
            //    this.groupBox1.Text = strNWSHeadline;
            //}
                


            this.eventTextBox.Text = strEvent;
            this.descTextBox.Text = strDesc.Replace("\n", Environment.NewLine);
            this.instrctTextBox.Text = strInstruct.Replace("\n", Environment.NewLine);
            this.expiresTextBox.Text = strExpires;
            this.severityTextBox.Text = strSeverity;
            this.senderTextBox.Text = strSender;
            this.areaTextBox.Text = strArea;
            

            switch (strEvent)
            {
                case "Winter Storm Warning":
                    this.eventTextBox.BackColor = Color.Blue;
                    this.eventTextBox.ForeColor = Color.White;
                    break;
                case "Severe Thunderstorm Warning":
                    this.eventTextBox.BackColor = Color.Yellow;
                    this.eventTextBox.ForeColor = Color.Black;
                    break;
                case "Tornado Warning":
                    this.eventTextBox.BackColor = Color.Red;
                    this.eventTextBox.ForeColor = Color.White;
                    break;
                case "Dense Fog Advisory":
                    this.eventTextBox.BackColor = Color.Gray;
                    this.eventTextBox.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
