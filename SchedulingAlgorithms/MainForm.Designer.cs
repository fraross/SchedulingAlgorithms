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
            this.addProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.ComboBox();
            this.arrivalTime = new System.Windows.Forms.TextBox();
            this.cpuBurst = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roundRobin = new System.Windows.Forms.Button();
            this.priorityButton = new System.Windows.Forms.Button();
            this.sjf = new System.Windows.Forms.Button();
            this.fcfs = new System.Windows.Forms.Button();
            this.quantum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProcess
            // 
            this.dataGridViewProcess.AllowUserToAddRows = false;
            this.dataGridViewProcess.AllowUserToDeleteRows = false;
            this.dataGridViewProcess.AllowUserToResizeColumns = false;
            this.dataGridViewProcess.AllowUserToResizeRows = false;
            this.dataGridViewProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcess.Location = new System.Drawing.Point(12, 249);
            this.dataGridViewProcess.Name = "dataGridViewProcess";
            this.dataGridViewProcess.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewProcess.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addProcess);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.priority);
            this.groupBox1.Controls.Add(this.arrivalTime);
            this.groupBox1.Controls.Add(this.cpuBurst);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processi";
            // 
            // addProcess
            // 
            this.addProcess.Location = new System.Drawing.Point(10, 196);
            this.addProcess.Name = "addProcess";
            this.addProcess.Size = new System.Drawing.Size(355, 29);
            this.addProcess.TabIndex = 13;
            this.addProcess.Text = "Aggiungi";
            this.addProcess.UseVisualStyleBackColor = true;
            this.addProcess.Click += new System.EventHandler(this.addProcess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Priorità";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tempo di Arrivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPU Burst";
            // 
            // priority
            // 
            this.priority.FormattingEnabled = true;
            this.priority.Location = new System.Drawing.Point(71, 107);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(294, 28);
            this.priority.TabIndex = 8;
            // 
            // arrivalTime
            // 
            this.arrivalTime.Location = new System.Drawing.Point(130, 75);
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.Size = new System.Drawing.Size(235, 26);
            this.arrivalTime.TabIndex = 7;
            this.arrivalTime.TextChanged += new System.EventHandler(this.SanitizeInput);
            // 
            // cpuBurst
            // 
            this.cpuBurst.Location = new System.Drawing.Point(96, 43);
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
            this.groupBox2.Location = new System.Drawing.Point(388, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 231);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algoritmi";
            // 
            // roundRobin
            // 
            this.roundRobin.Location = new System.Drawing.Point(5, 196);
            this.roundRobin.Name = "roundRobin";
            this.roundRobin.Size = new System.Drawing.Size(363, 29);
            this.roundRobin.TabIndex = 3;
            this.roundRobin.Text = "Round Robin";
            this.roundRobin.UseVisualStyleBackColor = true;
            this.roundRobin.Click += new System.EventHandler(this.roundRobin_Click);
            // 
            // priorityButton
            // 
            this.priorityButton.Location = new System.Drawing.Point(6, 98);
            this.priorityButton.Name = "priorityButton";
            this.priorityButton.Size = new System.Drawing.Size(363, 29);
            this.priorityButton.TabIndex = 2;
            this.priorityButton.Text = "Priority";
            this.priorityButton.UseVisualStyleBackColor = true;
            this.priorityButton.Click += new System.EventHandler(this.priorityButton_Click);
            // 
            // sjf
            // 
            this.sjf.Location = new System.Drawing.Point(5, 63);
            this.sjf.Name = "sjf";
            this.sjf.Size = new System.Drawing.Size(363, 29);
            this.sjf.TabIndex = 1;
            this.sjf.Text = "SJF";
            this.sjf.UseVisualStyleBackColor = true;
            this.sjf.Click += new System.EventHandler(this.sjf_Click);
            // 
            // fcfs
            // 
            this.fcfs.Location = new System.Drawing.Point(5, 28);
            this.fcfs.Name = "fcfs";
            this.fcfs.Size = new System.Drawing.Size(363, 29);
            this.fcfs.TabIndex = 0;
            this.fcfs.Text = "FCFS";
            this.fcfs.UseVisualStyleBackColor = true;
            this.fcfs.Click += new System.EventHandler(this.fcfs_Click);
            // 
            // quantum
            // 
            this.quantum.Location = new System.Drawing.Point(100, 161);
            this.quantum.Name = "quantum";
            this.quantum.Size = new System.Drawing.Size(268, 29);
            this.quantum.TabIndex = 4;
            this.quantum.TextChanged += new System.EventHandler(this.SanitizeInput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantum";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox priority;
        private System.Windows.Forms.TextBox arrivalTime;
        private System.Windows.Forms.TextBox cpuBurst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addProcess;
        private System.Windows.Forms.Button roundRobin;
        private System.Windows.Forms.Button priorityButton;
        private System.Windows.Forms.Button sjf;
        private System.Windows.Forms.Button fcfs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantum;
    }
}