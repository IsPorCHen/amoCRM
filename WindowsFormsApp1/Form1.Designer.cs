namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelContracts = new System.Windows.Forms.Panel();
            this.panelTasks = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.Panel();
            this.darkTheme = new System.Windows.Forms.RadioButton();
            this.middleTheme = new System.Windows.Forms.RadioButton();
            this.lightTheme = new System.Windows.Forms.RadioButton();
            this.addContact = new System.Windows.Forms.Button();
            this.addTasks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelTasks.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.profile.SuspendLayout();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.panelSettings);
            this.panel1.Controls.Add(this.panelContracts);
            this.panel1.Controls.Add(this.panelTasks);
            this.panel1.Controls.Add(this.panelProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 419);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.7F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.button3.Location = new System.Drawing.Point(3, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Контракты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button5);
            this.panel.Location = new System.Drawing.Point(3, 316);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(82, 66);
            this.panel.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.button5.Location = new System.Drawing.Point(0, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 63);
            this.button5.TabIndex = 4;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button5_MouseMove);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.button4);
            this.panelSettings.Location = new System.Drawing.Point(3, 244);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(82, 66);
            this.panelSettings.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "Настройки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // panelContracts
            // 
            this.panelContracts.Location = new System.Drawing.Point(3, 172);
            this.panelContracts.Name = "panelContracts";
            this.panelContracts.Size = new System.Drawing.Size(82, 66);
            this.panelContracts.TabIndex = 1;
            // 
            // panelTasks
            // 
            this.panelTasks.Controls.Add(this.button2);
            this.panelTasks.Location = new System.Drawing.Point(0, 100);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Size = new System.Drawing.Size(82, 66);
            this.panelTasks.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.button2.Location = new System.Drawing.Point(3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Задачи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.button1);
            this.panelProfile.Location = new System.Drawing.Point(0, 28);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(82, 66);
            this.panelProfile.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Профиль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.profile.Controls.Add(this.label3);
            this.profile.Controls.Add(this.label2);
            this.profile.Controls.Add(this.label1);
            this.profile.Enabled = false;
            this.profile.Location = new System.Drawing.Point(71, 28);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(207, 66);
            this.profile.TabIndex = 1;
            this.profile.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(76, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "3  курс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(76, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "пр-32";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Юнусов";
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.settings.Controls.Add(this.darkTheme);
            this.settings.Controls.Add(this.middleTheme);
            this.settings.Controls.Add(this.lightTheme);
            this.settings.Enabled = false;
            this.settings.Location = new System.Drawing.Point(71, 244);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(207, 80);
            this.settings.TabIndex = 5;
            this.settings.Visible = false;
            // 
            // darkTheme
            // 
            this.darkTheme.AutoSize = true;
            this.darkTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.darkTheme.Location = new System.Drawing.Point(46, 29);
            this.darkTheme.Name = "darkTheme";
            this.darkTheme.Size = new System.Drawing.Size(112, 20);
            this.darkTheme.TabIndex = 6;
            this.darkTheme.TabStop = true;
            this.darkTheme.Text = "Темная тема";
            this.darkTheme.UseVisualStyleBackColor = true;
            this.darkTheme.CheckedChanged += new System.EventHandler(this.darkTheme_CheckedChanged);
            // 
            // middleTheme
            // 
            this.middleTheme.AutoSize = true;
            this.middleTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.middleTheme.Location = new System.Drawing.Point(46, 55);
            this.middleTheme.Name = "middleTheme";
            this.middleTheme.Size = new System.Drawing.Size(118, 20);
            this.middleTheme.TabIndex = 1;
            this.middleTheme.TabStop = true;
            this.middleTheme.Text = "Средняя тема";
            this.middleTheme.UseVisualStyleBackColor = true;
            this.middleTheme.CheckedChanged += new System.EventHandler(this.middleTheme_CheckedChanged);
            // 
            // lightTheme
            // 
            this.lightTheme.AutoSize = true;
            this.lightTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lightTheme.Location = new System.Drawing.Point(46, 3);
            this.lightTheme.Name = "lightTheme";
            this.lightTheme.Size = new System.Drawing.Size(118, 20);
            this.lightTheme.TabIndex = 0;
            this.lightTheme.TabStop = true;
            this.lightTheme.Text = "Светлая тема";
            this.lightTheme.UseVisualStyleBackColor = true;
            this.lightTheme.CheckedChanged += new System.EventHandler(this.lightTheme_CheckedChanged);
            // 
            // addContact
            // 
            this.addContact.AutoSize = true;
            this.addContact.BackColor = System.Drawing.Color.Orange;
            this.addContact.Enabled = false;
            this.addContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addContact.Location = new System.Drawing.Point(651, 12);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(137, 28);
            this.addContact.TabIndex = 6;
            this.addContact.Text = "Добавить контакт";
            this.addContact.UseVisualStyleBackColor = false;
            this.addContact.Visible = false;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // addTasks
            // 
            this.addTasks.AutoSize = true;
            this.addTasks.BackColor = System.Drawing.Color.Orange;
            this.addTasks.Enabled = false;
            this.addTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTasks.Location = new System.Drawing.Point(651, 12);
            this.addTasks.Name = "addTasks";
            this.addTasks.Size = new System.Drawing.Size(143, 28);
            this.addTasks.TabIndex = 8;
            this.addTasks.Text = "Добавить задачу +";
            this.addTasks.UseVisualStyleBackColor = false;
            this.addTasks.Visible = false;
            this.addTasks.Click += new System.EventHandler(this.addTasks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(844, 419);
            this.Controls.Add(this.addTasks);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelTasks.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelContracts;
        private System.Windows.Forms.Panel panelTasks;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Panel profile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.RadioButton darkTheme;
        private System.Windows.Forms.RadioButton middleTheme;
        private System.Windows.Forms.RadioButton lightTheme;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addContact;
        private System.Windows.Forms.Button addTasks;
    }
}

