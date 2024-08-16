namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        private double? resultado = null;
        private string operador = null;
        private bool esOperacionRealizada = false;

        public Form1()
        {
            InitializeComponent();
            ResultadoTextBox.KeyPress += TxtResultado_KeyPress;
        }

        private void TxtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && ResultadoTextBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (esOperacionRealizada || ResultadoTextBox.Text == "0")
            {
                ResultadoTextBox.Clear();
                esOperacionRealizada = false;
            }

            if (boton.Text == "." && ResultadoTextBox.Text.Contains("."))
                return;

            ResultadoTextBox.Text += boton.Text;
        }

        private void Operador_Click(object sender, EventArgs e)
        {
            if (resultado.HasValue && !esOperacionRealizada)
            {
                btnIgual.PerformClick();
            }

            operador = ((Button)sender).Text;
            if (!double.TryParse(ResultadoTextBox.Text, out double parsedResult))
            {
                MessageBox.Show("Número inválido o formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            resultado = parsedResult;
            lblOperacion.Text = $"{resultado} {operador}";
            esOperacionRealizada = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCalculadora();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!resultado.HasValue || operador == null)
            {
                MessageBox.Show("Por favor ingresa una operación para calcular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCalculadora();
                return;
            }

            if (!double.TryParse(ResultadoTextBox.Text, out double segundoNumero))
            {
                MessageBox.Show("Número inválido o formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCalculadora();
                return;
            }

            double resultadoFinal = 0;

            try
            {
                switch (operador)
                {
                    case "+":
                        resultadoFinal = resultado.Value + segundoNumero;
                        break;
                    case "-":
                        resultadoFinal = resultado.Value - segundoNumero;
                        break;
                    case "*":
                        resultadoFinal = resultado.Value * segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero == 0)
                        {
                            MessageBox.Show("No se puede dividir entre 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        resultadoFinal = resultado.Value / segundoNumero;
                        break;
                    default:
                        MessageBox.Show("Operador desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                ResultadoTextBox.Text = resultadoFinal.ToString();
                resultado = resultadoFinal;
                operador = null;
                lblOperacion.Text = "";
                esOperacionRealizada = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Un error ha ocurrido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCalculadora();
            }
        }

        private void LimpiarCalculadora()
        {
            ResultadoTextBox.Text = "";
            resultado = null;
            operador = null;
            lblOperacion.Text = "";
            esOperacionRealizada = false;
        }
    }
}
