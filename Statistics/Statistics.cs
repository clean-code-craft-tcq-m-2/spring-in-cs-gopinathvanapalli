using System;
using System.Collections.Generic;

namespace Statistics
{
    class StatsComputer
    {
         public static Stats s = new Stats();
        public StatsComputer()
        {
             float average;
             float min;
             float max;
            
        }
        
        public Stats CalculateStatistics(List<float> numbers) 
        {
            int sum=0;
            
            
            if(numbers.Count<1)
            {
                return s;
            }
            
            numbers.Sort();
            
            
            
                foreach(int num in numbers)
                {
                    sum += num;
                }
           
            
            s.average = (sum) / numbers.Count;
            s.min = numbers[0];
            s.max = numbers[numbers.Count-1];
            average = s.average;
            min = s.min;
            max = s.max;
           
            
            
            
            return s;
        }
     
    
     public class Stats
    {
          public float average {get; set;} 
          public float min {get; set;}
          public float max {get; set;}
         
    }
 
    
    
    
     
}
}
