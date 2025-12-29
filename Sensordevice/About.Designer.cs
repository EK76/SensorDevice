namespace Sensordevice
{
    partial class FormAbout
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
            labelText = new Label();
            labelText2 = new Label();
            labelText3 = new Label();
            labelText4 = new Label();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(417, 319);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelText.Location = new Point(12, 46);
            labelText.Name = "labelText";
            labelText.Size = new Size(464, 45);
            labelText.TabIndex = 1;
            labelText.Text = "Ken's Sensor Device version 1.0";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new Font("Segoe UI", 18F);
            labelText2.Location = new Point(12, 119);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(183, 32);
            labelText2.TabIndex = 2;
            labelText2.Text = "December 2025";
            // 
            // labelText3
            // 
            labelText3.AutoSize = true;
            labelText3.Font = new Font("Segoe UI", 18F);
            labelText3.Location = new Point(12, 187);
            labelText3.Name = "labelText3";
            labelText3.Size = new Size(343, 32);
            labelText3.TabIndex = 3;
            labelText3.Text = "Contact: ken.ekholm@live.com";
            // 
            // labelText4
            // 
            labelText4.AutoSize = true;
            labelText4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelText4.Location = new Point(12, 254);
            labelText4.Name = "labelText4";
            labelText4.Size = new Size(139, 21);
            labelText4.TabIndex = 4;
            labelText4.Text = "All rights reserved.";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 354);
            Controls.Add(labelText4);
            Controls.Add(labelText3);
            Controls.Add(labelText2);
            Controls.Add(labelText);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowIcon = false;
            Text = "Ken's Sensor Device";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelText;
        private Label labelText2;
        private Label labelText3;
        private Label labelText4;
    }
}