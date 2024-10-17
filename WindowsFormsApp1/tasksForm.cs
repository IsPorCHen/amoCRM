using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class tasksForm : Form
    {
        public tasksForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (task.Text == "")
            {
                MessageBox.Show("Обнаружены пустые поля", "Ошибка ввода");
            }
            else
            {
                using (StreamWriter sr = new StreamWriter("Tasks.txt", true))
                {
                    sr.WriteLine($"{comboBox1.SelectedItem.ToString()}");
                    sr.WriteLine($"{dateTimePicker1.Value.ToString()}");
                    sr.WriteLine($"{task.Text}");
                }

                MessageBox.Show("Успешно сохранено", "Сохранение файла");
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            using (StreamReader rd = new StreamReader("Contacts.txt"))
            {
                int lineCounter = 0;
                string line;

                while ((line = rd.ReadLine()) != null)
                {
                    lineCounter++;

                    if (lineCounter % 5 == 1)
                    {
                        comboBox1.Items.Add(line);
                    }
                }
            }
        }
    }
}
