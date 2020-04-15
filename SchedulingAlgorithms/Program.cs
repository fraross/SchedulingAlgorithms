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
            List<Process> processes = new List<Process>();

            processes.Add(new Process(1, 24));
            processes.Add(new Process(2, 3));
            processes.Add(new Process(3, 3));

            Console.WriteLine(FCFS.fromList(processes));
        }
    }
}
