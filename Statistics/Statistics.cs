using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        static float average;
        static float min;
        static float max;
        public Stats CalculateStatistics(List<float> numbers) 
        {
            numbers= new List<float>{1.5, 8.9, 3.2, 4.5});
        }
        
        
        
        
    }
    
    public class Stats
    {
        public void ReportsAverageMinMax()
        {
            StatsComputer statsComputer = new StatsComputer();
            List<float> computedStats = statsComputer.CalculateStatistics(numbers)
                
            statsComputer.average= Queryable.Average(computedStats.AsQueryable());
            statsComputer.min = computedStats.Min();
            statsComputer.max=computerStats.Max();
        }
    }
    
     
}
