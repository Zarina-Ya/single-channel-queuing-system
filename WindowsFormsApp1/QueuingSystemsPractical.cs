using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public static class QueuingSystemsPractical
    {

        private static double lkr = 1.0f;
        private static  Random _rand;
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


        public static void InitPointToPlotAverageNumSubscribersAsync(int countWindow,Chart chartTimemess, Chart countMess)
        {
            var l = 0.0f;
            MinMaxPlot(chartTimemess);
            MinMaxPlot(countMess);
            while (l < lkr)
            {
                var queue = new List<double>();
                var timeMessage = new List<double>();
                var countMessageinWin = new List<double>();
                var poisson = new PoissonRandom(l);
                for (int i = 0; i < countWindow; i++)
                {
                    var countPeople = poisson.Next();
                    for (int j = 0; j < countPeople; j++)
                        queue.Add(0.0f);
                     
                    countMessageinWin.Add(queue.Count);

                    if (queue.Count > 0)
                    {
                        timeMessage.Add(queue.First() + 1.0f);

                        queue.RemoveAt(0);
                    }

                    for (int k = 0; k < queue.Count; k++)
                        queue[k] += 1.0f;

                    if(i+ 1 == countWindow && queue.Count > 0)
                    {
                        while(queue.Count > 0)
                        {
                            countMessageinWin.Add(queue.Count);
                            timeMessage.Add(queue.First() + 1.0f);

                            queue.RemoveAt(0);
                       

                        for (int k = 0; k < queue.Count; k++)
                            queue[k] += 1.0f;
                        }
                    }
                }
                double countTimes = 0.0f;
                foreach (var item in timeMessage)
                    countTimes += item;


                double countmess = 0.0f;
                foreach (var item in countMessageinWin)
                    countmess += item;

                chartTimemess.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), countTimes / timeMessage.Count);
                countMess.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), countmess / countMessageinWin.Count);

                l += 0.1f;
            }
        }

        public static void var2(int countWindow, Chart chartTimemess, Chart countMess)
        {
            var l = 0.0f;
            MinMaxPlot(chartTimemess);
            MinMaxPlot(countMess);
            _rand = new Random();
            while (l < lkr)
            {
                var queue = new List<double>();
                var timeMessage = new List<double>();
                var countMessageinWin = new List<double>();
                var poisson = new PoissonRandom(l);
                for (int i = 0; i < countWindow; i++)
                {
                    var countPeople = poisson.Next();
                    for (int j = 0; j < countPeople; j++)
                        queue.Add(_rand.NextDouble());

                    countMessageinWin.Add(queue.Count);

                    if (queue.Count > 0)
                    {
                        timeMessage.Add(queue.First() + 1.0f);

                        queue.RemoveAt(0);
                    }

                    for (int k = 0; k < queue.Count; k++)
                        queue[k] += 1.0f;

                    if (i + 1 == countWindow && queue.Count > 0)
                    {
                        while (queue.Count > 0)
                        {
                            countMessageinWin.Add(queue.Count);
                            timeMessage.Add(queue.First() + 1.0f);

                            queue.RemoveAt(0);


                            for (int k = 0; k < queue.Count; k++)
                                queue[k] += 1.0f;
                        }
                    }
                }
                double countTimes = 0.0f;
                foreach (var item in timeMessage)
                    countTimes += item;


                double countmess = 0.0f;
                foreach (var item in countMessageinWin)
                    countmess += item;

                chartTimemess.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), countTimes / timeMessage.Count);
                countMess.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), countmess / countMessageinWin.Count);

                l += 0.1f;
            }
        }

    }
}
