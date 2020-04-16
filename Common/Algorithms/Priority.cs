using SchedulingAlgorithms.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingAlgorithms.Algorithms
{
    public static class Priority
    {
        static List<TimeTable> Execute(List<Process> processes)
        {
            List<TimeTable> timeTables = new List<TimeTable>();
            processes = processes.OrderByDescending(x => x.PriorityEnum).ToList();

            int k = 0;

            processes.ForEach(x =>
            {
                if(k != 0)
                {
                    int waitTime = processes[k - 1].CpuBurst + timeTables[k - 1].ProcessWaitingTime;
                    timeTables.Add(new TimeTable(x, waitTime, 0));
                }
                else
                    timeTables.Add(new TimeTable(processes[0], 0, 0 ));
                k++;
            });

            k = 0;
            processes.ForEach(x =>
            {
                int turnAroundTime = processes[k].CpuBurst + timeTables[k].ProcessWaitingTime;
                timeTables[k].TurnAroundTime = turnAroundTime;
                k++;
            });

            return timeTables;
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
