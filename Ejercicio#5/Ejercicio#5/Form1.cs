using System;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private int gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

       
        private void Buttoncalcular_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(numero1textBox.Text);
            int num2 = int.Parse(numero2textBox.Text);
            int num3 = int.Parse(numero3textBox.Text);

            int result = gcd(gcd(num1, num2), num3);

            resultadoLabel.Text= $"El MCD de {num1}, {num2} y {num3} es: {result}";
            
        }
    }
}
