using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        
        public Stats CalculateStatistics(List<float> numbers) 
        {
            int sum=0;
            float average, min, max = 0.0;
            
            numbers = numbers.Sort();
            Stats s = new Stats();
            
            if(numbers.Any())
            {
                foreach(int num in numbers)
                {
                    sum += num;
                }
            }
            
            s.average = (sum) / numbers.Count();
            s.min = numbers[0];
            s.max = numbers[numbers.Count-1];
            
            return NaN;
        }
        
        
        
        
    }
    
    public class Stats
    {
        public float average {get;set;}
        public float min {get;set;}
        public float max {get;set;}
    }
    
     
}
