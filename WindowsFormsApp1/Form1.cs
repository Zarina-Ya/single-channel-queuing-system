using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            double accuracy = 0.001;
            int selection = (int)(9 / Math.Pow(4 * accuracy, 2));
            InitializeComponent();
            QueuingSystemsTheoretical.InitPointToPlotAverageNumSubscribers(NumSubTheorPlot, GeneralPlotNumSub);

            QueuingSystemsTheoretical.InitPointToPlotAverageDelay( true, HistorySync, HistoryAsync);
            QueuingSystemsTheoretical.InitPointToPlotAverageDelay( false, HistorySync, HistoryAsync) ;

            QueuingSystemsPractical.InitPointToPlotAverageNumSubscribersAsync(selection, HistoryAsync, NumSubAsyncPlot, GeneralHistory, GeneralPlotNumSub);
            QueuingSystemsPractical.InitPointToPlotAverageNumSubscribersSync(selection, HistorySync, NumSubSyncPlot, GeneralHistory, GeneralPlotNumSub);
        }

        private void AverageDelayAsync_Click(object sender, EventArgs e)
        {

        }
    }
}
