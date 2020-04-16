using System;

namespace SchedulingAlgorithms.Miscellaneous
{
    public class TimeTable
    {
        Process _process;
        int _processWaitingTime;
        int _turnAroundTime;

        public TimeTable(Process process, int processWaitingTime, int turnAroundTime)
        {
            this._process = process;
            this._processWaitingTime = processWaitingTime;
            this._turnAroundTime = turnAroundTime;
        }

        public Process Process { get { return this._process; } }
        public int ProcessWaitingTime { get { return this._processWaitingTime; } set { this._processWaitingTime = value; } }
        public int TurnAroundTime { get { return this._turnAroundTime; } set { this._turnAroundTime = value; } }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", this.Process.ProcessNumber, this.ProcessWaitingTime, this._turnAroundTime);
        }
    }
}
