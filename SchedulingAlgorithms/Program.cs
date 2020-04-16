using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SchedulingAlgorithms.Algorithms;
using SchedulingAlgorithms.Miscellaneous;

namespace SchedulingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //FCFS
            //List<Process> processes = new List<Process>();

            //processes.Add(new Process(1, 10));
            //processes.Add(new Process(2, 5));
            //processes.Add(new Process(3, 8));

            //Console.WriteLine(FCFS.fromList(processes));

            //SJF
            //List<Process> processes = new List<Process>();

            //processes.Add(new Process(1, 6, 1));
            //processes.Add(new Process(2, 8, 1));
            //processes.Add(new Process(3, 7, 2));
            //processes.Add(new Process(4, 3, 3));

            //Console.WriteLine(SJF.fromList(processes));

            //Priority
            //List<Process> processes = new List<Process>();

            //processes.Add(new Process(1, 10, PriorityEnum.Normal));
            //processes.Add(new Process(2, 5, PriorityEnum.Critical));
            //processes.Add(new Process(3, 8, PriorityEnum.High));

            //Console.WriteLine(Priority.fromList(processes));

            //Round Robin
            List<Process> processes = new List<Process>();

            processes.Add(new Process(1, 10, PriorityEnum.Normal));
            processes.Add(new Process(2, 5, PriorityEnum.Critical));
            processes.Add(new Process(3, 8, PriorityEnum.High));

            Console.WriteLine(RoundRobin.fromList(processes, 2));
        }
    }
}
