using SchedulingAlgorithms.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingAlgorithms.Algorithms
{
    public static class RoundRobin
    {
        static List<TimeTable> Execute(List<Process> processes, int quantum)
        {
            // Make a copy of burst times bt[] to  
            // store remaining burst times. 
            int[] rem_bt = new int[processes.Count];
            TimeTable[] timeTables = new TimeTable[processes.Count];

            for (int i = 0; i < processes.Count; i++)
                rem_bt[i] = processes[i].CpuBurst;

            int t = 0; // Current time 

            // Keep traversing processes in round 
            // robin manner until all of them are 
            // not done. 
            while (true)
            {
                bool done = true;

                // Traverse all processes one by 
                // one repeatedly 
                for (int i = 0; i < processes.Count; i++)
                {
                    // If burst time of a process 
                    // is greater than 0 then only 
                    // need to process further 
                    if (rem_bt[i] > 0)
                    {

                        // There is a pending process 
                        done = false;

                        if (rem_bt[i] > quantum)
                        {
                            // Increase the value of t i.e. 
                            // shows how much time a process 
                            // has been processed 
                            t += quantum;

                            // Decrease the burst_time of  
                            // current process by quantum 
                            rem_bt[i] -= quantum;
                        }

                        // If burst time is smaller than 
                        // or equal to quantum. Last cycle 
                        // for this process 
                        else
                        {

                            // Increase the value of t i.e. 
                            // shows how much time a process 
                            // has been processed 
                            t = t + rem_bt[i];

                            // Waiting time is current 
                            // time minus time used by  
                            // this process 
                            timeTables[i] = new TimeTable(processes[i], t - processes[i].CpuBurst, 0);

                            // As the process gets fully  
                            // executed make its remaining 
                            // burst time = 0 
                            rem_bt[i] = 0;
                        }
                    }
                }

                // If all processes are done 
                if (done == true)
                    break;
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

        static List<TimeTable> findTurnAroundTime(List<Process> processes, List<TimeTable> timeTables)
        {
            // calculating turnaround time by adding 
            // bt[i] + wt[i] 
            for (int i = 0; i < processes.Count; i++)
                timeTables[i].TurnAroundTime = processes[i].CpuBurst + timeTables[i].ProcessWaitingTime;

            return timeTables;
        }

        public static string toString(List<TimeTable> timeTables)
        {
            string result = "";

            timeTables.ForEach(x => result += x.ToString() + "\n");

            return result;
        }

        public static List<TimeTable> fromList(List<Process> process, int quantum)
        {
            return findTurnAroundTime(process, Execute(process, quantum));
        }
    }
}
