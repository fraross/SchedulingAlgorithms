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
            int[] remaininBursts = new int[processes.Count];
            TimeTable[] timeTables = new TimeTable[processes.Count];

            for (int i = 0; i < processes.Count; i++)
                remaininBursts[i] = processes[i].CpuBurst;

            int t = 0;

            while (true)
            {
                bool done = true;

                for (int i = 0; i < processes.Count; i++)
                {
                    if (remaininBursts[i] > 0)
                    {
                        done = false;

                        if (remaininBursts[i] > quantum)
                        {
                            t += quantum; 
                            remaininBursts[i] -= quantum;
                        }
                        else
                        {
                            t = t + remaininBursts[i];
                            timeTables[i] = new TimeTable(processes[i], t - processes[i].CpuBurst, 0);
                            remaininBursts[i] = 0;
                        }
                    }
                }
 
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
