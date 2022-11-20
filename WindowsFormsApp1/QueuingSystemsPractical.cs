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

        private static void SendFirstMessage(QueueMessageTime queueMessage, HistoryMessageTimes history )
        {
            if (queueMessage.Count > 0)
            {
                history.AddMessageToHistory(queueMessage.GetFirstMessage() + 1.0f);
                queueMessage.RemoveFirst();
            }

            queueMessage.AddWaiting();
        }

        private static void SendRemainingMessages(QueueMessageTime queueMessage,
            HistoryMessageTimes history,
            List<double> countMessageinWin)
        {
            while (queueMessage.Count > 0)
            {
                countMessageinWin.Add(queueMessage.Count);
                history.AddMessageToHistory(queueMessage.GetFirstMessage() + 1.0f);
                queueMessage.RemoveFirst();
                queueMessage.AddWaiting();
            }
        }


        private static void InitPlotsForAsyncModulation(
            double l,
            double historyArithmeticMean,
            double countMessageArithmeticMean, 
            Chart histories,
            Chart generalHistiries,
            Chart countMessagePlot, 
            Chart generalCountMessage)
        {
            histories.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), historyArithmeticMean);
            histories.Series[0].LegendText = "ASync";
            generalHistiries.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), historyArithmeticMean);
            generalHistiries.Series[0].LegendText = "ASync";

            countMessagePlot.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), countMessageArithmeticMean);

            generalCountMessage.Series[1].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), countMessageArithmeticMean);
            generalCountMessage.Series[1].LegendText = "Async";
        }

        private static void InitPlotsForSyncModulation(
            double l,
            double historyArithmeticMean,
            double countMessageArithmeticMean,
            Chart histories,
            Chart generalHistiries,
            Chart countMessagePlot,
            Chart generalCountMessage)
        {

            histories.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), historyArithmeticMean);
            histories.Series[0].LegendText = "Sync";
            generalHistiries.Series[1].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), historyArithmeticMean);
            generalHistiries.Series[1].LegendText = "Sync";
            countMessagePlot.Series[0].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), countMessageArithmeticMean);
            generalCountMessage.Series[2].Points.AddXY(Math.Round(l, 1, MidpointRounding.AwayFromZero), countMessageArithmeticMean);
            generalCountMessage.Series[2].LegendText = "Sync";
        }


        public static void InitPointToPlotAverageNumSubscribersAsync(
            int countWindow,
            Chart historiesPlot, 
            Chart countMessPlot, 
            Chart generalHistories, 
            Chart generalCountMess)
        {
            var l = 0.0f;
            MinMaxPlot(historiesPlot);
            MinMaxPlot(countMessPlot);
            MinMaxPlot(generalCountMess);
            MinMaxPlot(generalHistories);
            SignAxis("l", "N(l)", countMessPlot);
            while (l < lkr)
            {
             
                var queueMessage = new QueueMessageTime();
                var history = new HistoryMessageTimes();

                var countMessageinWin = new List<double>();
                var poisson = new PoissonRandom(l);
                for (int i = 0; i < countWindow; i++)
                {
                    var countPeople = poisson.Next();
                    queueMessage.AddToQueuePeople(countPeople);/// КОЛ-ВО ЛЮДЕЙ ПРИДЕДШИХ 

                    countMessageinWin.Add(queueMessage.Count);

                    SendFirstMessage(queueMessage, history);
                }
                SendRemainingMessages(queueMessage, history, countMessageinWin);


                double countmess = 0.0f;
                foreach (var item in countMessageinWin)
                    countmess += item;

                InitPlotsForAsyncModulation(l,history.GetArithmeticMean(), countmess/countMessageinWin.Count, historiesPlot, generalHistories, countMessPlot, generalCountMess );

                l += 0.1f;
            }
        }

        public static void InitPointToPlotAverageNumSubscribersSync(
            int countWindow, 
            Chart histories,
            Chart countMess,
            Chart generalHistories, 
            Chart generalCountMessage)
        {
            var l = 0.0f;
            MinMaxPlot(histories);
            MinMaxPlot(countMess);
            MinMaxPlot(generalCountMessage);
            SignAxis("l", "N(l)", countMess);
            SignAxis("l", "N(l)", generalCountMessage);
            SignAxis("l", "d(l)", histories);
            SignAxis("l", "d(l)", generalHistories);
            while (l < lkr)
            {
                var queueMessage = new QueueMessageTime();
                var history = new HistoryMessageTimes();
                var countMessageinWin = new List<double>();
                var poisson = new PoissonRandom(l);
                for (int i = 0; i < countWindow; i++)
                {
                    var countPeople = poisson.Next();
                    queueMessage.AddToQueuePeople(countPeople, _rand);

                    countMessageinWin.Add(queueMessage.Count);

                    SendFirstMessage(queueMessage, history);

             
                }
                SendRemainingMessages(queueMessage, history, countMessageinWin);

         

                double countmess = 0.0f;
                foreach (var item in countMessageinWin)
                    countmess += item;

                InitPlotsForSyncModulation(l, history.GetArithmeticMean(), countmess/countMessageinWin.Count, histories, generalHistories, countMess, generalCountMessage);
               l += 0.1f;
            }
        }

    }
}
