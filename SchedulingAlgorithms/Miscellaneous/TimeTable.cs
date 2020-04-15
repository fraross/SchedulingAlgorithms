using System;

namespace SchedulingAlgorithms.Miscellaneous
{
    class TimeTable
    {
        Process _process;
        int _processWaitingTime;

        public TimeTable(Process process, int processWaitingTime)
        {
            this._process = process;
            this._processWaitingTime = processWaitingTime;
        }

        public Process Process { get { return this._process; } }
        public int ProcessWaitingTime { get { return this._processWaitingTime; } }

        public override string ToString()
        {
            return string.Format("{0} | {1}", this.Process.ProcessNumber, this.ProcessWaitingTime);
        }
    }
}
