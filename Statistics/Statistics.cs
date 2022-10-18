using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        static float average, min, max = 0.0;
        public Stats CalculateStatistics(List<float> numbers) 
        {
            int sum=0;
            Stats s = new Stats();
            
            
            
            numbers = numbers.Sort();
            
            
            if(numbers.Any())
            {
                foreach(int num in numbers)
                {
                    sum += num;
                }
            }
            
            s.average = (sum) / numbers.Count;
            s.min = numbers[0];
            s.max = numbers[numbers.Count-1];
            average = s.average;
            max=s.max;
            min = s.min;
            
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
