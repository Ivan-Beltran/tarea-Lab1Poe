using ConversionLibrary;

namespace Ejercicio6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calcularBtn_Click(object sender, EventArgs e)
        {
            if (mtsOpcion.Checked)
            {
                double value = double.Parse(inputTextBox.Text);
                ConversionClase conversion1 = new ConversionClase(value);
                double total = conversion1.MtsToKm();
                MessageBox.Show($"{total} km");

            }
            else if (kmOpcion.Checked)
            {
                double value = double.Parse(inputTextBox.Text);
                ConversionClase conversion1 = new ConversionClase(value);
                double total = conversion1.KmToMts();
                MessageBox.Show($"{total} km");
            }
        }
      

    }
}





