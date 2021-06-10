
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverWorkJsonLoader
{
    public static class UtilityClass
    {
        public static decimal GetMedian(List<decimal> data)
        {
            data.Sort();
            if(data.Count % 2 == 1)
            {
                return data[data.Count / 2];
            }
            else
            {
                return ((data[data.Count / 2] + data[data.Count / 2 - 1]) / 2);
            }
        }
    }
}
