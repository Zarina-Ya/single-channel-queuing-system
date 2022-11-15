using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public static class QueuingSystemsTheoretical
    {
        private static double lkr = 1.0f;
        public static void InitPointToPlotAverageNumSubscribers(Chart chart)
        {
            SignAxis("l", "N(l)", chart);
            MinMaxPlot(chart);
            double l = 0.0f;
            while( l < lkr)
            {
                chart.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), AverageNumSubscribers(l));
                l += 0.1f;
            }
        }
        private static void MinMaxPlot(Chart chart)
        {
            chart.ChartAreas[0].AxisX.Maximum = 1;
            chart.ChartAreas[0].AxisX.Minimum = 0;
        }

        private static void SignAxis(string x, string y, Chart chart)
        {
        

            Axis ax = new Axis();
            ax.Title = x;
            chart.ChartAreas[0].AxisX = ax;
            Axis ay = new Axis();
            ay.Title = y;
            chart.ChartAreas[0].AxisY = ay;

        }


        public static void InitPointToPlotAverageDelay(Chart chart, bool isAsync)
        {
            SignAxis("l", "d(l)", chart);
            MinMaxPlot( chart);
            double l = 0.0f;

            while (l < lkr)
            {
                var Nl = AverageNumSubscribers(l)/l;
                chart.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), (isAsync ? Nl : Nl + 0.5f));
                l += 0.1f;
            }
        }

        private static double AverageNumSubscribers(double l)
            => l*(2 - l)/(2*(1 - l));

    }
}
