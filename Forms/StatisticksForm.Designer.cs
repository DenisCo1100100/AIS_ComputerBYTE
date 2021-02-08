
namespace AIS_ComputerBYTE
{
    partial class StatisticksForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.outputToExcelButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondRadioButton = new System.Windows.Forms.RadioButton();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.fullChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.yearStatsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.outputSummButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearStatsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.monthComboBox.Location = new System.Drawing.Point(326, 10);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(255, 32);
            this.monthComboBox.TabIndex = 0;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Месяц";
            // 
            // monthChart
            // 
            this.monthChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.monthChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.monthChart.Legends.Add(legend1);
            this.monthChart.Location = new System.Drawing.Point(8, 49);
            this.monthChart.Name = "monthChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Средняя сумма сделки";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Проданный товар";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Колличество новых покупателей";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Средний уровень доверия";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Сумма плановых сделок";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Полученная прибыль";
            this.monthChart.Series.Add(series1);
            this.monthChart.Series.Add(series2);
            this.monthChart.Series.Add(series3);
            this.monthChart.Series.Add(series4);
            this.monthChart.Series.Add(series5);
            this.monthChart.Series.Add(series6);
            this.monthChart.Size = new System.Drawing.Size(835, 415);
            this.monthChart.TabIndex = 2;
            this.monthChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(859, 496);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPage1.Controls.Add(this.outputToExcelButton);
            this.tabPage1.Controls.Add(this.monthChart);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.monthComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(851, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Месяц";
            // 
            // outputToExcelButton
            // 
            this.outputToExcelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputToExcelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputToExcelButton.Location = new System.Drawing.Point(602, 400);
            this.outputToExcelButton.Name = "outputToExcelButton";
            this.outputToExcelButton.Size = new System.Drawing.Size(217, 32);
            this.outputToExcelButton.TabIndex = 3;
            this.outputToExcelButton.Text = "Вывести в Excel";
            this.outputToExcelButton.UseVisualStyleBackColor = true;
            this.outputToExcelButton.Click += new System.EventHandler(this.outputToExcelButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.fullChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(851, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Полный";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.secondRadioButton);
            this.groupBox1.Controls.Add(this.firstRadioButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(295, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 46);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор полугодия";
            // 
            // secondRadioButton
            // 
            this.secondRadioButton.AutoSize = true;
            this.secondRadioButton.ForeColor = System.Drawing.Color.White;
            this.secondRadioButton.Location = new System.Drawing.Point(144, 19);
            this.secondRadioButton.Name = "secondRadioButton";
            this.secondRadioButton.Size = new System.Drawing.Size(116, 17);
            this.secondRadioButton.TabIndex = 1;
            this.secondRadioButton.TabStop = true;
            this.secondRadioButton.Text = "Второе полугодие";
            this.secondRadioButton.UseVisualStyleBackColor = true;
            this.secondRadioButton.CheckedChanged += new System.EventHandler(this.firstRadioButton_CheckedChanged);
            // 
            // firstRadioButton
            // 
            this.firstRadioButton.AutoSize = true;
            this.firstRadioButton.ForeColor = System.Drawing.Color.White;
            this.firstRadioButton.Location = new System.Drawing.Point(6, 19);
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Size = new System.Drawing.Size(118, 17);
            this.firstRadioButton.TabIndex = 0;
            this.firstRadioButton.TabStop = true;
            this.firstRadioButton.Text = "Первое полугодие";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            this.firstRadioButton.CheckedChanged += new System.EventHandler(this.firstRadioButton_CheckedChanged);
            // 
            // fullChart
            // 
            this.fullChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 90.55851F;
            chartArea2.InnerPlotPosition.Width = 89.53243F;
            chartArea2.InnerPlotPosition.X = 8.96316F;
            chartArea2.InnerPlotPosition.Y = 2.23404F;
            chartArea2.Name = "ChartArea1";
            this.fullChart.ChartAreas.Add(chartArea2);
            legend2.AutoFitMinFontSize = 5;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            legend2.IsTextAutoFit = false;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            this.fullChart.Legends.Add(legend2);
            this.fullChart.Location = new System.Drawing.Point(8, 58);
            this.fullChart.Name = "fullChart";
            series7.ChartArea = "ChartArea1";
            series7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series7.Legend = "Legend1";
            series7.Name = "Средняя сумма сделки";
            series7.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series7.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series8.ChartArea = "ChartArea1";
            series8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series8.Legend = "Legend1";
            series8.Name = "Проданный товар";
            series8.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series9.ChartArea = "ChartArea1";
            series9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series9.Legend = "Legend1";
            series9.Name = "Колличество новых покупателей";
            series9.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series10.ChartArea = "ChartArea1";
            series10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series10.Legend = "Legend1";
            series10.Name = "Средний уровень доверия";
            series10.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series11.ChartArea = "ChartArea1";
            series11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series11.Legend = "Legend1";
            series11.Name = "Сумма плановых сделок";
            series11.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series12.ChartArea = "ChartArea1";
            series12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series12.Legend = "Legend1";
            series12.Name = "Полученная прибыль";
            series12.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.fullChart.Series.Add(series7);
            this.fullChart.Series.Add(series8);
            this.fullChart.Series.Add(series9);
            this.fullChart.Series.Add(series10);
            this.fullChart.Series.Add(series11);
            this.fullChart.Series.Add(series12);
            this.fullChart.Size = new System.Drawing.Size(835, 404);
            this.fullChart.TabIndex = 5;
            this.fullChart.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.tabPage3.Controls.Add(this.outputSummButton);
            this.tabPage3.Controls.Add(this.yearStatsChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(851, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "За все время";
            // 
            // yearStatsChart
            // 
            this.yearStatsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 90.55851F;
            chartArea3.InnerPlotPosition.Width = 89.53243F;
            chartArea3.InnerPlotPosition.X = 8.96316F;
            chartArea3.InnerPlotPosition.Y = 2.23404F;
            chartArea3.Name = "ChartArea1";
            this.yearStatsChart.ChartAreas.Add(chartArea3);
            legend3.AutoFitMinFontSize = 5;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            legend3.IsTextAutoFit = false;
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend3.Name = "Legend1";
            this.yearStatsChart.Legends.Add(legend3);
            this.yearStatsChart.Location = new System.Drawing.Point(8, 3);
            this.yearStatsChart.Name = "yearStatsChart";
            series13.ChartArea = "ChartArea1";
            series13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series13.Legend = "Legend1";
            series13.Name = "Средняя сумма сделки";
            series13.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series13.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series13.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series14.ChartArea = "ChartArea1";
            series14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series14.Legend = "Legend1";
            series14.Name = "Проданный товар";
            series14.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series15.ChartArea = "ChartArea1";
            series15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series15.Legend = "Legend1";
            series15.Name = "Колличество новых покупателей";
            series15.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series15.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series16.ChartArea = "ChartArea1";
            series16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series16.Legend = "Legend1";
            series16.Name = "Средний уровень доверия";
            series16.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series16.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series17.ChartArea = "ChartArea1";
            series17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series17.Legend = "Legend1";
            series17.Name = "Сумма плановых сделок";
            series17.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series17.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series18.ChartArea = "ChartArea1";
            series18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series18.Legend = "Legend1";
            series18.Name = "Полученная прибыль";
            series18.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series18.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.yearStatsChart.Series.Add(series13);
            this.yearStatsChart.Series.Add(series14);
            this.yearStatsChart.Series.Add(series15);
            this.yearStatsChart.Series.Add(series16);
            this.yearStatsChart.Series.Add(series17);
            this.yearStatsChart.Series.Add(series18);
            this.yearStatsChart.Size = new System.Drawing.Size(835, 459);
            this.yearStatsChart.TabIndex = 6;
            this.yearStatsChart.Text = "chart1";
            // 
            // outputSummButton
            // 
            this.outputSummButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outputSummButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputSummButton.Location = new System.Drawing.Point(613, 398);
            this.outputSummButton.Name = "outputSummButton";
            this.outputSummButton.Size = new System.Drawing.Size(217, 32);
            this.outputSummButton.TabIndex = 7;
            this.outputSummButton.Text = "Вывести в Excel";
            this.outputSummButton.UseVisualStyleBackColor = true;
            this.outputSummButton.Click += new System.EventHandler(this.outputSummButton_Click);
            // 
            // StatisticksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(859, 496);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Name = "StatisticksForm";
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yearStatsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart fullChart;
        private System.Windows.Forms.Button outputToExcelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton secondRadioButton;
        private System.Windows.Forms.RadioButton firstRadioButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart yearStatsChart;
        private System.Windows.Forms.Button outputSummButton;
    }
}