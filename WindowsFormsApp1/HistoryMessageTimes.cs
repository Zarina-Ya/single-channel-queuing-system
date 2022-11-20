using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class HistoryMessageTimes
    {
        private List<double> _historyTimes;

        public HistoryMessageTimes()
            => _historyTimes = new List<double>();

        public void AddMessageToHistory(double time)
            => _historyTimes.Add(time);

        private double GetAllHistoryTimes()
        {
            var res = 0.0;
            foreach (var item in _historyTimes)
                res += item;
            return res;
        }
        
        public double GetArithmeticMean()
            => GetAllHistoryTimes()/_historyTimes.Count;
    }
}
