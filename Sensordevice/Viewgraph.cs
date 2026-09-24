using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Sensordevice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CameraDevice
{
    public partial class FormViewgraph : Form
    {
        public FormViewgraph()
        {
            InitializeComponent();
        }

        List<int> dateCounts = new List<int>();
        List<int> topicCounts = new List<int>();
        int dateNumbers, topicNumbers, count, checkCount, index, index2;
        string checkString;

        void dateView()
        {
            this.Size = new Size(835, 620);
            listBoxShowTopics.Visible = false;
            chartView.Series[0].Points.Clear();
            MySqlConnection conn = new MySqlConnection(FormMain.connString);
            dateNumbers = FormLogs.listDates.Count;
            dateCounts.Clear();

            for (int index = 0; index < dateNumbers; index++)
            {
                conn.Open();
                checkString = "select count(*) from loginfo where datecreated like '" + FormLogs.listDates[index] + "%'";
                MySqlCommand command = new MySqlCommand(checkString, conn);
                count = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();
                dateCounts.Add(count);
                checkCount++;
                conn.Close();
            }

            index = 0;
            index2 = 1;

            foreach (var addValue in dateCounts)
            {
                chartView.Series[0].Points.AddXY(index2, addValue);
                chartView.Series[0].Points[index].Label = addValue.ToString();
                chartView.Series[0].Points[index].AxisLabel = FormLogs.listDates[index].ToString();
                index++;
                index2++;
            }
        }

        void topicView()
        {
            this.Size = new Size(1085, 620);
            listBoxShowTopics.Visible = true;
            chartView.Series[0].Points.Clear();
            MySqlConnection conn = new MySqlConnection(FormMain.connString);
            topicNumbers = FormLogs.listTopics.Count;
            topicCounts.Clear();

            for (int index = 0; index < topicNumbers; index++)
            {
                conn.Open();
                checkString = "select count(*) from loginfo where logtext like '" + FormLogs.listTopics[index] + "%'";
                MySqlCommand command = new MySqlCommand(checkString, conn);
                count = Convert.ToInt32(command.ExecuteScalar());
                conn.Close();
                topicCounts.Add(count);
                checkCount++;
            }

            index = 0;
            index2 = 1;
            listBoxShowTopics.Items.Clear();
            foreach (var addValue in topicCounts)
            {
               chartView.Series[0].Points.AddXY(index2, addValue);
               chartView.Series[0].Points[index].Label = addValue.ToString();
                chartView.ChartAreas[0].AxisX.Interval = 1;
               chartView.Series[0].Points[index].AxisLabel = index2.ToString();

               listBoxShowTopics.Items.Add(index2.ToString()+ ". " + FormLogs.listTopics[index].ToString());
               index++;
               index2++;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Viewgraph_Load(object sender, EventArgs e)
        {
            dateView();
        }
        private void radioButtonShowDates_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonShowDates.Checked)
            {
                dateView();
            }
        }

        private void radioButtonShowTopics_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonShowTopics.Checked)
            {
                topicView();
            }  
        }
    }
}
