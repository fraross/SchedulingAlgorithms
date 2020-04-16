using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SchedulingAlgorithms.Miscellaneous;

namespace SchedulingAlgorithms.Algorithms
{
    static class SJF
    {
        static List<TimeTable> Execute(List<Process> process)
        {
            int[] rt = new int[process.Count];
            TimeTable[] timeTables = new TimeTable[process.Count];

            // Copy the burst time into rt[] 
            for (int i = 0; i < process.Count; i++)
                rt[i] = process[i].CpuBurst;

            int complete = 0, t = 0, minm = int.MaxValue;
            int shortest = 0, finish_time;
            bool check = false;

            // Process until all processes gets 
            // completed 
            while (complete != process.Count)
            {

                // Find process with minimum 
                // remaining time among the 
                // processes that arrives till the 
                // current time` 
                for (int j = 0; j < process.Count; j++)
                {
                    if ((process[j].ArrivalTime <= t) &&
                    (rt[j] < minm) && rt[j] > 0)
                    {
                        minm = rt[j];
                        shortest = j;
                        check = true;
                    }
                }

                if (check == false)
                {
                    t++;
                    continue;
                }

                // Reduce remaining time by one 
                rt[shortest]--;

                // Update minimum 
                minm = rt[shortest];
                if (minm == 0)
                    minm = int.MaxValue;

                // If a process gets completely 
                // executed 
                if (rt[shortest] == 0)
                {

                    // Increment complete 
                    complete++;
                    check = false;

                    // Find finish time of current 
                    // process 
                    finish_time = t + 1;

                    // Calculate waiting time
                    int waitTime = finish_time - process[shortest].CpuBurst - process[shortest].ArrivalTime;

                    // Calculate Turn Around Time

                    timeTables[shortest] = new TimeTable(process[shortest], waitTime, 0);

                    if (timeTables[shortest].ProcessWaitingTime < 0)
                        timeTables[shortest].ProcessWaitingTime = 0;
                }
                // Increment time 
                t++;
            }

            for (int i = 0; i < process.Count; i++)
            {
                timeTables[i].TurnAroundTime = process[i].CpuBurst + timeTables[i].ProcessWaitingTime;
            }

            return toList(timeTables);
        }

        static List<TimeTable> toList(TimeTable[] timeTables)
        {
            List<TimeTable> result = new List<TimeTable>();

            for (int i = 0; i < timeTables.Length; i++)
            {
                result.Add(timeTables[i]);
            }

            return result;
        }

        public static string fromList(List<Process> process)
        {
            string result = "";

            List<TimeTable> timeTables = Execute(process);

            timeTables.ForEach(x => result += x.ToString() + "\n");

            return result;
        }
    }
}
