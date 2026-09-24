using MySql.Data.MySqlClient;
using secInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using secInfo;

namespace Sensordevice
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        string[] inputPass = File.ReadAllLines("input.txt");
        string connString, passwordString, checkString;

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                checkString = "alter user 'sensorlog'@'loguser' IDENTIFIED BY '" + textBoxPassword.Text + "';";
                Clipboard.SetText(checkString);
                MySqlCommand command = new MySqlCommand(checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                conn.Close();

                passwordString = Security.encrypt(textBoxPassword.Text, "weather");
                File.WriteAllText(System.Environment.CurrentDirectory + "\\input.txt", textBoxPassword.Text);
                FormMain.connString = FormMain.connString + passwordString;
                MessageBox.Show("New password set!");
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }

        }

        private void FormPassword_Load(object sender, EventArgs e)
        {
            connString = "SERVER = sensordevice; DATABASE = sensorinfo; UID = loguser; PASSWORD =";
            passwordString = Security.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
            labelText.Text = "Set database's password";
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                buttonSave.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = true;
            }
        }
    }
}
