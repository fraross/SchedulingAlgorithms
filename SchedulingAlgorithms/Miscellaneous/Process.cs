using System;

namespace SchedulingAlgorithms.Miscellaneous
{
    class Process
    {
        int _processNumber;
        int _cpuBurst;
        PriorityEnum _priority;

        public Process(int processNumber, int cpuBurst)
        {
            this._processNumber = processNumber;
            this._cpuBurst = cpuBurst;
            this._priority = PriorityEnum.Normal;
        }

        public Process(int processNumber, int cpuBurst, PriorityEnum priority) 
        { 
            this._processNumber = processNumber; 
            this._cpuBurst = cpuBurst; 
            this._priority = priority; 
        }

        public int ProcessNumber { get { return this._processNumber; } }
        public int CpuBurst { get { return this._cpuBurst; } }
        public PriorityEnum PriorityEnum { get { return this._priority; } }

        public override string ToString()
        {
            return string.Format("{0} | Burst: {1} | Priorità: {2}", this._processNumber, this._processNumber, this._priority);
        }
    }
}
