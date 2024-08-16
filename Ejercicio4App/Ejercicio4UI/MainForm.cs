namespace Ejercicio4UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string consonants = "qwrtypsdfghjklñzxcvbnm";
            string upperConsonants = "QWRTYPSDFGHJKLÑZXCVBNM";

            if (consonants.Contains(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("no se permite ingresar consonantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(upperConsonants.Contains(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("no se permite ingresar consonantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
