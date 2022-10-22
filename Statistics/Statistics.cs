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
           
            StatsComputer sc = new StatsComputer();
            sc.average = (sum) / numbers.Count;
            sc.min = numbers[0];
            sc.max = numbers[numbers.Count-1];
            s.average = sc.average;
            s.min = sc.min;
            s.max = sc.max;
           
            
            
            
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
