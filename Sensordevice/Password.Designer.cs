namespace Sensordevice
{
    partial class FormPassword
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
            buttonSave = new Button();
            buttonClose = new Button();
            labelText = new Label();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(131, 88);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(228, 88);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(12, 18);
            labelText.Name = "labelText";
            labelText.Size = new Size(104, 15);
            labelText.TabIndex = 2;
            labelText.Text = "Set new password.";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 47);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(291, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // FormPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 121);
            Controls.Add(textBoxPassword);
            Controls.Add(labelText);
            Controls.Add(buttonClose);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPassword";
            ShowIcon = false;
            Text = "Ken's Sensor Device";
            Load += FormPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonClose;
        private Label labelText;
        private TextBox textBoxPassword;
    }
}