namespace Sensordevice
{
    partial class FormGraph
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            copyGraphsToolStripMenuItem = new ToolStripMenuItem();
            temperatureToolStripMenuItem = new ToolStripMenuItem();
            humitidyToolStripMenuItem = new ToolStripMenuItem();
            saveGraphsToolStripMenuItem = new ToolStripMenuItem();
            temperatureToolStripMenuItem2 = new ToolStripMenuItem();
            humitidyToolStripMenuItem2 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            markerPointToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            triangleToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            starToolStripMenuItem = new ToolStripMenuItem();
            noneToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            smallToolStripMenuItem = new ToolStripMenuItem();
            mediumToolStripMenuItem = new ToolStripMenuItem();
            largeToolStripMenuItem = new ToolStripMenuItem();
            markerColorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            panelInfo = new Panel();
            labelInfo = new Label();
            labelMax = new Label();
            labelMedium = new Label();
            labelMin = new Label();
            labelEndDate = new Label();
            labelStartDate = new Label();
            chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartHum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            colorDialog1 = new ColorDialog();
            trackBarMarkerSize = new TrackBar();
            labelTrackSize = new Label();
            toolTipTrackSize = new ToolTip(components);
            menuStrip1.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartHum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarMarkerSize).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2904, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyGraphsToolStripMenuItem, saveGraphsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // copyGraphsToolStripMenuItem
            // 
            copyGraphsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temperatureToolStripMenuItem, humitidyToolStripMenuItem });
            copyGraphsToolStripMenuItem.Name = "copyGraphsToolStripMenuItem";
            copyGraphsToolStripMenuItem.Size = new Size(142, 22);
            copyGraphsToolStripMenuItem.Text = "Copy Graphs";
            // 
            // temperatureToolStripMenuItem
            // 
            temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            temperatureToolStripMenuItem.Size = new Size(141, 22);
            temperatureToolStripMenuItem.Text = "Temperature";
            temperatureToolStripMenuItem.Click += temperatureToolStripMenuItem_Click;
            // 
            // humitidyToolStripMenuItem
            // 
            humitidyToolStripMenuItem.Name = "humitidyToolStripMenuItem";
            humitidyToolStripMenuItem.Size = new Size(141, 22);
            humitidyToolStripMenuItem.Text = "Humitidy";
            humitidyToolStripMenuItem.Click += humitidyToolStripMenuItem_Click;
            // 
            // saveGraphsToolStripMenuItem
            // 
            saveGraphsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { temperatureToolStripMenuItem2, humitidyToolStripMenuItem2 });
            saveGraphsToolStripMenuItem.Name = "saveGraphsToolStripMenuItem";
            saveGraphsToolStripMenuItem.Size = new Size(142, 22);
            saveGraphsToolStripMenuItem.Text = "Save Graphs";
            // 
            // temperatureToolStripMenuItem2
            // 
            temperatureToolStripMenuItem2.Name = "temperatureToolStripMenuItem2";
            temperatureToolStripMenuItem2.Size = new Size(141, 22);
            temperatureToolStripMenuItem2.Text = "Temperature";
            temperatureToolStripMenuItem2.Click += temperatureToolStripMenuItem2_Click;
            // 
            // humitidyToolStripMenuItem2
            // 
            humitidyToolStripMenuItem2.Name = "humitidyToolStripMenuItem2";
            humitidyToolStripMenuItem2.Size = new Size(141, 22);
            humitidyToolStripMenuItem2.Text = "Humitidy";
            humitidyToolStripMenuItem2.Click += humitidyToolStripMenuItem2_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(142, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { markerPointToolStripMenuItem, toolStripMenuItem1, markerColorToolStripMenuItem, toolStripSeparator1, defaultToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // markerPointToolStripMenuItem
            // 
            markerPointToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { circleToolStripMenuItem, triangleToolStripMenuItem, squareToolStripMenuItem, starToolStripMenuItem, noneToolStripMenuItem });
            markerPointToolStripMenuItem.Name = "markerPointToolStripMenuItem";
            markerPointToolStripMenuItem.Size = new Size(180, 22);
            markerPointToolStripMenuItem.Text = "Marker Point";
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Checked = true;
            circleToolStripMenuItem.CheckState = CheckState.Checked;
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(116, 22);
            circleToolStripMenuItem.Text = "Circle";
            circleToolStripMenuItem.Click += circleToolStripMenuItem_Click;
            // 
            // triangleToolStripMenuItem
            // 
            triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            triangleToolStripMenuItem.Size = new Size(116, 22);
            triangleToolStripMenuItem.Text = "Triangle";
            triangleToolStripMenuItem.Click += triangleToolStripMenuItem_Click;
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(116, 22);
            squareToolStripMenuItem.Text = "Square";
            squareToolStripMenuItem.Click += squareToolStripMenuItem_Click;
            // 
            // starToolStripMenuItem
            // 
            starToolStripMenuItem.Name = "starToolStripMenuItem";
            starToolStripMenuItem.Size = new Size(116, 22);
            starToolStripMenuItem.Text = "Star";
            starToolStripMenuItem.Click += starToolStripMenuItem_Click;
            // 
            // noneToolStripMenuItem
            // 
            noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            noneToolStripMenuItem.Size = new Size(116, 22);
            noneToolStripMenuItem.Text = "None";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { smallToolStripMenuItem, mediumToolStripMenuItem, largeToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "Marker Line Size";
            // 
            // smallToolStripMenuItem
            // 
            smallToolStripMenuItem.Checked = true;
            smallToolStripMenuItem.CheckState = CheckState.Checked;
            smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            smallToolStripMenuItem.Size = new Size(119, 22);
            smallToolStripMenuItem.Text = "Small";
            smallToolStripMenuItem.Click += smallToolStripMenuItem_Click;
            // 
            // mediumToolStripMenuItem
            // 
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
            // markerColorToolStripMenuItem
            // 
            markerColorToolStripMenuItem.Name = "markerColorToolStripMenuItem";
            markerColorToolStripMenuItem.Size = new Size(180, 22);
            markerColorToolStripMenuItem.Text = "Marker Color";
            markerColorToolStripMenuItem.Click += markerColorToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(180, 22);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
            // 
            // panelInfo
            // 
            panelInfo.BorderStyle = BorderStyle.Fixed3D;
            panelInfo.Controls.Add(labelInfo);
            panelInfo.Controls.Add(labelMax);
            panelInfo.Controls.Add(labelMedium);
            panelInfo.Controls.Add(labelMin);
            panelInfo.Controls.Add(labelEndDate);
            panelInfo.Controls.Add(labelStartDate);
            panelInfo.Location = new Point(2562, 53);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(312, 315);
            panelInfo.TabIndex = 1;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 12F);
            labelInfo.Location = new Point(7, 235);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(0, 21);
            labelInfo.TabIndex = 5;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Font = new Font("Segoe UI", 12F);
            labelMax.Location = new Point(7, 184);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(72, 21);
            labelMax.TabIndex = 4;
            labelMax.Text = "labelMax";
            // 
            // labelMedium
            // 
            labelMedium.AutoSize = true;
            labelMedium.Font = new Font("Segoe UI", 12F);
            labelMedium.Location = new Point(7, 154);
            labelMedium.Name = "labelMedium";
            labelMedium.Size = new Size(101, 21);
            labelMedium.TabIndex = 3;
            labelMedium.Text = "labelMedium";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new Font("Segoe UI", 12F);
            labelMin.Location = new Point(7, 122);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(70, 21);
            labelMin.TabIndex = 2;
            labelMin.Text = "labelMin";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI", 12F);
            labelEndDate.Location = new Point(7, 56);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(52, 21);
            labelEndDate.TabIndex = 1;
            labelEndDate.Text = "label2";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI", 12F);
            labelStartDate.Location = new Point(7, 25);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(52, 21);
            labelStartDate.TabIndex = 0;
            labelStartDate.Text = "label1";
            // 
            // chartTemp
            // 
            chartArea3.AxisY.Minimum = 1D;
            chartArea3.Name = "ChartArea1";
            chartTemp.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartTemp.Legends.Add(legend3);
            chartTemp.Location = new Point(12, 27);
            chartTemp.Name = "chartTemp";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = Color.Black;
            series3.Legend = "Legend1";
            series3.MarkerColor = Color.Black;
            series3.MarkerSize = 10;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series1";
            chartTemp.Series.Add(series3);
            chartTemp.Size = new Size(1248, 1100);
            chartTemp.TabIndex = 2;
            chartTemp.Text = "chart1";
            chartTemp.GetToolTipText += chartTemp_GetToolTipText;
            // 
            // chartHum
            // 
            chartArea4.Name = "ChartArea1";
            chartHum.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartHum.Legends.Add(legend4);
            chartHum.Location = new Point(1293, 27);
            chartHum.Name = "chartHum";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = Color.Black;
            series4.Legend = "Legend1";
            series4.MarkerColor = Color.Black;
            series4.MarkerSize = 10;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Series1";
            chartHum.Series.Add(series4);
            chartHum.Size = new Size(1248, 1100);
            chartHum.TabIndex = 3;
            chartHum.Text = "chart2";
            chartHum.GetToolTipText += chartHum_GetToolTipText;
            // 
            // trackBarMarkerSize
            // 
            trackBarMarkerSize.Location = new Point(2571, 1054);
            trackBarMarkerSize.Maximum = 20;
            trackBarMarkerSize.Minimum = 4;
            trackBarMarkerSize.Name = "trackBarMarkerSize";
            trackBarMarkerSize.Size = new Size(281, 45);
            trackBarMarkerSize.TabIndex = 4;
            trackBarMarkerSize.Value = 10;
            trackBarMarkerSize.Scroll += trackBarMarkerSize_Scroll;
            trackBarMarkerSize.MouseHover += trackBarMarkerSize_MouseHover;
            trackBarMarkerSize.MouseMove += trackBarMarkerSize_MouseMove;
            // 
            // labelTrackSize
            // 
            labelTrackSize.AutoSize = true;
            labelTrackSize.Font = new Font("Segoe UI", 12F);
            labelTrackSize.Location = new Point(2580, 1102);
            labelTrackSize.Name = "labelTrackSize";
            labelTrackSize.Size = new Size(115, 21);
            labelTrackSize.TabIndex = 5;
            labelTrackSize.Text = "Marker size: 10";
            // 
            // FormGraph
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2904, 1139);
            Controls.Add(labelTrackSize);
            Controls.Add(trackBarMarkerSize);
            Controls.Add(chartHum);
            Controls.Add(chartTemp);
            Controls.Add(panelInfo);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGraph";
            ShowIcon = false;
            Text = "Ken's Sensor Device";
            Load += FormGraph_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartHum).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarMarkerSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem copyGraphsToolStripMenuItem;
        private ToolStripMenuItem temperatureToolStripMenuItem;
        private ToolStripMenuItem humitidyToolStripMenuItem;
        private ToolStripMenuItem saveGraphsToolStripMenuItem;
        private ToolStripMenuItem temperatureToolStripMenuItem2;
        private ToolStripMenuItem humitidyToolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private Panel panelInfo;
        private Label labelMedium;
        private Label labelMin;
        private Label labelEndDate;
        private Label labelStartDate;
        private Label labelMax;
        private ToolStripMenuItem markerPointToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem starToolStripMenuItem;
        private ToolStripMenuItem markerColorToolStripMenuItem;
        private Label labelHum;
        private Label labelInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHum;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem noneToolStripMenuItem;
        private TrackBar trackBarMarkerSize;
        private Label labelTrackSize;
        private ToolTip toolTipTrackSize;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem smallToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem largeToolStripMenuItem;
    }
}