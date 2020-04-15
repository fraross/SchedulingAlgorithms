﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SchedulingAlgorithms.Miscellaneous;

namespace SchedulingAlgorithms.Algorithms
{
    static class FCFS
    {
        static List<TimeTable> Execute(List<Process> process)
        {
            List<TimeTable> timeTables = new List<TimeTable>();

            timeTables.Add(new TimeTable(process[0], 0));

            for (int i = 1; i < process.Count; i++)
            {
                int waitingTime = timeTables[i - 1].ProcessWaitingTime;
                if(i != 1)
                    timeTables.Add(new TimeTable(process[i], waitingTime + process[i].CpuBurst));
                else
                    timeTables.Add(new TimeTable(process[i], process[i - 1].CpuBurst));
            }

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