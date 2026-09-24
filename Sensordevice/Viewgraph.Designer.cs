namespace CameraDevice
{
    partial class FormViewgraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            radioButtonShowDates = new RadioButton();
            radioButtonShowTopics = new RadioButton();
            listBoxShowTopics = new ListBox();
            ((System.ComponentModel.ISupportInitialize)chartView).BeginInit();
            SuspendLayout();
            // 
            // chartView
            // 
            chartView.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            chartView.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartView.Legends.Add(legend1);
            chartView.Location = new Point(12, 43);
            chartView.Name = "chartView";
            series1.ChartArea = "ChartArea1";
            series1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartView.Series.Add(series1);
            chartView.Size = new Size(795, 484);
            chartView.TabIndex = 1;
            chartView.Text = "chart1";
            // 
            // radioButtonShowDates
            // 
            radioButtonShowDates.AutoSize = true;
            radioButtonShowDates.Checked = true;
            radioButtonShowDates.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioButtonShowDates.Location = new Point(16, 13);
            radioButtonShowDates.Name = "radioButtonShowDates";
            radioButtonShowDates.Size = new Size(248, 21);
            radioButtonShowDates.TabIndex = 2;
            radioButtonShowDates.TabStop = true;
            radioButtonShowDates.Text = "Number of events for current dates.";
            radioButtonShowDates.UseVisualStyleBackColor = true;
            radioButtonShowDates.CheckedChanged += radioButtonShowDates_CheckedChanged;
            // 
            // radioButtonShowTopics
            // 
            radioButtonShowTopics.AutoSize = true;
            radioButtonShowTopics.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            radioButtonShowTopics.Location = new Point(283, 13);
            radioButtonShowTopics.Name = "radioButtonShowTopics";
            radioButtonShowTopics.Size = new Size(252, 21);
            radioButtonShowTopics.TabIndex = 3;
            radioButtonShowTopics.Text = "Number of events for current topics.";
            radioButtonShowTopics.UseVisualStyleBackColor = true;
            radioButtonShowTopics.CheckedChanged += radioButtonShowTopics_CheckedChanged;
            // 
            // listBoxShowTopics
            // 
            listBoxShowTopics.BackColor = SystemColors.Control;
            listBoxShowTopics.FormattingEnabled = true;
            listBoxShowTopics.Location = new Point(813, 43);
            listBoxShowTopics.Name = "listBoxShowTopics";
            listBoxShowTopics.Size = new Size(250, 484);
            listBoxShowTopics.TabIndex = 4;
            // 
            // FormViewgraph
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 541);
            Controls.Add(listBoxShowTopics);
            Controls.Add(radioButtonShowTopics);
            Controls.Add(radioButtonShowDates);
            Controls.Add(chartView);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormViewgraph";
            ShowIcon = false;
            Text = "Camera Device";
            Load += Viewgraph_Load;
            ((System.ComponentModel.ISupportInitialize)chartView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartView;
        private RadioButton radioButtonShowDates;
        private RadioButton radioButtonShowTopics;
        private ListBox listBoxShowTopics;
    }
}