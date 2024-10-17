using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class contacts :Form
    {
        public contacts ()
        {
            InitializeComponent();
        }

        private void contacts_Load (object sender, EventArgs e)
        {

        }

        private void button6_Click (object sender, EventArgs e)
        {
            if (surname.Text == ""
                || name.Text == ""
                || login.Text == ""
                || password.Text == ""
                || email.Text == "")
            {
                MessageBox.Show("Обнаружены пустые поля", "Ошибка ввода");
            } else
            {
                using (StreamWriter sr = new StreamWriter("Contacts.txt", true))
                {
                    sr.WriteLine($"{surname.Text}");
                    sr.WriteLine($"{name.Text}");
                    sr.WriteLine($"{login.Text}");
                    sr.WriteLine($"{password.Text}");
                    sr.WriteLine($"{email.Text}");
                }
                MessageBox.Show("Успешно сохранено", "Сохранение файла");
            }
        }
    }
}
