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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            processes = new BindingList<Process>();

            var source = new BindingSource(processes, null);
            dataGridViewProcess.DataSource = source;

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
            var list = FCFS.fromList(processes.ToList());
            MessageBox.Show(FCFS.toString(list) + "\n\nTempo medio di attesa: " + calcoloMedia(list));
        }

        private void sjf_Click(object sender, EventArgs e)
        {
            var list = SJF.fromList(processes.ToList());
            MessageBox.Show(SJF.toString(list) + "\n\nTempo medio di attesa: " + calcoloMedia(list));
        }

        private void priorityButton_Click(object sender, EventArgs e)
        {
            var list = Priority.fromList(processes.ToList());
            MessageBox.Show(Priority.toString(list) + "\n\nTempo medio di attesa: " + calcoloMedia(list));
        }

        private void roundRobin_Click(object sender, EventArgs e)
        {
            int quantum;

            if (int.TryParse(this.quantum.Text, out quantum))
            {
                var list = RoundRobin.fromList(processes.ToList(), quantum);
                MessageBox.Show(RoundRobin.toString(list) + "\n\nTempo medio di attesa: " + calcoloMedia(list));
            }
            else
                MessageBox.Show("Parameter missing");
        }

        private string calcoloMedia(List<TimeTable> timeTables)
        {
            return timeTables.Average(x => x.ProcessWaitingTime).ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            processes.Clear();
        }
    }
}
