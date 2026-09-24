using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTemp
{
    public partial class FormTechnicalInfo : Form
    {
        public FormTechnicalInfo()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTechnicalInfo_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"Pictures\raspberrypi5.jpg");
            pictureBox2.Image = Image.FromFile(@"Pictures\dht22.jpg");
            pictureBox3.Image = Image.FromFile(@"Pictures\schema.jpg");
        }
    }
}
