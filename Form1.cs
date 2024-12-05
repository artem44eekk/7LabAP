using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7LabAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x1 = double.Parse(tbX1.Text);
                double x2 = double.Parse(tbX2.Text);

                // Обчислення значення функції
                double y = Math.Cos(Math.Sqrt(x2 + 34 * x1)) - 4 * Math.Sin(x2);
                tbY.Text = y.ToString("F3"); // Формат з 3 знаками після коми

                // Додатковий вивід
                double max = Math.Max(x1, x2);
                MessageBox.Show($"Більше із значень: {max:F3}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення!", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = "";
            tbX2.Text = "";
            tbY.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
