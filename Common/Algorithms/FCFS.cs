using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SchedulingAlgorithms.Miscellaneous;

namespace SchedulingAlgorithms.Algorithms
{
    public static class FCFS
    {
        static List<TimeTable> Execute(List<Process> process)
        {
            List<TimeTable> timeTables = new List<TimeTable>();

            timeTables.Add(new TimeTable(process[0], 0, 0));

            for (int i = 1; i < process.Count; i++)
            {
                int waitTime = process[i - 1].CpuBurst + timeTables[i - 1].ProcessWaitingTime;
                timeTables.Add(new TimeTable(process[i], waitTime, 0));
            }

            for (int i = 0; i < process.Count; i++)
            {
                int turnAroundTime = process[i].CpuBurst + timeTables[i].ProcessWaitingTime;
                timeTables[i].TurnAroundTime = turnAroundTime;
            }

            return timeTables;
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
