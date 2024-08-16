using ShapesLibrary;

namespace Ejercicio3UI.Main
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void circleAreaButton_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(circleInputRadius.Text);
                if (radius <= 0)
                {
                    MessageBox.Show("ingresar numeros mayores a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Circles circle = new Circles(radius);
                    double area = circle.CalcArea();
                    MessageBox.Show($"el area del circulo es: {Math.Round(area, 2)} cm cuadrados");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("debe ingresar numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void circlePerimeterButton_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(circleInputRadius.Text);
                if (radius <= 0)
                {
                    MessageBox.Show("ingresar numeros mayores a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Circles circle = new Circles(radius);
                    double perimeter = circle.CalcPerimeter();
                    MessageBox.Show($"el perimetro del circulo es: {Math.Round(perimeter, 2)} cm");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("dege ingresar numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void decagonAreaButton_Click(object sender, EventArgs e)
        {
            try
            {
                double side = double.Parse(decagonInputSide.Text);
                if (side <= 0)
                {
                    MessageBox.Show("ingresar numeros mayores a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Decagons decagon = new Decagons(side);
                    double decagonArea = decagon.CalcArea();
                    MessageBox.Show($"el area del decagono es de: {Math.Round(decagonArea, 2)}cm cuadrados");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("dege ingresar numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void decagonPerimeterButton_Click(object sender, EventArgs e)
        {
            try
            {
                double side = double.Parse(decagonInputSide.Text);
                if (side <= 0)
                {
                    MessageBox.Show("ingresar numeros mayores a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Decagons decagon = new Decagons(side);
                    double decagonPerimeter = decagon.CalcPerimeter();
                    MessageBox.Show($"el perimetro de decagono es de: {Math.Round(decagonPerimeter, 2)}cm");
                }
            }
            catch
            {
                MessageBox.Show("dege ingresar numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
