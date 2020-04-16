using System;

namespace SchedulingAlgorithms.Miscellaneous
{
    class Process
    {
        int _processNumber;
        int _cpuBurst;
        int _arrivalTime;

        PriorityEnum _priority;

        //FCFS
        public Process(int processNumber, int cpuBurst)
        {
            this._processNumber = processNumber;
            this._cpuBurst = cpuBurst;
            this._priority = PriorityEnum.Normal;
        }

        //SJF
        public Process(int processNumber, int cpuBurst, int arrivalTime)
        {
            this._processNumber = processNumber;
            this._cpuBurst = cpuBurst;
            this._arrivalTime = arrivalTime;
            this._priority = PriorityEnum.Normal;
        }

        //Priority
        public Process(int processNumber, int cpuBurst, PriorityEnum priority) 
        { 
            this._processNumber = processNumber; 
            this._cpuBurst = cpuBurst; 
            this._priority = priority; 
        }

        //Round Robin
        public Process(int processNumber, int cpuBurst, short duration)
        {
            this._processNumber = processNumber;
            this._cpuBurst = cpuBurst;
            this._priority = PriorityEnum.Normal;
        }

        public int ProcessNumber { get { return this._processNumber; } }
        public int CpuBurst { get { return this._cpuBurst; } set { this._cpuBurst = value; } }
        public int ArrivalTime { get { return this._arrivalTime; } }
        public PriorityEnum PriorityEnum { get { return this._priority; } }

        public override string ToString()
        {
            return string.Format("{0} | Burst: {1} | Priorità: {2}", this._processNumber, this._processNumber, this._priority);
        }
    }
}
