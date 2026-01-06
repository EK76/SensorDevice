namespace Sensordevice
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteRowsToolStripMenuItem = new ToolStripMenuItem();
            deleteRows2ToolStripMenuItem = new ToolStripMenuItem();
            deleteRowsNth2 = new ToolStripMenuItem();
            deleteRowsNth3 = new ToolStripMenuItem();
            deleteRowsNth4 = new ToolStripMenuItem();
            deleteRowsNth5 = new ToolStripMenuItem();
            clearDataToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            restoreDatabaseToolStripMenuItem = new ToolStripMenuItem();
            backupDatabaseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            clearDatabaseToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            graphToolStripMenuItem = new ToolStripMenuItem();
            fontSizeToolStripMenuItem = new ToolStripMenuItem();
            smallToolStripMenuItem = new ToolStripMenuItem();
            mediumToolStripMenuItem = new ToolStripMenuItem();
            largeToolStripMenuItem = new ToolStripMenuItem();
            tableInfoToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            listViewData = new ListView();
            columnHeaderTemp = new ColumnHeader();
            columnHeaderHum = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            dateTimePickerStartDate = new DateTimePicker();
            dateTimePickerEndDate = new DateTimePicker();
            labelDateStart = new Label();
            labelEndDate = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelRows = new ToolStripStatusLabel();
            toolStripStatusLabelLocation = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            buttonSearch = new Button();
            fontDialog1 = new FontDialog();
            checkBoxSetDay = new CheckBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(907, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteRowsToolStripMenuItem, deleteRows2ToolStripMenuItem, clearDataToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteRowsToolStripMenuItem
            // 
            deleteRowsToolStripMenuItem.Enabled = false;
            deleteRowsToolStripMenuItem.Name = "deleteRowsToolStripMenuItem";
            deleteRowsToolStripMenuItem.Size = new Size(156, 22);
            deleteRowsToolStripMenuItem.Text = "Delete Rows";
            deleteRowsToolStripMenuItem.Click += deleteRowsToolStripMenuItem_Click;
            // 
            // deleteRows2ToolStripMenuItem
            // 
            deleteRows2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteRowsNth2, deleteRowsNth3, deleteRowsNth4, deleteRowsNth5 });
            deleteRows2ToolStripMenuItem.Enabled = false;
            deleteRows2ToolStripMenuItem.Name = "deleteRows2ToolStripMenuItem";
            deleteRows2ToolStripMenuItem.Size = new Size(156, 22);
            deleteRows2ToolStripMenuItem.Text = "Delete Nth Row";
            // 
            // deleteRowsNth2
            // 
            deleteRowsNth2.Name = "deleteRowsNth2";
            deleteRowsNth2.Size = new Size(80, 22);
            deleteRowsNth2.Text = "2";
            deleteRowsNth2.Click += deleteRowsNth2_Click;
            // 
            // deleteRowsNth3
            // 
            deleteRowsNth3.Name = "deleteRowsNth3";
            deleteRowsNth3.Size = new Size(80, 22);
            deleteRowsNth3.Text = "3";
            deleteRowsNth3.Click += deleteRowsNth3_Click;
            // 
            // deleteRowsNth4
            // 
            deleteRowsNth4.Name = "deleteRowsNth4";
            deleteRowsNth4.Size = new Size(80, 22);
            deleteRowsNth4.Text = "4";
            deleteRowsNth4.Click += deleteRowsNth4_Click;
            // 
            // deleteRowsNth5
            // 
            deleteRowsNth5.Name = "deleteRowsNth5";
            deleteRowsNth5.Size = new Size(80, 22);
            deleteRowsNth5.Text = "5";
            deleteRowsNth5.Click += deleteRowsNth5_Click;
            // 
            // clearDataToolStripMenuItem
            // 
            clearDataToolStripMenuItem.Enabled = false;
            clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            clearDataToolStripMenuItem.Size = new Size(156, 22);
            clearDataToolStripMenuItem.Text = "Clear Data";
            clearDataToolStripMenuItem.Click += clearDataToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restoreDatabaseToolStripMenuItem, backupDatabaseToolStripMenuItem, toolStripSeparator1, clearDatabaseToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // restoreDatabaseToolStripMenuItem
            // 
            restoreDatabaseToolStripMenuItem.Name = "restoreDatabaseToolStripMenuItem";
            restoreDatabaseToolStripMenuItem.Size = new Size(180, 22);
            restoreDatabaseToolStripMenuItem.Text = "Restore Database";
            restoreDatabaseToolStripMenuItem.Click += restoreDatabaseToolStripMenuItem_Click_1;
            // 
            // backupDatabaseToolStripMenuItem
            // 
            backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            backupDatabaseToolStripMenuItem.Size = new Size(180, 22);
            backupDatabaseToolStripMenuItem.Text = "Backup Database";
            backupDatabaseToolStripMenuItem.Click += backupDatabaseToolStripMenuItem_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            clearDatabaseToolStripMenuItem.Size = new Size(180, 22);
            clearDatabaseToolStripMenuItem.Text = "ClearTable";
            clearDatabaseToolStripMenuItem.Click += clearDatabaseToolStripMenuItem_Click_1;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { graphToolStripMenuItem, fontSizeToolStripMenuItem, tableInfoToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // graphToolStripMenuItem
            // 
            graphToolStripMenuItem.Enabled = false;
            graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            graphToolStripMenuItem.Size = new Size(126, 22);
            graphToolStripMenuItem.Text = "Graph";
            graphToolStripMenuItem.Click += graphToolStripMenuItem_Click;
            // 
            // fontSizeToolStripMenuItem
            // 
            fontSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { smallToolStripMenuItem, mediumToolStripMenuItem, largeToolStripMenuItem });
            fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            fontSizeToolStripMenuItem.Size = new Size(126, 22);
            fontSizeToolStripMenuItem.Text = "Font Size";
            // 
            // smallToolStripMenuItem
            // 
            smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            smallToolStripMenuItem.Size = new Size(119, 22);
            smallToolStripMenuItem.Text = "Small";
            smallToolStripMenuItem.Click += smallToolStripMenuItem_Click;
            // 
            // mediumToolStripMenuItem
            // 
            mediumToolStripMenuItem.Checked = true;
            mediumToolStripMenuItem.CheckState = CheckState.Checked;
            mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            mediumToolStripMenuItem.Size = new Size(119, 22);
            mediumToolStripMenuItem.Text = "Medium";
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            // 
            // largeToolStripMenuItem
            // 
            largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            largeToolStripMenuItem.Size = new Size(119, 22);
            largeToolStripMenuItem.Text = "Large";
            largeToolStripMenuItem.Click += largeToolStripMenuItem_Click;
            // 
            // tableInfoToolStripMenuItem
            // 
            tableInfoToolStripMenuItem.Name = "tableInfoToolStripMenuItem";
            tableInfoToolStripMenuItem.Size = new Size(126, 22);
            tableInfoToolStripMenuItem.Text = "Table Info";
            tableInfoToolStripMenuItem.Click += tableInfoToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // listViewData
            // 
            listViewData.Columns.AddRange(new ColumnHeader[] { columnHeaderTemp, columnHeaderHum, columnHeaderDate });
            listViewData.Font = new Font("Segoe UI", 16F);
            listViewData.Location = new Point(0, 76);
            listViewData.Name = "listViewData";
            listViewData.Size = new Size(907, 1010);
            listViewData.TabIndex = 1;
            listViewData.UseCompatibleStateImageBehavior = false;
            listViewData.View = View.Details;
            listViewData.SelectedIndexChanged += listViewData_SelectedIndexChanged;
            // 
            // columnHeaderTemp
            // 
            columnHeaderTemp.Text = "Temperature";
            columnHeaderTemp.Width = 340;
            // 
            // columnHeaderHum
            // 
            columnHeaderHum.Text = "Humidity";
            columnHeaderHum.Width = 300;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date created";
            columnHeaderDate.Width = 300;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.Location = new Point(12, 47);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(93, 25);
            dateTimePickerStartDate.TabIndex = 2;
            dateTimePickerStartDate.Value = new DateTime(2025, 12, 2, 0, 0, 0, 0);
            dateTimePickerStartDate.ValueChanged += dateTimePickerStartDate_ValueChanged;
            dateTimePickerStartDate.Enter += dateTimePickerStartDate_Enter;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Enabled = false;
            dateTimePickerEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dateTimePickerEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndDate.Location = new Point(143, 47);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(90, 25);
            dateTimePickerEndDate.TabIndex = 3;
            // 
            // labelDateStart
            // 
            labelDateStart.AutoSize = true;
            labelDateStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelDateStart.Location = new Point(12, 29);
            labelDateStart.Name = "labelDateStart";
            labelDateStart.Size = new Size(111, 17);
            labelDateStart.TabIndex = 4;
            labelDateStart.Text = "Select start date.";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelEndDate.Location = new Point(143, 29);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(106, 17);
            labelEndDate.TabIndex = 5;
            labelEndDate.Text = "Select end date.";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelRows, toolStripStatusLabelLocation, toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 1089);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(907, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelRows
            // 
            toolStripStatusLabelRows.Name = "toolStripStatusLabelRows";
            toolStripStatusLabelRows.Size = new Size(0, 17);
            // 
            // toolStripStatusLabelLocation
            // 
            toolStripStatusLabelLocation.Name = "toolStripStatusLabelLocation";
            toolStripStatusLabelLocation.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 17);
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            buttonSearch.Location = new Point(263, 47);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 7;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // checkBoxSetDay
            // 
            checkBoxSetDay.AutoSize = true;
            checkBoxSetDay.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            checkBoxSetDay.Location = new Point(369, 49);
            checkBoxSetDay.Name = "checkBoxSetDay";
            checkBoxSetDay.Size = new Size(104, 21);
            checkBoxSetDay.TabIndex = 8;
            checkBoxSetDay.Text = "Today's date";
            checkBoxSetDay.UseVisualStyleBackColor = true;
            checkBoxSetDay.CheckedChanged += checkBoxSetDay_CheckedChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 1111);
            Controls.Add(checkBoxSetDay);
            Controls.Add(buttonSearch);
            Controls.Add(statusStrip1);
            Controls.Add(labelEndDate);
            Controls.Add(labelDateStart);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(listViewData);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            ShowIcon = false;
            Text = "Ken's Sensor Device";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem graphToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteRowsToolStripMenuItem;
        private ToolStripMenuItem clearDataToolStripMenuItem;
        private ListView listViewData;
        private DateTimePicker dateTimePickerStartDate;
        private DateTimePicker dateTimePickerEndDate;
        private Label labelDateStart;
        private Label labelEndDate;
        private StatusStrip statusStrip1;
        private Button buttonSearch;
        private ColumnHeader columnHeaderTemp;
        private ColumnHeader columnHeaderHum;
        private ColumnHeader columnHeaderDate;
        private ToolStripStatusLabel toolStripStatusLabelRows;
        private ToolStripStatusLabel toolStripStatusLabelLocation;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem fontSizeToolStripMenuItem;
        private ToolStripMenuItem smallToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem largeToolStripMenuItem;
        private FontDialog fontDialog1;
        private ToolStripMenuItem restoreDatabaseToolStripMenuItem;
        private ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private CheckBox checkBoxSetDay;
        private ToolStripMenuItem tableInfoToolStripMenuItem;
        private ToolStripMenuItem deleteRows2ToolStripMenuItem;
        private ToolStripMenuItem deleteRowsNth2;
        private ToolStripMenuItem deleteRowsNth3;
        private ToolStripMenuItem deleteRowsNth4;
        private ToolStripMenuItem deleteRowsNth5;
    }
}
