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

                int arrivalTime;
                if (int.TryParse(this.arrivalTime.Text, out arrivalTime))
                    process.ArrivalTime = arrivalTime;

                processes.Add(process);
                //dataGridViewProcess.Rows.Add(process)
            }
        }

        private void fcfs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FCFS.fromList(processes.ToList()));
        }

        private void sjf_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SJF.fromList(processes.ToList()));
        }

        private void priorityButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Priority.fromList(processes.ToList()));
        }

        private void roundRobin_Click(object sender, EventArgs e)
        {
            int quantum;

            if (int.TryParse(this.quantum.Text, out quantum))
                MessageBox.Show(RoundRobin.fromList(processes.ToList(), quantum));
            else
                MessageBox.Show("Parameter missing");
        }
    }
}
