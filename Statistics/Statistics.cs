using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        
        public Stats CalculateStatistics(List<float> numbers) 
        {
            int sum=0;
            Stats s = new Stats();
            
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
            
            if(s.max>10.2)
            {
                
                return s;
            }
            
            return s;
        }
        
        
        
        
    }
    
     public class Stats
    {
         float average, min, max = 0f; 
 
    
    
    
     
}
