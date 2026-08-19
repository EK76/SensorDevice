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
            labelText5 = new Label();
            labelText6 = new Label();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(375, 212);
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
            labelText.Location = new Point(12, 18);
            labelText.Name = "labelText";
            labelText.Size = new Size(380, 45);
            labelText.TabIndex = 1;
            labelText.Text = "Sensor Device version 1.4";
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new Font("Segoe UI", 18F);
            labelText2.Location = new Point(12, 72);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(183, 32);
            labelText2.TabIndex = 2;
            labelText2.Text = "December 2025";
            // 
            // labelText3
            // 
            labelText3.AutoSize = true;
            labelText3.Font = new Font("Segoe UI", 18F);
            labelText3.Location = new Point(12, 115);
            labelText3.Name = "labelText3";
            labelText3.Size = new Size(150, 32);
            labelText3.TabIndex = 3;
            labelText3.Text = "Contact info:";
            // 
            // labelText4
            // 
            labelText4.AutoSize = true;
            labelText4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelText4.Location = new Point(18, 202);
            labelText4.Name = "labelText4";
            labelText4.Size = new Size(139, 21);
            labelText4.TabIndex = 4;
            labelText4.Text = "All rights reserved.";
            // 
            // labelText5
            // 
            labelText5.AutoSize = true;
            labelText5.Font = new Font("Segoe UI", 18F);
            labelText5.Location = new Point(168, 115);
            labelText5.Name = "labelText5";
            labelText5.Size = new Size(141, 32);
            labelText5.TabIndex = 5;
            labelText5.Text = "Ken Ekholm";
            // 
            // labelText6
            // 
            labelText6.AutoSize = true;
            labelText6.Font = new Font("Segoe UI", 18F);
            labelText6.Location = new Point(168, 147);
            labelText6.Name = "labelText6";
            labelText6.Size = new Size(249, 32);
            labelText6.TabIndex = 6;
            labelText6.Text = "ken.ekholm@live.com";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 246);
            Controls.Add(labelText6);
            Controls.Add(labelText5);
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
            Text = "Sensor Device";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label labelText;
        private Label labelText2;
        private Label labelText3;
        private Label labelText4;
        private Label labelText5;
        private Label labelText6;
    }
}