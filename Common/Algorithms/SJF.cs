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
            List<TimeTable> timeTables = new List<TimeTable>();

            //metto in ordine di grandezza i processi 
            process = process.OrderBy(x => x.CpuBurst).ToList();

            timeTables.Add(new TimeTable(process[0], 0, 0));

            int i = 0;
            process.ForEach(x =>
            {
                if(i > 0)
                    timeTables.Add(new TimeTable(process[i], process[i - 1].CpuBurst + timeTables[i - 1].ProcessWaitingTime, 0));
                i++;
            });

            for (i = 0; i < process.Count; i++)
            {
                timeTables[i].TurnAroundTime = process[i].CpuBurst + timeTables[i].ProcessWaitingTime;
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
