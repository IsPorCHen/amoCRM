namespace WindowsFormsApp1
{
    partial class tasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.addTasksPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.task = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.addTasksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTasksPanel
            // 
            this.addTasksPanel.BackColor = System.Drawing.Color.Orange;
            this.addTasksPanel.Controls.Add(this.comboBox1);
            this.addTasksPanel.Controls.Add(this.dateTimePicker1);
            this.addTasksPanel.Controls.Add(this.button7);
            this.addTasksPanel.Controls.Add(this.task);
            this.addTasksPanel.Controls.Add(this.label17);
            this.addTasksPanel.Controls.Add(this.date);
            this.addTasksPanel.Controls.Add(this.label19);
            this.addTasksPanel.Location = new System.Drawing.Point(224, 142);
            this.addTasksPanel.Name = "addTasksPanel";
            this.addTasksPanel.Size = new System.Drawing.Size(353, 167);
            this.addTasksPanel.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(135, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 28);
            this.button7.TabIndex = 10;
            this.button7.Text = "Создать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // task
            // 
            this.task.Location = new System.Drawing.Point(120, 100);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(100, 22);
            this.task.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(58, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Задача";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.date.Location = new System.Drawing.Point(71, 75);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(39, 16);
            this.date.TabIndex = 1;
            this.date.Text = "Срок";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(38, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "Ответственный";
            // 
            // tasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addTasksPanel);
            this.Name = "tasksForm";
            this.Text = "tasksForm";
            this.addTasksPanel.ResumeLayout(false);
            this.addTasksPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addTasksPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox task;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}