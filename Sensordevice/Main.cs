using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using Renci.SshNet.Common;
using secInfo;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sensordevice
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static string firstItem, lastItem, checkString, connString;
        public static List<string> listTemp = new List<string>();
        public static List<string> listHum = new List<string>();
        public static List<string> listDate = new List<string>();
        string fileName, newStartDate, newEndDate, passwordString, currentDate;
        DateTime startDate, endDate;
        int countItems, counterItems, countSelected, counterCheck;
        bool checkFile = true, checkOnce = false;
        string[] inputPass = File.ReadAllLines("input.txt");

        private void rowDeletions(int number)
        {

            int counterItems = 0;
            int countSelected = 1;
            int counterCheck = 0;

            foreach (ListViewItem deleteValue in listViewData.Items)
            {
                if (countSelected == number)
                {
                    this.listViewData.Items.RemoveAt(counterItems);
                    countSelected = 0;
                }
                else
                {
                    counterItems++;
                }
                countSelected++;
                counterCheck++;
            }
            toolStripStatusLabelRows.Text = "Numbers of rows: " + counterItems.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void deleteRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete selected rows?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                counterItems = 0;
                foreach (ListViewItem deleteValue in listViewData.Items)
                {
                    if (deleteValue.Selected)
                    {
                        this.listViewData.Items.Remove(deleteValue);
                    }
                    else 
                    {
                        counterItems++;
                    }
                }
            }
            saveToolStripMenuItem.Enabled = true;
            graphToolStripMenuItem.Enabled = listViewData.Items.Count > 1;
            saveToolStripMenuItem.Enabled = listViewData.Items.Count > 0;
            toolStripStatusLabelRows.Text = "Numbers of rows: " + counterItems.ToString();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = "";
            countItems = -1;
            counterItems = 0;
            OpenFileDialog openContent = new OpenFileDialog();

            openContent.Title = "Open Data";
            openContent.Filter = "Sensor Device File (.sdf) | *.sdf";

            try
            {

                if (openContent.ShowDialog() == DialogResult.OK)
                {
                    listViewData.Items.Clear();
                    StreamReader fileName = new StreamReader(openContent.FileName.ToString());
                    if (openContent.SafeFileName.Contains(".sdf"))
                    {
                        while ((line = fileName.ReadLine()) != null)
                        {
                            counterItems++;
                            countItems++;
                            var itemAdd = new ListViewItem(new[] { line.ToString().Split(';')[0].ToString(), line.ToString().Split(';')[1].ToString(), line.ToString().Split(';')[2].ToString() });
                            listViewData.Items.Add(itemAdd);
                        }
                        fileName.Close();
                        MessageBox.Show("File " + openContent.FileName.ToString() + " is susccessfully imported!");

                        clearDataToolStripMenuItem.Enabled = true;
                        deleteRowsToolStripMenuItem.Enabled = false;
                        saveToolStripMenuItem.Enabled = true;
                        saveToolStripMenuItem.Enabled = true;
                        graphToolStripMenuItem.Enabled = listViewData.Items.Count > 1;
                        firstItem = listViewData.Items[0].SubItems[2].Text;
                        lastItem = listViewData.Items[countItems].SubItems[2].Text;
                        toolStripStatusLabelLocation.Text = "Data from local sdf file (" + openContent.FileName.ToString() + ").";
                        toolStripStatusLabelRows.Text = "Numbers of rows: " + counterItems.ToString();
                    }
                    else
                    {
                        MessageBox.Show(("This application supports only sdf files"));
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Error message:" + i.Message);
            }
            graphToolStripMenuItem.Enabled = listViewData.Items.Count > 1;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog saveContent = new SaveFileDialog();

            saveContent.Title = "Save Data";
            saveContent.Filter = "Sensor Device File (.sdf) | *.sdf";

            try
            {
                if (saveContent.ShowDialog() == DialogResult.OK)
                {
                    filename = saveContent.FileName.ToString();
                    if (filename != "")
                    {
                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            foreach (ListViewItem item in listViewData.Items)
                            {
                                sw.WriteLine("{0}{1}{2}", item.SubItems[0].Text + ";", item.SubItems[1].Text + ";", item.SubItems[2].Text + ";");
                            }
                        }
                        MessageBox.Show("File " + filename + " is susccessfully saved!");
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEndDate.MinDate = dateTimePickerStartDate.Value;
            dateTimePickerEndDate.Enabled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int counterItems = 0, countItems = -1;
            startDate = dateTimePickerStartDate.Value;
            endDate = dateTimePickerEndDate.Value;
            endDate = endDate.AddDays(1);

            newStartDate = startDate.ToString("yyyy-MM-dd");
            newEndDate = endDate.ToString("yyyy-MM-dd");
            try
            {

                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                checkString = "select id, temp, hum, datecreated from sensorlog where datecreated between '" + newStartDate + "' and '" + newEndDate + "';";
                Clipboard.SetText(checkString);
                MySqlCommand command = new MySqlCommand(checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    counterItems++;
                    if (counterItems == 1)
                    {
                        listViewData.Items.Clear();
                    }
                    countItems++;
                    listViewData.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("temp").ToString() + " °C", reader.GetDecimal("hum").ToString() + " %", reader.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:mm") }));
                }
                conn.Close();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }

            if (counterItems == 0)
            {
                MessageBox.Show("The search was not result!");
            }
            else
            {
                clearDataToolStripMenuItem.Enabled = true;
                deleteRowsToolStripMenuItem.Enabled = false;
                deleteRows2ToolStripMenuItem.Enabled = listViewData.Items.Count > 6;
                saveToolStripMenuItem.Enabled = true;
                graphToolStripMenuItem.Enabled = listViewData.Items.Count > 1;
                firstItem = listViewData.Items[0].SubItems[2].Text;
                lastItem = listViewData.Items[countItems].SubItems[2].Text;
                toolStripStatusLabelLocation.Text = "Data from database.";
                toolStripStatusLabelRows.Text = "Numbers of rows: " + counterItems.ToString();
            }
        }

        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear data?", "Ken's Sensor Device.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listViewData.Clear();
                deleteRowsToolStripMenuItem.Enabled = false;
                deleteRows2ToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                graphToolStripMenuItem.Enabled = false;
                clearDataToolStripMenuItem.Enabled = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists("input.txt"))
            {
                File.AppendAllText("input.txt", "/I3fm5KQBMDtNRIFgmL6MoNItLySzzxg");
                checkFile = false;
            }


            if (checkFile == false)
            {
                MessageBox.Show("Application must restarted to fix configurations problem.");
                Close();
            }

            connString = "SERVER = sensordevice; DATABASE = sensorinfo; UID = loguser; PASSWORD =";
            passwordString = Security.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";


        }

        private void listViewData_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRowsToolStripMenuItem.Enabled = listViewData.SelectedItems.Count > 0;
          //  deleteRows2ToolStripMenuItem.Enabled = listViewData.SelectedItems.Count > 6;

            if (listViewData.Items.Count < 0)
            {
                saveToolStripMenuItem.Enabled = false;
                graphToolStripMenuItem.Enabled = false;
            }
            else
            {
                clearDataToolStripMenuItem.Enabled = true;
            }
        }

        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listTemp.Clear();
            listHum.Clear();
            listDate.Clear();

            foreach (ListViewItem item in listViewData.Items)
            {
                listTemp.Add(item.SubItems[0].Text);
                listHum.Add(item.SubItems[1].Text);
                listDate.Add(item.SubItems[2].Text);
            }
            FormGraph graph = new FormGraph();
            graph.ShowDialog();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smallToolStripMenuItem.Checked = true;
            mediumToolStripMenuItem.Checked = false;
            largeToolStripMenuItem.Checked = false;
            listViewData.Font = new System.Drawing.Font("Segoe UI", 12f);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smallToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = true;
            largeToolStripMenuItem.Checked = false;
            listViewData.Font = new System.Drawing.Font("Segoe UI", 16f);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smallToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            largeToolStripMenuItem.Checked = true;
            listViewData.Font = new System.Drawing.Font("Segoe UI", 22f);
        }


        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to empty the sensorlog table", "Ken's SensorDevice", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    checkString = "delete from sensorlog";
                    MySqlCommand command = new MySqlCommand(checkString, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    conn.Close();
                    listViewData.Clear();
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog saveContent = new SaveFileDialog();

            saveContent.Title = "Backup";
            saveContent.Filter = "MysSQL Backup File (.sql) | *.sql";
            try
            {
                if (saveContent.ShowDialog() == DialogResult.OK)
                {
                    filename = saveContent.FileName.ToString();
                    if (filename != "")
                    {
                        using (MySqlConnection conn = new MySqlConnection(connString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    mb.ExportToFile(filename);
                                    conn.Close();
                                }
                            }
                        }
                        MessageBox.Show("File " + filename + " is susccessfully backuped!");
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void restoreDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "";
            OpenFileDialog openContent = new OpenFileDialog();

            openContent.Title = "Restore";
            openContent.Filter = "MysSQL Backup File (.sql) | *.sql";

            try
            {
                if (openContent.ShowDialog() == DialogResult.OK)
                {
                    fileName = openContent.FileName.ToString();
                    {
                        using (MySqlConnection conn = new MySqlConnection(connString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                using (MySqlBackup mb = new MySqlBackup(cmd))
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    mb.ImportFromFile(fileName);
                                    conn.Close();
                                }
                            }
                        }
                        MessageBox.Show("File " + fileName + " is susccessfully restored!");
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void dateTimePickerStartDate_Enter(object sender, EventArgs e)
        {
            DateTime currentDay = DateTime.Today;
            dateTimePickerStartDate.MaxDate = currentDay;
        }

        private void checkBoxSetDay_CheckedChanged(object sender, EventArgs e)
        {
            counterItems = 0;
            countItems = -1;
            currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            if (checkBoxSetDay.Checked)
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                checkString = "select temp, hum, datecreated from sensorlog where datecreated like '" + currentDate + "%';";
                MySqlCommand command2 = new MySqlCommand(checkString, conn);
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    counterItems++;
                    countItems++;
                    if (counterItems == 1)
                    {
                        listViewData.Items.Clear();
                    }
                    listViewData.Items.Add(new ListViewItem(new string[] { reader2.GetDecimal("temp").ToString() + " °C", reader2.GetDecimal("hum").ToString() + " %", reader2.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:mm") }));
                }
                if (counterItems == 0)
                {
                    MessageBox.Show("The search gave no result!", "Ken's Sensor Devicecle.");
                }
                else
                {
                    deleteRowsToolStripMenuItem.Enabled = false;
                    saveToolStripMenuItem.Enabled = true;
                    clearDataToolStripMenuItem.Enabled = true;
                    graphToolStripMenuItem.Enabled = listViewData.Items.Count > 1;
                    deleteRows2ToolStripMenuItem.Enabled = listViewData.Items.Count > 6;
                    firstItem = listViewData.Items[0].SubItems[2].Text;
                    lastItem = listViewData.Items[countItems].SubItems[2].Text;
                    toolStripStatusLabelLocation.Text = "Data from database.";
                    toolStripStatusLabelRows.Text = "Numbers of rows: " + counterItems.ToString();
                    buttonSearch.Enabled = false;
                    dateTimePickerStartDate.Enabled = false;
                    dateTimePickerEndDate.Enabled = false;
                }
                conn.Close();
            }
            else
            {
                buttonSearch.Enabled = true;
                dateTimePickerStartDate.Enabled = true;
                dateTimePickerEndDate.Enabled = true;
            }
        }

        private void tableInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string showStartDate, showEndDate;
            int number;

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            checkString = "select datecreated from sensorlog order by datecreated asc limit 1;";
            MySqlCommand command = new MySqlCommand(checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            showStartDate = reader.GetDateTime("datecreated").ToString("dd.MM.yyyy HH:mm");
            conn.Close();

            conn.Open();
            checkString = "select datecreated from sensorlog order by datecreated desc limit 1;";
            MySqlCommand command2 = new MySqlCommand(checkString, conn);
            MySqlDataReader reader2 = command2.ExecuteReader();
            reader2.Read();
            showEndDate = reader2.GetDateTime("datecreated").ToString("dd.MM.yyyy HH:mm");
            conn.Close();

            conn.Open();
            checkString = "select count(*) as 'number' from sensorlog;";
            MySqlCommand command3 = new MySqlCommand(checkString, conn);
            MySqlDataReader reader3 = command3.ExecuteReader();
            reader3.Read();
            number = reader3.GetInt32("number");
            conn.Close();

            MessageBox.Show("Number of rows: " + number.ToString() + " \n First entry: " + showStartDate + "\n Last entry: " + showEndDate, "Ken's Sensor Device", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteRowsNth2_Click(object sender, EventArgs e)
        {
            rowDeletions(2);
        }

        private void deleteRowsNth3_Click(object sender, EventArgs e)
        {
            rowDeletions(3);
        }

        private void deleteRowsNth4_Click(object sender, EventArgs e)
        {
            rowDeletions(4);
        }

        private void deleteRowsNth5_Click(object sender, EventArgs e)
        {
            rowDeletions(5);
        }
    }
}
