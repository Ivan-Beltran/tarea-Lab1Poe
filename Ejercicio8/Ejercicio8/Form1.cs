namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void enviarbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ResultadotextBox.Text, out int numero))
            {
                bool divisiblePor3 = numero % 3 == 0;
                bool divisiblePor11 = numero % 11 == 0;

                if (divisiblePor3 && divisiblePor11)
                {
                    MessageBox.Show($"El número {numero} es divisible entre 3 y 11.");
                }
                else if (divisiblePor3)
                {
                    MessageBox.Show($"El número {numero} es divisible entre 3, pero no entre 11.");
                }
                else if (divisiblePor11)
                {
                    MessageBox.Show($"El número {numero} es divisible entre 11, pero no entre 3.");
                }
                else
                {
                    MessageBox.Show($"El número {numero} no es divisible ni entre 3 ni entre 11.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            ResultadotextBox.Text = string.Empty;

            ResultadotextBox.Focus();
        }

        private void ResultadotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
