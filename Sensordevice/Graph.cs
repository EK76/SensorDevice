using Google.Protobuf.Collections;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sensordevice
{
    public partial class FormGraph : Form
    {
        public FormGraph()
        {
            InitializeComponent();
        }

        int addPoint, point = 0;
        string addNewValue;
        decimal convertValue;
        List<decimal> listSum = new List<decimal>();
        List<decimal> listSum2 = new List<decimal>();
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (detailsToolStripMenuItem.Checked == true)
            {
                panelInfo.Visible = false;
                detailsToolStripMenuItem.Checked = false;
            }
            else
            {
                panelInfo.Visible = true;
                detailsToolStripMenuItem.Checked = true;
            }
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTemp.Series[0].MarkerStyle = MarkerStyle.Circle;
            chartHum.Series[0].MarkerStyle = MarkerStyle.Circle;
            chartTemp.Series[0].MarkerSize = 16;
            chartHum.Series[0].MarkerSize = 16;
            chartTemp.Series[0].BorderColor = Color.Black;
            chartHum.Series[0].BorderColor = Color.Black;
            circleToolStripMenuItem.Checked = true;
            triangleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            starToolStripMenuItem.Checked = false;
            noneToolStripMenuItem.Checked = false;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTemp.Series[0].MarkerStyle = MarkerStyle.Triangle;
            chartHum.Series[0].MarkerStyle = MarkerStyle.Triangle;
            circleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = true;
            squareToolStripMenuItem.Checked = false;
            starToolStripMenuItem.Checked = false;
            noneToolStripMenuItem.Checked = false;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTemp.Series[0].MarkerStyle = MarkerStyle.Square;
            chartHum.Series[0].MarkerStyle = MarkerStyle.Square;
            circleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = true;
            starToolStripMenuItem.Checked = false;
            noneToolStripMenuItem.Checked = false;
        }

        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTemp.Series[0].MarkerStyle = MarkerStyle.Star5;
            chartHum.Series[0].MarkerStyle = MarkerStyle.Star5;
            circleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            starToolStripMenuItem.Checked = true;
            noneToolStripMenuItem.Checked = false;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTemp.Series[0].MarkerSize = 8;
            chartHum.Series[0].MarkerSize = 8;
            smallToolStripMenuItem.Checked = true;
            mediumToolStripMenuItem.Checked = false;
            largeToolStripMenuItem.Checked = false;

        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTemp.Series[0].MarkerSize = 16;
            chartHum.Series[0].MarkerSize = 16;
            smallToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = true;
            largeToolStripMenuItem.Checked = false;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTemp.Series[0].MarkerSize = 22;
            chartHum.Series[0].MarkerSize = 22;
            smallToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            largeToolStripMenuItem.Checked = true;
        }

        private void markerColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                chartTemp.Series[0].MarkerColor = colorDialog1.Color;
                chartTemp.Series[0].BorderColor = colorDialog1.Color;
                chartHum.Series[0].MarkerColor = colorDialog1.Color;
                chartHum.Series[0].BorderColor = colorDialog1.Color;
            }
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTemp.Series[0].MarkerSize = 16;
            chartHum.Series[0].MarkerSize = 16;
            chartTemp.Series[0].MarkerStyle = MarkerStyle.Circle;
            chartHum.Series[0].MarkerStyle = MarkerStyle.Circle;
            chartTemp.Series[0].MarkerColor = Color.Black;
            chartTemp.Series[0].BorderColor = Color.Black;
            chartHum.Series[0].MarkerColor = Color.Black;
            chartHum.Series[0].BorderColor = Color.Black;

            smallToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = true;
            largeToolStripMenuItem.Checked = false;

            circleToolStripMenuItem.Checked = true;
            triangleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            starToolStripMenuItem.Checked = false;
            noneToolStripMenuItem.Checked = false;
        }

        private void FormGraph_Load(object sender, EventArgs e)
        {
            chartTemp.Update();
            try
            {
                chartTemp.Update();
                chartTemp.Series[0].LegendText = "Temperature";
                chartTemp.ChartAreas[0].AxisY.Title = "Celsius";
                chartTemp.ChartAreas[0].AxisY.Minimum = -40;
                chartTemp.ChartAreas[0].AxisY.Maximum = 40;
                chartTemp.ChartAreas[0].AxisY.Interval = 10;
                chartTemp.ChartAreas[0].AxisY.MinorGrid.Interval = chartTemp.ChartAreas[0].AxisY.Interval / 2;
                addPoint = -1;

                foreach (var addValue in FormMain.listTemp)
                {
                    addPoint++;

                    addNewValue = addValue;
                    var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                    foreach (var rc in removeChars)
                    {
                        addNewValue = addNewValue.Replace(rc, string.Empty);
                    }
                    convertValue = decimal.Parse(addNewValue);

                    chartTemp.Series[0].Points.AddXY(addPoint, convertValue);
                    listSum.Add(convertValue);
                }

            }
            catch (Exception message)
            {
                MessageBox.Show(message.ToString());
            }

            Title showTemp = chartTemp.Titles.Add("Temperature");
            showTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, FontStyle.Bold);

            chartHum.Update();
            try
            {
                chartHum.Update();
                chartHum.Series[0].LegendText = "Humidity";
                chartHum.ChartAreas[0].AxisY.Title = "%";
                chartHum.ChartAreas[0].AxisY.Minimum = 0;
                chartHum.ChartAreas[0].AxisY.Maximum = 100;
                chartHum.ChartAreas[0].AxisY.Interval = 10;
                chartTemp.ChartAreas[0].AxisY.MinorGrid.Interval = chartHum.ChartAreas[0].AxisY.Interval / 2;
                addPoint = -1;

                foreach (var addValue in FormMain.listHum)
                {
                    addPoint++;

                    addNewValue = addValue;
                    var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                    foreach (var rc in removeChars)
                    {
                        addNewValue = addNewValue.Replace(rc, string.Empty);
                    }
                    convertValue = decimal.Parse(addNewValue);

                    chartHum.Series[0].Points.AddXY(addPoint, convertValue);
                    listSum2.Add(convertValue);
                }

            }
            catch (Exception message)
            {
                MessageBox.Show(message.ToString());
            }

            Title showHum = chartHum.Titles.Add("Temperature");
            showHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, FontStyle.Bold);

            labelMedium.Text = "Medium value: " + Math.Round(listSum.Average(), 1) + " °C " + Math.Round(listSum2.Average(), 1) + " %";
            labelMin.Text = "Min value: " + listSum.Min() + " °C " + listSum2.Min() + " %";
            labelMax.Text = "Max value: " + listSum.Max() + " °C " + listSum2.Min() + " %";
            labelStartDate.Text = "Start date " + FormMain.listDate.First();
            labelEndDate.Text = "End date " + FormMain.listDate.Last();
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTemp.Series[0].MarkerStyle = MarkerStyle.None;
            chartHum.Series[0].MarkerStyle = MarkerStyle.None;
            circleToolStripMenuItem.Checked = false;
            triangleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = false;
            starToolStripMenuItem.Checked = false;
            noneToolStripMenuItem.Checked = true;
        }

        private void chartTemp_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            var showValue = chartTemp.HitTest(e.X, e.Y);
            if ((e.HitTestResult.ChartElementType == ChartElementType.DataPoint))
            {
                var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                point = showValue.PointIndex;
                e.Text = string.Format("Date: {0}\n" + "Temperature " + ": {1} " + " °C", FormMain.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
                labelInfo.Text = string.Format("Date: {0}\n" + "Temperature " + ":{1} " + " °C", FormMain.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
            }
            else
            {
                labelInfo.Text = "";
            }

        }

        private void chartHum_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            var showValue = chartHum.HitTest(e.X, e.Y);
            if ((e.HitTestResult.ChartElementType == ChartElementType.DataPoint))
            {
                var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                point = showValue.PointIndex;
                e.Text = string.Format("Date: {0}\n" + "Humitidy " + ": {1} " + " %", FormMain.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
                labelInfo.Text = string.Format("Date: {0}\n" + "Humitidy " + ":{1} " + " %", FormMain.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
            }
            else
            {
                labelInfo.Text = "";
            }
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                chartTemp.SaveImage(mStream, ChartImageFormat.Bmp);
                Bitmap chartImage = new Bitmap(mStream);
                Clipboard.SetImage(chartImage);
            }
            MessageBox.Show("Chart diagram copied!");

        }

        private void humitidyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                chartHum.SaveImage(mStream, ChartImageFormat.Bmp);
                Bitmap chartImage = new Bitmap(mStream);
                Clipboard.SetImage(chartImage);
            }
            MessageBox.Show("Chart diagram copied!");

        }

        private void temperatureToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "png Image|*.png|jpeg Image|*.jpg";
            saveFileDialog.Title = "Save Chart As Image File";
            saveFileDialog.FileName = "chart";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        if (saveFileDialog.FilterIndex == 2)
                        {
                            chartTemp.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1)
                        {
                            chartTemp.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.Message);

                }
            }
        }

        private void humitidyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "png Image|*.png|jpeg Image|*.jpg";
            saveFileDialog.Title = "Save Chart As Image File";
            saveFileDialog.FileName = "chart";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        if (saveFileDialog.FilterIndex == 2)
                        {
                            chartHum.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1)
                        {
                            chartHum.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.Message);

                }
            }
        }


    }
}

