namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.AverageNumberPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverageDelayAsync = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AverageDelaySync = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.counttimes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.countMes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.var2Times = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.var2Count = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.AverageNumberPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageDelayAsync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageDelaySync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.counttimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.var2Times)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.var2Count)).BeginInit();
            this.SuspendLayout();
            // 
            // AverageNumberPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.AverageNumberPlot.ChartAreas.Add(chartArea1);
            this.AverageNumberPlot.Location = new System.Drawing.Point(1001, 9);
            this.AverageNumberPlot.Name = "AverageNumberPlot";
            this.AverageNumberPlot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.AverageNumberPlot.Series.Add(series1);
            this.AverageNumberPlot.Size = new System.Drawing.Size(284, 217);
            this.AverageNumberPlot.TabIndex = 0;
            this.AverageNumberPlot.Text = "chart1";
            title1.BorderWidth = 4;
            title1.Name = "Title1";
            title1.Text = " Среднее число абонентов Теоритические значения";
            this.AverageNumberPlot.Titles.Add(title1);
            // 
            // AverageDelayAsync
            // 
            chartArea2.Name = "ChartArea1";
            this.AverageDelayAsync.ChartAreas.Add(chartArea2);
            this.AverageDelayAsync.Location = new System.Drawing.Point(694, 9);
            this.AverageDelayAsync.Name = "AverageDelayAsync";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.AverageDelayAsync.Series.Add(series2);
            this.AverageDelayAsync.Size = new System.Drawing.Size(278, 202);
            this.AverageDelayAsync.TabIndex = 1;
            this.AverageDelayAsync.Text = "chart1";
            title2.Name = " ";
            title2.Text = " Средняя задержка асинхронная Теоритические значения";
            this.AverageDelayAsync.Titles.Add(title2);
            this.AverageDelayAsync.Click += new System.EventHandler(this.AverageDelayAsync_Click);
            // 
            // AverageDelaySync
            // 
            chartArea3.Name = "ChartArea1";
            this.AverageDelaySync.ChartAreas.Add(chartArea3);
            this.AverageDelaySync.Location = new System.Drawing.Point(731, 356);
            this.AverageDelaySync.Name = "AverageDelaySync";
            this.AverageDelaySync.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.LabelBorderWidth = 5;
            series3.Name = "Series1";
            this.AverageDelaySync.Series.Add(series3);
            this.AverageDelaySync.Size = new System.Drawing.Size(299, 195);
            this.AverageDelaySync.TabIndex = 2;
            this.AverageDelaySync.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = " Средняя задержка сихронная Теоритические значения";
            this.AverageDelaySync.Titles.Add(title3);
            // 
            // counttimes
            // 
            chartArea4.Name = "ChartArea1";
            this.counttimes.ChartAreas.Add(chartArea4);
            this.counttimes.Location = new System.Drawing.Point(12, 209);
            this.counttimes.Name = "counttimes";
            this.counttimes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Series1";
            this.counttimes.Series.Add(series4);
            this.counttimes.Size = new System.Drawing.Size(294, 179);
            this.counttimes.TabIndex = 3;
            this.counttimes.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = " Среднее число абонентов Практическое значения Синхронная";
            this.counttimes.Titles.Add(title4);
            // 
            // countMes
            // 
            chartArea5.Name = "ChartArea1";
            this.countMes.ChartAreas.Add(chartArea5);
            this.countMes.Location = new System.Drawing.Point(366, 356);
            this.countMes.Name = "countMes";
            this.countMes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Name = "Series1";
            this.countMes.Series.Add(series5);
            this.countMes.Size = new System.Drawing.Size(359, 195);
            this.countMes.TabIndex = 4;
            this.countMes.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = " Средняя задержка синхронная Практические значения";
            this.countMes.Titles.Add(title5);
            // 
            // var2Times
            // 
            chartArea6.Name = "ChartArea1";
            this.var2Times.ChartAreas.Add(chartArea6);
            this.var2Times.Location = new System.Drawing.Point(366, 9);
            this.var2Times.Name = "var2Times";
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Name = "Series1";
            this.var2Times.Series.Add(series6);
            this.var2Times.Size = new System.Drawing.Size(322, 202);
            this.var2Times.TabIndex = 5;
            this.var2Times.Text = "chart1";
            title6.Name = "Title1";
            title6.Text = " Средняя задержка асинхронная Практические значения";
            this.var2Times.Titles.Add(title6);
            // 
            // var2Count
            // 
            chartArea7.Name = "ChartArea1";
            this.var2Count.ChartAreas.Add(chartArea7);
            this.var2Count.Location = new System.Drawing.Point(12, 394);
            this.var2Count.Name = "var2Count";
            this.var2Count.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.BorderWidth = 5;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Name = "Series1";
            this.var2Count.Series.Add(series7);
            this.var2Count.Size = new System.Drawing.Size(294, 199);
            this.var2Count.TabIndex = 6;
            this.var2Count.Text = "chart1";
            title7.Name = "Title1";
            title7.Text = " Среднее число абонентов Практическое значения Асинхронная";
            this.var2Count.Titles.Add(title7);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 654);
            this.Controls.Add(this.var2Count);
            this.Controls.Add(this.var2Times);
            this.Controls.Add(this.countMes);
            this.Controls.Add(this.counttimes);
            this.Controls.Add(this.AverageDelaySync);
            this.Controls.Add(this.AverageDelayAsync);
            this.Controls.Add(this.AverageNumberPlot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AverageNumberPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageDelayAsync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AverageDelaySync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.counttimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.var2Times)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.var2Count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart AverageNumberPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart AverageDelayAsync;
        private System.Windows.Forms.DataVisualization.Charting.Chart AverageDelaySync;
        private System.Windows.Forms.DataVisualization.Charting.Chart counttimes;
        private System.Windows.Forms.DataVisualization.Charting.Chart countMes;
        private System.Windows.Forms.DataVisualization.Charting.Chart var2Times;
        private System.Windows.Forms.DataVisualization.Charting.Chart var2Count;
    }
}

