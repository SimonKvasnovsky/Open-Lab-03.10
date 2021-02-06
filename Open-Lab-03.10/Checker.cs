using System;
using System.Threading;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int count = 0;          
            foreach (char c in str)
            { 
                if (letter==c)
                    count++;                           
            }
            return count;

        }
        
        

        
        
          
    

    }
}
