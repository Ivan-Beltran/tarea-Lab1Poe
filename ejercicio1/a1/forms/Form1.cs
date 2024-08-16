using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a1.forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            NumberOneTextBox.KeyPress += new KeyPressEventHandler(NumberTextBox_KeyPress);
            NumberTwoTextBox.KeyPress += new KeyPressEventHandler(NumberTextBox_KeyPress);
            NumberThreeTextBox.KeyPress += new KeyPressEventHandler(NumberTextBox_KeyPress);
        }

        private void resultButton_MouseClick(object sender, MouseEventArgs e)
        {
            int num1, num2, num3;

            if (string.IsNullOrWhiteSpace(NumberOneTextBox.Text) ||
                string.IsNullOrWhiteSpace(NumberTwoTextBox.Text) ||
                string.IsNullOrWhiteSpace(NumberThreeTextBox.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(NumberOneTextBox.Text, out num1) ||
                !int.TryParse(NumberTwoTextBox.Text, out num2) ||
                !int.TryParse(NumberThreeTextBox.Text, out num3))
            {
                MessageBox.Show("Todos los valores deben ser números enteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int mayor = num1;

            if (num2 > mayor)
            {
                mayor = num2;
            }

            if (num3 > mayor)
            {
                mayor = num3;
            }

            ResultLabel.Text = "El número mayor es: " + mayor;
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
