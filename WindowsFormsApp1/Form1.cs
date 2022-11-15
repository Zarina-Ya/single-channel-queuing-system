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
            QueuingSystemsTheoretical.InitPointToPlotAverageNumSubscribers(AverageNumberPlot);
            QueuingSystemsTheoretical.InitPointToPlotAverageDelay(AverageDelayAsync, true);
            QueuingSystemsTheoretical.InitPointToPlotAverageDelay(AverageDelaySync, false) ;
            QueuingSystemsPractical.InitPointToPlotAverageNumSubscribersAsync(10000, counttimes, countMes);
            QueuingSystemsPractical.var2(10000, var2Times, var2Count);
        }

        private void AverageDelayAsync_Click(object sender, EventArgs e)
        {

        }
    }
}
