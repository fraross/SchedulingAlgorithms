namespace SchedulingAlgorithms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewProcess = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.addProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.ComboBox();
            this.cpuBurst = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantum = new System.Windows.Forms.TextBox();
            this.roundRobin = new System.Windows.Forms.Button();
            this.priorityButton = new System.Windows.Forms.Button();
            this.sjf = new System.Windows.Forms.Button();
            this.fcfs = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAvg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProcess
            // 
            this.dataGridViewProcess.AllowUserToAddRows = false;
            this.dataGridViewProcess.AllowUserToDeleteRows = false;
            this.dataGridViewProcess.AllowUserToResizeColumns = false;
            this.dataGridViewProcess.AllowUserToResizeRows = false;
            this.dataGridViewProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcess.Location = new System.Drawing.Point(12, 188);
            this.dataGridViewProcess.Name = "dataGridViewProcess";
            this.dataGridViewProcess.Size = new System.Drawing.Size(375, 361);
            this.dataGridViewProcess.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetButton);
            this.groupBox1.Controls.Add(this.addProcess);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.priority);
            this.groupBox1.Controls.Add(this.cpuBurst);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processi";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(14, 131);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(355, 29);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // addProcess
            // 
            this.addProcess.Location = new System.Drawing.Point(14, 98);
            this.addProcess.Name = "addProcess";
            this.addProcess.Size = new System.Drawing.Size(355, 29);
            this.addProcess.TabIndex = 13;
            this.addProcess.Text = "Aggiungi";
            this.addProcess.UseVisualStyleBackColor = true;
            this.addProcess.Click += new System.EventHandler(this.AddProcess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Priorità";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPU Burst";
            // 
            // priority
            // 
            this.priority.FormattingEnabled = true;
            this.priority.Location = new System.Drawing.Point(75, 57);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(294, 28);
            this.priority.TabIndex = 8;
            // 
            // cpuBurst
            // 
            this.cpuBurst.Location = new System.Drawing.Point(100, 25);
            this.cpuBurst.Name = "cpuBurst";
            this.cpuBurst.Size = new System.Drawing.Size(269, 26);
            this.cpuBurst.TabIndex = 6;
            this.cpuBurst.TextChanged += new System.EventHandler(this.SanitizeInput);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.quantum);
            this.groupBox2.Controls.Add(this.roundRobin);
            this.groupBox2.Controls.Add(this.priorityButton);
            this.groupBox2.Controls.Add(this.sjf);
            this.groupBox2.Controls.Add(this.fcfs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(398, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 215);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algoritmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantum";
            // 
            // quantum
            // 
            this.quantum.Location = new System.Drawing.Point(100, 141);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(268, 29);
            this.quantum.TabIndex = 4;
            this.quantum.TextChanged += new System.EventHandler(this.SanitizeInput);
            // 
            // roundRobin
            // 
            this.roundRobin.Location = new System.Drawing.Point(5, 176);
            this.roundRobin.Name = "roundRobin";
            this.roundRobin.Size = new System.Drawing.Size(363, 29);
            this.roundRobin.TabIndex = 3;
            this.roundRobin.Text = "Round Robin";
            this.roundRobin.UseVisualStyleBackColor = true;
            this.roundRobin.Click += new System.EventHandler(this.RoundRobin_Click);
            // 
            // priorityButton
            // 
            this.priorityButton.Location = new System.Drawing.Point(6, 98);
            this.priorityButton.Name = "priorityButton";
            this.priorityButton.Size = new System.Drawing.Size(363, 29);
            this.priorityButton.TabIndex = 2;
            this.priorityButton.Text = "Priority";
            this.priorityButton.UseVisualStyleBackColor = true;
            this.priorityButton.Click += new System.EventHandler(this.Priority_Click);
            // 
            // sjf
            // 
            this.sjf.Location = new System.Drawing.Point(5, 63);
            this.sjf.Name = "sjf";
            this.sjf.Size = new System.Drawing.Size(363, 29);
            this.sjf.TabIndex = 1;
            this.sjf.Text = "SJF";
            this.sjf.UseVisualStyleBackColor = true;
            this.sjf.Click += new System.EventHandler(this.SJF_Click);
            // 
            // fcfs
            // 
            this.fcfs.Location = new System.Drawing.Point(5, 28);
            this.fcfs.Name = "fcfs";
            this.fcfs.Size = new System.Drawing.Size(363, 29);
            this.fcfs.TabIndex = 0;
            this.fcfs.Text = "FCFS";
            this.fcfs.UseVisualStyleBackColor = true;
            this.fcfs.Click += new System.EventHandler(this.FCFS_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AllowUserToResizeColumns = false;
            this.dataGridViewResults.AllowUserToResizeRows = false;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(398, 298);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(375, 251);
            this.dataGridViewResults.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tempo medio di attesa:";
            // 
            // textBoxAvg
            // 
            this.textBoxAvg.BackColor = System.Drawing.Color.White;
            this.textBoxAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAvg.Location = new System.Drawing.Point(608, 259);
            this.textBoxAvg.Name = "textBoxAvg";
            this.textBoxAvg.ReadOnly = true;
            this.textBoxAvg.Size = new System.Drawing.Size(159, 29);
            this.textBoxAvg.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBoxAvg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SchedulingAlgorithms";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox priority;
        private System.Windows.Forms.TextBox cpuBurst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addProcess;
        private System.Windows.Forms.Button roundRobin;
        private System.Windows.Forms.Button priorityButton;
        private System.Windows.Forms.Button sjf;
        private System.Windows.Forms.Button fcfs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantum;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAvg;
    }
}