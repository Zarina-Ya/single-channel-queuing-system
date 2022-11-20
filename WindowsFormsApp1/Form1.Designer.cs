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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.NumSubSyncPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NumSubAsyncPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GeneralPlotNumSub = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NumSubTheorPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GeneralHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistoryAsync = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistorySync = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.NumSubSyncPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSubAsyncPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralPlotNumSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSubTheorPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryAsync)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorySync)).BeginInit();
            this.SuspendLayout();
            // 
            // NumSubSyncPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.NumSubSyncPlot.ChartAreas.Add(chartArea1);
            this.NumSubSyncPlot.Location = new System.Drawing.Point(-1, 241);
            this.NumSubSyncPlot.Name = "NumSubSyncPlot";
            this.NumSubSyncPlot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.NumSubSyncPlot.Series.Add(series1);
            this.NumSubSyncPlot.Size = new System.Drawing.Size(240, 179);
            this.NumSubSyncPlot.TabIndex = 3;
            this.NumSubSyncPlot.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = " Среднее число абонентов Практическое значения Синхронная";
            this.NumSubSyncPlot.Titles.Add(title1);
            // 
            // NumSubAsyncPlot
            // 
            chartArea2.Name = "ChartArea1";
            this.NumSubAsyncPlot.ChartAreas.Add(chartArea2);
            this.NumSubAsyncPlot.Location = new System.Drawing.Point(-1, 426);
            this.NumSubAsyncPlot.Name = "NumSubAsyncPlot";
            this.NumSubAsyncPlot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series1";
            this.NumSubAsyncPlot.Series.Add(series2);
            this.NumSubAsyncPlot.Size = new System.Drawing.Size(240, 190);
            this.NumSubAsyncPlot.TabIndex = 6;
            this.NumSubAsyncPlot.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = " Среднее число абонентов Практическое значения Асинхронная";
            this.NumSubAsyncPlot.Titles.Add(title2);
            // 
            // GeneralPlotNumSub
            // 
            chartArea3.Name = "ChartArea1";
            this.GeneralPlotNumSub.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.GeneralPlotNumSub.Legends.Add(legend1);
            this.GeneralPlotNumSub.Location = new System.Drawing.Point(245, 19);
            this.GeneralPlotNumSub.Name = "GeneralPlotNumSub";
            this.GeneralPlotNumSub.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series3";
            this.GeneralPlotNumSub.Series.Add(series3);
            this.GeneralPlotNumSub.Series.Add(series4);
            this.GeneralPlotNumSub.Series.Add(series5);
            this.GeneralPlotNumSub.Size = new System.Drawing.Size(769, 623);
            this.GeneralPlotNumSub.TabIndex = 7;
            this.GeneralPlotNumSub.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = " Среднее число абонентов ";
            this.GeneralPlotNumSub.Titles.Add(title3);
            // 
            // NumSubTheorPlot
            // 
            chartArea4.Name = "ChartArea1";
            this.NumSubTheorPlot.ChartAreas.Add(chartArea4);
            this.NumSubTheorPlot.Location = new System.Drawing.Point(-1, 45);
            this.NumSubTheorPlot.Name = "NumSubTheorPlot";
            this.NumSubTheorPlot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Name = "Series1";
            this.NumSubTheorPlot.Series.Add(series6);
            this.NumSubTheorPlot.Size = new System.Drawing.Size(240, 190);
            this.NumSubTheorPlot.TabIndex = 8;
            this.NumSubTheorPlot.Text = "chart1";
            title4.Name = "Title1";
            title4.Text = "Теоритические заначения";
            this.NumSubTheorPlot.Titles.Add(title4);
            // 
            // GeneralHistory
            // 
            chartArea5.Name = "ChartArea1";
            this.GeneralHistory.ChartAreas.Add(chartArea5);
            legend2.Name = "Legend1";
            this.GeneralHistory.Legends.Add(legend2);
            this.GeneralHistory.Location = new System.Drawing.Point(1020, 1);
            this.GeneralHistory.Name = "GeneralHistory";
            this.GeneralHistory.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.GeneralHistory.Series.Add(series7);
            this.GeneralHistory.Series.Add(series8);
            this.GeneralHistory.Size = new System.Drawing.Size(548, 267);
            this.GeneralHistory.TabIndex = 11;
            this.GeneralHistory.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Средняя задержкa";
            this.GeneralHistory.Titles.Add(title5);
            // 
            // HistoryAsync
            // 
            chartArea6.Name = "ChartArea1";
            this.HistoryAsync.ChartAreas.Add(chartArea6);
            legend3.Name = "HistoryAsync";
            legend3.Title = "HistoryAsync";
            this.HistoryAsync.Legends.Add(legend3);
            this.HistoryAsync.Location = new System.Drawing.Point(1020, 274);
            this.HistoryAsync.Name = "HistoryAsync";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "HistoryAsync";
            series9.Name = "Series1";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "HistoryAsync";
            series10.Name = "Series2";
            this.HistoryAsync.Series.Add(series9);
            this.HistoryAsync.Series.Add(series10);
            this.HistoryAsync.Size = new System.Drawing.Size(455, 229);
            this.HistoryAsync.TabIndex = 13;
            this.HistoryAsync.Text = "chart2";
            // 
            // HistorySync
            // 
            chartArea7.Name = "ChartArea1";
            this.HistorySync.ChartAreas.Add(chartArea7);
            legend4.Name = "HistoryAsync";
            legend4.Title = "HistorySync";
            this.HistorySync.Legends.Add(legend4);
            this.HistorySync.Location = new System.Drawing.Point(1020, 509);
            this.HistorySync.Name = "HistorySync";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "HistoryAsync";
            series11.Name = "Series1";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "HistoryAsync";
            series12.Name = "Series2";
            this.HistorySync.Series.Add(series11);
            this.HistorySync.Series.Add(series12);
            this.HistorySync.Size = new System.Drawing.Size(455, 229);
            this.HistorySync.TabIndex = 14;
            this.HistorySync.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 977);
            this.Controls.Add(this.HistorySync);
            this.Controls.Add(this.HistoryAsync);
            this.Controls.Add(this.GeneralHistory);
            this.Controls.Add(this.NumSubTheorPlot);
            this.Controls.Add(this.GeneralPlotNumSub);
            this.Controls.Add(this.NumSubAsyncPlot);
            this.Controls.Add(this.NumSubSyncPlot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumSubSyncPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSubAsyncPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralPlotNumSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSubTheorPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryAsync)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorySync)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart NumSubSyncPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart NumSubAsyncPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart GeneralPlotNumSub;
        private System.Windows.Forms.DataVisualization.Charting.Chart NumSubTheorPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart GeneralHistory;
        protected System.Windows.Forms.DataVisualization.Charting.Chart HistoryAsync;
        protected System.Windows.Forms.DataVisualization.Charting.Chart HistorySync;
    }
}

