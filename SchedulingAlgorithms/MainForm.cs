using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SchedulingAlgorithms.Algorithms;
using SchedulingAlgorithms.Miscellaneous;

namespace SchedulingAlgorithms
{
    public partial class MainForm : Form
    {
        BindingList<Process> processes;
        BindingList<TimeTable> results;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            processes = new BindingList<Process>();
            results = new BindingList<TimeTable>();

            var source = new BindingSource(processes, null);
            dataGridViewProcess.DataSource = source;

            var sourceResults = new BindingSource(results, null);
            dataGridViewResults.DataSource = sourceResults;

            priority.DataSource = Enum.GetValues(typeof(PriorityEnum));
            priority.SelectedItem = PriorityEnum.Normal;
        }

        private void SanitizeInput(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(((TextBox)sender).Text.Length - 1);
            }
        }

        private void addProcess_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(cpuBurst.Text))
            {
                Process process = new Process(processes.Count + 1, int.Parse(cpuBurst.Text), (PriorityEnum)priority.SelectedItem);

                processes.Add(process);
            }
        }

        private void fcfs_Click(object sender, EventArgs e)
        {
            if(processes.Count > 0)
            {
                var res = FCFS.fromList(processes.ToList());

                results.Clear();
                res.ForEach(x => results.Add(x));

                textBoxAvg.Text = calcoloMedia(results);
            }
        }

        private void sjf_Click(object sender, EventArgs e)
        {
            if (processes.Count > 0)
            {
                var res = SJF.fromList(processes.ToList());

                results.Clear();
                res.ForEach(x => results.Add(x));

                textBoxAvg.Text = calcoloMedia(results);
            }
        }

        private void priorityButton_Click(object sender, EventArgs e)
        {
            if (processes.Count > 0)
            {
                var res = Priority.fromList(processes.ToList());

                results.Clear();
                res.ForEach(x => results.Add(x));

                textBoxAvg.Text = calcoloMedia(results);
            }
        }

        private void roundRobin_Click(object sender, EventArgs e)
        {
            if (processes.Count > 0)
            {
                int quantum;

                if (int.TryParse(this.quantum.Text, out quantum))
                {
                    var res = RoundRobin.fromList(processes.ToList(), quantum);

                    results.Clear();
                    res.ForEach(x => results.Add(x));

                    textBoxAvg.Text = calcoloMedia(results);
                }
                else
                    MessageBox.Show("Parameter missing");
            }
        }

        private string calcoloMedia(BindingList<TimeTable> timeTables)
        {
            return timeTables.Average(x => x.ProcessWaitingTime).ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            processes.Clear();
        }
    }
}
