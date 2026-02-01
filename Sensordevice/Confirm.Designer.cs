namespace Sensordevice
{
    partial class FormConfirm
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
            buttonYes = new Button();
            buttonNo = new Button();
            labelText = new Label();
            textBoxValue = new TextBox();
            labelText2 = new Label();
            SuspendLayout();
            // 
            // buttonYes
            // 
            buttonYes.Enabled = false;
            buttonYes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonYes.Location = new Point(126, 107);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(75, 23);
            buttonYes.TabIndex = 0;
            buttonYes.Text = "Yes";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonNo.Location = new Point(227, 107);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(75, 23);
            buttonNo.TabIndex = 1;
            buttonNo.Text = "No";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelText.Location = new Point(12, 30);
            labelText.Name = "labelText";
            labelText.Size = new Size(275, 17);
            labelText.TabIndex = 2;
            labelText.Text = "Are you sure to empty the sensorlog table?";
            // 
            // textBoxValue
            // 
            textBoxValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            textBoxValue.Location = new Point(227, 63);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(75, 25);
            textBoxValue.TabIndex = 3;
            textBoxValue.TextChanged += textBoxValue_TextChanged;
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelText2.Location = new Point(12, 71);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(204, 17);
            labelText2.TabIndex = 4;
            labelText2.Text = "Write \"confirm\" to delete table!";
            // 
            // FormConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 142);
            Controls.Add(labelText2);
            Controls.Add(textBoxValue);
            Controls.Add(labelText);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfirm";
            ShowIcon = false;
            Text = "Ken's Sensor Device";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonYes;
        private Button buttonNo;
        private Label labelText;
        private TextBox textBoxValue;
        private Label labelText2;
    }
}