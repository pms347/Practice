using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class NoOfOccurancesWord
    {
        public void getStringOccurances()
        {
            string inputStr = "mmoohhaann";
            while (inputStr.Length>0)
            {
                int count = 0;
                for(int i=0; i<inputStr.Length; i++)
                {
                    if(inputStr[0] == inputStr[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine("{0} = {1}", inputStr[0], count);
                inputStr = inputStr.Replace(inputStr[0].ToString(),string.Empty);
            }
            var wordsDic = inputStr            .GroupBy(p => p)
            .ToDictionary(p => p.Key, q => q.Count());
            
        }
    }
}
