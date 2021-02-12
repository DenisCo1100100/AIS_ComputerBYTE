
namespace AIS_ComputerBYTE
{
    partial class SalesForecastsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForecastsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.secondRadioButton = new System.Windows.Forms.RadioButton();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.forecastsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secondRadioButton2 = new System.Windows.Forms.RadioButton();
            this.firstRadioButton1 = new System.Windows.Forms.RadioButton();
            this.forecastProfitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastsChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastProfitChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.forecastsChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вероятность покупки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.groupBox1.Controls.Add(this.secondRadioButton);
            this.groupBox1.Controls.Add(this.firstRadioButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(296, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 46);
            this.groupBox1.TabIndex = 13;
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
            // forecastsChart
            // 
            this.forecastsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.forecastsChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.White;
            legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.forecastsChart.Legends.Add(legend1);
            this.forecastsChart.Location = new System.Drawing.Point(6, 58);
            this.forecastsChart.Name = "forecastsChart";
            this.forecastsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series1.Label = "%";
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Вероятность покупки";
            this.forecastsChart.Series.Add(series1);
            this.forecastsChart.Size = new System.Drawing.Size(881, 428);
            this.forecastsChart.TabIndex = 12;
            this.forecastsChart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.forecastProfitChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Возможная прибыль";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.groupBox2.Controls.Add(this.secondRadioButton2);
            this.groupBox2.Controls.Add(this.firstRadioButton1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(299, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 46);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор полугодия";
            // 
            // secondRadioButton2
            // 
            this.secondRadioButton2.AutoSize = true;
            this.secondRadioButton2.ForeColor = System.Drawing.Color.White;
            this.secondRadioButton2.Location = new System.Drawing.Point(144, 19);
            this.secondRadioButton2.Name = "secondRadioButton2";
            this.secondRadioButton2.Size = new System.Drawing.Size(116, 17);
            this.secondRadioButton2.TabIndex = 1;
            this.secondRadioButton2.TabStop = true;
            this.secondRadioButton2.Text = "Второе полугодие";
            this.secondRadioButton2.UseVisualStyleBackColor = true;
            this.secondRadioButton2.CheckedChanged += new System.EventHandler(this.firstRadioButton_CheckedChanged);
            // 
            // firstRadioButton1
            // 
            this.firstRadioButton1.AutoSize = true;
            this.firstRadioButton1.ForeColor = System.Drawing.Color.White;
            this.firstRadioButton1.Location = new System.Drawing.Point(6, 19);
            this.firstRadioButton1.Name = "firstRadioButton1";
            this.firstRadioButton1.Size = new System.Drawing.Size(118, 17);
            this.firstRadioButton1.TabIndex = 0;
            this.firstRadioButton1.TabStop = true;
            this.firstRadioButton1.Text = "Первое полугодие";
            this.firstRadioButton1.UseVisualStyleBackColor = true;
            this.firstRadioButton1.CheckedChanged += new System.EventHandler(this.firstRadioButton_CheckedChanged);
            // 
            // forecastProfitChart
            // 
            this.forecastProfitChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.forecastProfitChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            legend2.Name = "Legend1";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.forecastProfitChart.Legends.Add(legend2);
            this.forecastProfitChart.Location = new System.Drawing.Point(6, 62);
            this.forecastProfitChart.Name = "forecastProfitChart";
            this.forecastProfitChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Возможная прибыль";
            this.forecastProfitChart.Series.Add(series2);
            this.forecastProfitChart.Size = new System.Drawing.Size(881, 424);
            this.forecastProfitChart.TabIndex = 13;
            this.forecastProfitChart.Text = "chart1";
            // 
            // SalesForecastsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(925, 542);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesForecastsForm";
            this.Text = "Прогнозы продаж";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastsChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastProfitChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart forecastsChart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart forecastProfitChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton secondRadioButton;
        private System.Windows.Forms.RadioButton firstRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton secondRadioButton2;
        private System.Windows.Forms.RadioButton firstRadioButton1;
    }
}