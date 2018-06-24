using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WandS
{
    class Solution
    {
        public int solution(int[] T)
        {
            int days = 0, prevdays = 0;
            if (T.Length == 2) days = 1;

            int index = 0,indexprev = 0;
            int count = 0;
            for (int i = 0; i < T.Length - 1; i++)
            {
                if (T[i + 1] > T[i])
                {
                    indexprev = index;
                    index = i+1;
                }
                if (index > indexprev)
                {
                    for (int j = 0; j < index; j++)
                        if (T[index] > T[j])
                            count++;
                    if (count == index)
                    {
                        prevdays = days;
                        if (prevdays == 0)
                        days = count;
                    }
                    count = 0;
                }
            }

            return days;
        }

       
    }
}
