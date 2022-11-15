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
            InitializeComponent();
            QueuingSystemsTheoretical.InitPointToPlotAverageNumSubscribers(AverageNumberPlot, GeneralPlotCount);
            QueuingSystemsTheoretical.InitPointToPlotAverageDelay(AverageDelayAsync, true, GeneralDelaySync, generalAsync);
            QueuingSystemsTheoretical.InitPointToPlotAverageDelay(AverageDelaySync, false, GeneralDelaySync, generalAsync) ;
            QueuingSystemsPractical.InitPointToPlotAverageNumSubscribersAsync(10000, counttimes, countMes, GeneralPlotCount, GeneralDelaySync);
            QueuingSystemsPractical.var2(10000, var2Times, var2Count, GeneralPlotCount, generalAsync);
        }

        private void AverageDelayAsync_Click(object sender, EventArgs e)
        {

        }
    }
}
