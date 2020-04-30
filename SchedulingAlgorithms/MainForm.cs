using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;

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
            priority.SelectedItem = PriorityEnum.Priority1;



            if (File.Exists("processi.txt"))
            {
                StreamReader streamReader = new StreamReader("processi.txt");
                int i = 1;

                while (!streamReader.EndOfStream)
                {
                    string[] line = streamReader.ReadLine().Split(' ');
                    processes.Add(new Process(i, int.Parse(line[0]), (PriorityEnum)int.Parse(line[1])));
                    i++;
                }
            }
        }

        private void SanitizeInput(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(((TextBox)sender).Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ((TextBox)sender).Text = ((TextBox)sender).Text.Remove(((TextBox)sender).Text.Length - 1);
            }
        }

        private void AddProcess_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(cpuBurst.Text))
            {
                Process process = new Process(processes.Count + 1, int.Parse(cpuBurst.Text), (PriorityEnum)priority.SelectedItem);

                processes.Add(process);
            }
        }

        private void FCFS_Click(object sender, EventArgs e)
        {
            if(processes.Count > 0)
            {
                var res = FCFS.fromList(processes.ToList());

                results.Clear();
                res.ForEach(x => results.Add(x));

                textBoxAvg.Text = CalcoloMedia(results);
            }
        }

        private void SJF_Click(object sender, EventArgs e)
        {
            if (processes.Count > 0)
            {
                var res = SJF.fromList(processes.ToList());

                results.Clear();
                res.ForEach(x => results.Add(x));

                textBoxAvg.Text = CalcoloMedia(results);
            }
        }

        private void Priority_Click(object sender, EventArgs e)
        {
            if (processes.Count > 0)
            {
                var res = Priority.fromList(processes.ToList());

                results.Clear();
                res.ForEach(x => results.Add(x));

                textBoxAvg.Text = CalcoloMedia(results);
            }
        }

        private void RoundRobin_Click(object sender, EventArgs e)
        {
            if (processes.Count > 0)
            {
                int quantum;

                if (int.TryParse(this.quantum.Text, out quantum))
                {
                    var res = RoundRobin.fromList(processes.ToList(), quantum);

                    results.Clear();
                    res.ForEach(x => results.Add(x));

                    textBoxAvg.Text = CalcoloMedia(results);
                }
                else
                    MessageBox.Show("Parameter missing");
            }
        }

        private string CalcoloMedia(BindingList<TimeTable> timeTables)
        {
            return timeTables.Average(x => x.ProcessWaitingTime).ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            processes.Clear();
        }
    }
}
