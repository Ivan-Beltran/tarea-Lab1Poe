namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxCosecante.Items.Add("Cosecante de Grados");
            comboBoxCosecante.Items.Add("Cosecante de Radianes");
            comboBoxCosecante.SelectedIndex = 0; 
        }

        private void btnEnviar_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese el valor del ángulo:",
                    "Entrada de Ángulo",
                    "0");

                if (string.IsNullOrEmpty(input) || !double.TryParse(input, out double valor))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string seleccion = comboBoxCosecante.SelectedItem.ToString();
                double resultado;

                if (seleccion == "Cosecante de Grados")
                {
                    if (valor % 180 == 0)
                    {
                        MessageBox.Show("La cosecante no está definida para múltiplos de 180°.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    double radianes = valor * (Math.PI / 180);
                    resultado = 1 / Math.Sin(radianes);
                }
                else // Cosecante de Radianes
                {
                    if (valor % Math.PI == 0)
                    {
                        MessageBox.Show("La cosecante no está definida para múltiplos de PI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resultado = 1 / Math.Sin(valor);
                }

                MessageBox.Show($"Valor: {valor}\nCosecante: {resultado:F4}",
                                "Resultados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
