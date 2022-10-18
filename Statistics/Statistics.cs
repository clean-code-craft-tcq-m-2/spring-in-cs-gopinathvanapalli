using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        float average;
        float min;
        float max;
        public Stats CalculateStatistics(List<float> numbers) 
        {
            //Implement statistics here
        }
        
        
        
        
    }
    
    public class Stats
    {
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<___>{1.5, 8.9, 3.2, 4.5});
            statsComputer.average= Queryable.Average(computedStats.AsQueryable());
            statsComputer.min = computedStats.Min();
            statsComputer.max=ComputerStats.Max();
        }
    }
    
     
}
