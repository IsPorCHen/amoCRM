using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridView;

        public Form1()
        {
            InitializeComponent();
            dataGridView = new DataGridView
            {
                Location = new Point(10, 130),
                Size = new Size(400, 200),
                Visible = false
            };
            this.Controls.Add(dataGridView);
        }

        private void hidePanels()
        {
            profile.Enabled = false;
            profile.Visible = false;
            settings.Enabled = false;
            settings.Visible = false;
        }

        private void hideButtons()
        {
            foreach (var control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = false;
                    button.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideButtons();
            addTasks.Visible = true;
            addTasks.Enabled = true;
            dataGridView.Visible = true;
            LoadTasksData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideButtons();
            addContact.Visible = true;
            addContact.Enabled = true;
            dataGridView.Visible = true;
            LoadContactsData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            settings.Visible = !settings.Visible;
            settings.Enabled = !settings.Enabled;
        }

        private void LoadTasksData()
        {
            LoadDataIntoDataGridView("Tasks.txt", new string[] { "Ответственный", "Дата", "Задача" }, 3);
        }

        private void LoadContactsData()
        {
            LoadDataIntoDataGridView("Contacts.txt", new string[] { "Фамилия", "Имя", "Логин", "Пароль" }, 4);
        }

        private void LoadDataIntoDataGridView(string filePath, string[] columnNames, int expectedColumns)
        {
            if (File.Exists(filePath))
            {
                DataTable dataTable = new DataTable();
                foreach (var columnName in columnNames)
                {
                    dataTable.Columns.Add(columnName);
                }

                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i += expectedColumns)
                {
                    if (i + expectedColumns - 1 < lines.Length)
                    {
                        var rowData = new string[expectedColumns];
                        for (int j = 0; j < expectedColumns; j++)
                        {
                            rowData[j] = lines[i + j];
                        }
                        dataTable.Rows.Add(rowData);
                    }
                }
                dataGridView.DataSource = dataTable;
            }
        }


        private void lightTheme_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#F5F5F5");
            foreach (var control in this.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = ColorTranslator.FromHtml("#1B3446");
                }
            }
        }

        private void darkTheme_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#153043");
            foreach (var control in this.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = ColorTranslator.FromHtml("#07131D");
                }
            }
        }

        private void middleTheme_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#153043");
            foreach (var control in this.Controls)
            {
                if (control is Panel panel)
                {
                    panel.BackColor = ColorTranslator.FromHtml("#1B3446");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
            profile.Enabled = true;
            profile.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = ColorTranslator.FromHtml("#444D55");
            profile.Enabled = false;
            profile.Visible = false;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = ColorTranslator.FromHtml("#444D55");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = ColorTranslator.FromHtml("#444D55");
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = ColorTranslator.FromHtml("#444D55");
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = ColorTranslator.FromHtml("#444D55");
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            contacts contract = new contacts();
            contract.Show();
        }

        private void addTasks_Click(object sender, EventArgs e)
        {
            tasksForm task = new tasksForm();
            task.Show();
        }
    }
}
