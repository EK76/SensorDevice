namespace ReadTemp
{
    partial class FormTechnicalInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonClose = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            labelText = new Label();
            labelText2 = new Label();
            labelText3 = new Label();
            labelText4 = new Label();
            labelText6 = new Label();
            labelTex8 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(420, 750);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Sensordevice.Properties.Resources.raspberrypi5;
            pictureBox1.Location = new Point(12, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 207);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Sensordevice.Properties.Resources.dht22;
            pictureBox2.Location = new Point(337, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 157);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Sensordevice.Properties.Resources.schema;
            pictureBox3.Location = new Point(33, 346);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(430, 381);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelText.Location = new Point(17, 83);
            labelText.Name = "labelText";
            labelText.Size = new Size(87, 15);
            labelText.TabIndex = 4;
            labelText.Text = "Raspberry PI 5";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelText2.Location = new Point(337, 83);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(87, 15);
            labelText2.TabIndex = 5;
            labelText2.Text = "Sensor DHT22";
            // 
            // labelText3
            // 
            labelText3.AutoSize = true;
            labelText3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelText3.Location = new Point(12, 311);
            labelText3.Name = "labelText3";
            labelText3.Size = new Size(83, 15);
            labelText3.TabIndex = 6;
            labelText3.Text = "My schematic";
            // 
            // labelText4
            // 
            labelText4.AutoSize = true;
            labelText4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelText4.Location = new Point(66, 20);
            labelText4.Name = "labelText4";
            labelText4.Size = new Size(397, 42);
            labelText4.TabIndex = 7;
            labelText4.Text = "This is the harware and schematic that are used by \r\nKen's Sensor Device application.";
            // 
            // labelText6
            // 
            labelText6.AutoSize = true;
            labelText6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelText6.Location = new Point(337, 261);
            labelText6.Name = "labelText6";
            labelText6.Size = new Size(158, 30);
            labelText6.TabIndex = 10;
            labelText6.Text = "DHT22 is temperature and \r\nhumitidy sensor.";
            // 
            // labelTex8
            // 
            labelTex8.AutoSize = true;
            labelTex8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTex8.Location = new Point(476, 387);
            labelTex8.Name = "labelTex8";
            labelTex8.Size = new Size(0, 15);
            labelTex8.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(33, 733);
            label1.Name = "label1";
            label1.Size = new Size(356, 45);
            label1.TabIndex = 13;
            label1.Text = "Sensor DHT22 device's signal is connected to Rasepberry PI 5's\r\npin 12 (GPIO 18) where it reads the temperature and humitidy \r\nfrom sensor.";
            // 
            // FormTechnicalInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 785);
            Controls.Add(label1);
            Controls.Add(labelTex8);
            Controls.Add(labelText6);
            Controls.Add(labelText4);
            Controls.Add(labelText3);
            Controls.Add(labelText2);
            Controls.Add(labelText);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTechnicalInfo";
            Text = "Ken's Sensor Device";
            Load += FormTechnicalInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.Label labelText3;
        private System.Windows.Forms.Label labelText4;
        private System.Windows.Forms.Label labelText6;
        private System.Windows.Forms.Label labelTex8;
        private Label label1;
    }
}