namespace CameraDevice
{
    partial class FormLogs
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
            listViewLogs = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            labelText = new Label();
            comboBoxSelection = new ComboBox();
            comboBoxDate = new ComboBox();
            labelDateStart = new Label();
            labelDateEnd = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            backupLogsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            boldTextToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            graphToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelSelection = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewLogs
            // 
            listViewLogs.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewLogs.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listViewLogs.Location = new Point(11, 84);
            listViewLogs.Name = "listViewLogs";
            listViewLogs.Size = new Size(583, 658);
            listViewLogs.TabIndex = 1;
            listViewLogs.UseCompatibleStateImageBehavior = false;
            listViewLogs.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Log";
            columnHeader1.Width = 380;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 120;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelText.Location = new Point(14, 53);
            labelText.Name = "labelText";
            labelText.Size = new Size(75, 17);
            labelText.TabIndex = 2;
            labelText.Text = "Show logs.";
            // 
            // comboBoxSelection
            // 
            comboBoxSelection.FormattingEnabled = true;
            comboBoxSelection.Location = new Point(151, 52);
            comboBoxSelection.Name = "comboBoxSelection";
            comboBoxSelection.Size = new Size(205, 23);
            comboBoxSelection.TabIndex = 4;
            comboBoxSelection.SelectedIndexChanged += comboBoxSelection_SelectedIndexChanged;
            // 
            // comboBoxDate
            // 
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(391, 52);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(121, 23);
            comboBoxDate.TabIndex = 6;
            comboBoxDate.SelectedValueChanged += comboBoxDate_SelectedValueChanged;
            // 
            // labelDateStart
            // 
            labelDateStart.AutoSize = true;
            labelDateStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelDateStart.Location = new Point(157, 10);
            labelDateStart.Name = "labelDateStart";
            labelDateStart.Size = new Size(96, 17);
            labelDateStart.TabIndex = 7;
            labelDateStart.Text = "labelDateStart";
            // 
            // labelDateEnd
            // 
            labelDateEnd.AutoSize = true;
            labelDateEnd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelDateEnd.Location = new Point(394, 7);
            labelDateEnd.Name = "labelDateEnd";
            labelDateEnd.Size = new Size(45, 17);
            labelDateEnd.TabIndex = 8;
            labelDateEnd.Text = "label2";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(606, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backupLogsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // backupLogsToolStripMenuItem
            // 
            backupLogsToolStripMenuItem.Name = "backupLogsToolStripMenuItem";
            backupLogsToolStripMenuItem.Size = new Size(141, 22);
            backupLogsToolStripMenuItem.Text = "Backup Logs";
            backupLogsToolStripMenuItem.Click += backupLogsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, boldTextToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(186, 22);
            deleteToolStripMenuItem.Text = "Delete Selected Items";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // boldTextToolStripMenuItem
            // 
            boldTextToolStripMenuItem.Checked = true;
            boldTextToolStripMenuItem.CheckState = CheckState.Checked;
            boldTextToolStripMenuItem.Name = "boldTextToolStripMenuItem";
            boldTextToolStripMenuItem.Size = new Size(186, 22);
            boldTextToolStripMenuItem.Text = "Bold Text";
            boldTextToolStripMenuItem.Click += boldTextToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { graphToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // graphToolStripMenuItem
            // 
            graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            graphToolStripMenuItem.Size = new Size(106, 22);
            graphToolStripMenuItem.Text = "Graph";
            graphToolStripMenuItem.Click += graphToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelSelection });
            statusStrip1.Location = new Point(0, 745);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(606, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // toolStripStatusLabelSelection
            // 
            toolStripStatusLabelSelection.Name = "toolStripStatusLabelSelection";
            toolStripStatusLabelSelection.Size = new Size(118, 17);
            toolStripStatusLabelSelection.Text = "toolStripStatusLabel1";
            // 
            // FormLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 767);
            Controls.Add(statusStrip1);
            Controls.Add(labelDateEnd);
            Controls.Add(labelDateStart);
            Controls.Add(comboBoxDate);
            Controls.Add(comboBoxSelection);
            Controls.Add(labelText);
            Controls.Add(listViewLogs);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogs";
            ShowIcon = false;
            Text = "Sensor Device";
            Load += FormLogs_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listViewLogs;
        private Label labelText;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ComboBox comboBoxSelection;
        private Label toolStripStatusLabelStatus;
        private ComboBox comboBoxDate;
        private Label labelDateStart;
        private Label labelDateEnd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem backupLogsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem boldTextToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem graphToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelSelection;
    }
}