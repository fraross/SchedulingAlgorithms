using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SchedulingAlgorithms.Miscellaneous;

namespace SchedulingAlgorithms.Algorithms
{
    public static class SJF
    {
        static List<TimeTable> Execute(List<Process> process)
        {
            int[] rt = new int[process.Count];
            TimeTable[] timeTables = new TimeTable[process.Count];

            // Copy the burst time into rt[] 
            for (int i = 0; i < process.Count; i++)
                rt[i] = process[i].CpuBurst;

            int completedProcess = 0, t = 0, minimumTime = int.MaxValue;
            int shortestProcess = 0, finishTime;
            bool check = false;

            // Process until all processes gets 
            // completed 
            while (completedProcess != process.Count)
            {

                // Find process with minimum 
                // remaining time among the 
                // processes that arrives till the 
                // current time` 
                for (int j = 0; j < process.Count; j++)
                {
                    if ((0 <= t) &&
                    (rt[j] < minimumTime) && rt[j] > 0)
                    {
                        minimumTime = rt[j];
                        shortestProcess = j;
                        check = true;
                    }
                }

                if (check == false)
                {
                    t++;
                    continue;
                }

                // Reduce remaining time by one 
                rt[shortestProcess]--;

                // Update minimum 
                minimumTime = rt[shortestProcess];
                if (minimumTime == 0)
                    minimumTime = int.MaxValue;

                // If a process gets completely 
                // executed 
                if (rt[shortestProcess] == 0)
                {

                    // Increment complete 
                    completedProcess++;
                    check = false;

                    // Find finish time of current 
                    // process 
                    finishTime = t + 1;

                    // Calculate waiting time
                    int waitTime = finishTime - process[shortestProcess].CpuBurst;

                    // Calculate Turn Around Time

                    timeTables[shortestProcess] = new TimeTable(process[shortestProcess], waitTime, 0);

                    if (timeTables[shortestProcess].ProcessWaitingTime < 0)
                        timeTables[shortestProcess].ProcessWaitingTime = 0;
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

        public static string toString(List<TimeTable> timeTables)
        {
            string result = "";

            timeTables.ForEach(x => result += x.ToString() + "\n");

            return result;
        }

        public static List<TimeTable> fromList(List<Process> process)
        {
            return Execute(process);
        }
    }
}
