using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class alertsForm : Form
    {
        Alert a = new Alert();
        public alertsForm()
        {
            
            InitializeComponent();
            
            statesListBox.Items.Clear();

            a.loadZones();
            List<string> stateList = a.getStateList();

            for (int i = 0; i < stateList.Count; i++)
            {
                if(stateList[i] != null)
                {
                    try
                    {
                        statesListBox.Items.Add(stateList[i].ToString());
                    } catch (Exception e)
                    {

                    }
                    
                }
            }
            //a.fetchJson(a.getURL(null));
            //List<Event> eves = a.makeEvent();
            //alertsDataGridView.DataSource = eves;
            //string alrtCnt = eves.Count().ToString();
            //this.alertCountTextBox.Text = alrtCnt;

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(2);
            var timer = new System.Threading.Timer((e) =>
            {
                Thread t = new Thread(new ThreadStart(alertsThread));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                while (t.IsAlive)
                {
                    Application.DoEvents();
                }
            }, null, startTimeSpan, periodTimeSpan);
        }

        private void statesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var state = statesListBox.SelectedItem.ToString();
            a.stateName = state;
            a.getCountyList(state);
            if (statesListBox.SelectedItem != null)
            {
                countiesListBox.Items.Clear();

                List<string> countyList = a.getCountyList(state);

                for (int i = 0; i < countyList.Count; i++)
                {
                    countiesListBox.Items.Add(countyList[i]);
                }
            }
            a.fetchJson(a.getURL(state));
            List<Event> eves = a.makeEvent();
            alertsDataGridView.DataSource = eves;
            string alrtCnt = eves.Count().ToString();
            this.alertCountTextBox.Text = alrtCnt;
        }

        private void alertsDataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var dataIndexNo = alertsDataGridView.Rows[e.RowIndex].Index.ToString();
            string alertID = alertsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            a.fetchJson("http://api.weather.gov/alerts/" + alertID.ToString());

            EventForm EventForm = new EventForm(a.alerts);
            EventForm.ShowDialog();
            
        }

        private void countiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var county = countiesListBox.SelectedItem.ToString();
            a.countyName = county;
            if (countiesListBox.SelectedItem != null)
            {

            }
            a.fetchJson(a.getURL(county));
            List<Event> eves = a.makeEvent();
            alertsDataGridView.DataSource = eves;
            string alrtCnt = eves.Count().ToString();
            this.alertCountTextBox.Text = alrtCnt;
        }
        //retrieves new data from nws server. Creates a list collection  and sets the datagridview to that collection.
        private void refreshAlerts()
        {
            //MessageBox.Show("It's working.");
            if (statesListBox.SelectedItem != null)
            {
                if (countiesListBox.SelectedItem != null)
                {
                    a.fetchJson(a.getURL(countiesListBox.SelectedItem.ToString()));
                }
                else
                {
                    a.fetchJson(a.getURL(statesListBox.SelectedItem.ToString()));
                }
            }
            else
            {
                a.fetchJson(a.getURL(null));
            }

            List<Event> eves = a.makeEvent();
            alertsDataGridView.DataSource = eves;
            string alrtCnt = eves.Count().ToString();
            this.alertCountTextBox.Text = alrtCnt;
        }
        private void alertsThread()
        {
            alertsDataGridView.Invoke((Action)delegate
            {
                refreshAlerts();
            });
            //TimeSpan interval = new TimeSpan(0, 1, 0);
        }
    }
}
