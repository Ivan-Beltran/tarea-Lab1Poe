namespace Ejercicio7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOperacion = new Label();
            divisionbutton = new Button();
            multipliacionbutton = new Button();
            restabutton = new Button();
            sumabutton = new Button();
            btnLimpiar = new Button();
            btnIgual = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            ResultadoTextBox = new TextBox();
            SuspendLayout();
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Location = new Point(470, 84);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(0, 15);
            lblOperacion.TabIndex = 37;
            // 
            // divisionbutton
            // 
            divisionbutton.Location = new Point(585, 183);
            divisionbutton.Name = "divisionbutton";
            divisionbutton.Size = new Size(75, 23);
            divisionbutton.TabIndex = 36;
            divisionbutton.Text = "/";
            divisionbutton.UseVisualStyleBackColor = true;
            divisionbutton.Click += Operador_Click;
            // 
            // multipliacionbutton
            // 
            multipliacionbutton.Location = new Point(487, 183);
            multipliacionbutton.Name = "multipliacionbutton";
            multipliacionbutton.Size = new Size(75, 23);
            multipliacionbutton.TabIndex = 35;
            multipliacionbutton.Text = "*";
            multipliacionbutton.UseVisualStyleBackColor = true;
            multipliacionbutton.Click += Operador_Click;
            // 
            // restabutton
            // 
            restabutton.Location = new Point(585, 139);
            restabutton.Name = "restabutton";
            restabutton.Size = new Size(75, 23);
            restabutton.TabIndex = 34;
            restabutton.Text = "-";
            restabutton.UseVisualStyleBackColor = true;
            restabutton.Click += Operador_Click;
            // 
            // sumabutton
            // 
            sumabutton.Location = new Point(487, 139);
            sumabutton.Name = "sumabutton";
            sumabutton.Size = new Size(75, 23);
            sumabutton.TabIndex = 33;
            sumabutton.Text = "+";
            sumabutton.UseVisualStyleBackColor = true;
            sumabutton.Click += Operador_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(349, 267);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(245, 267);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 23);
            btnIgual.TabIndex = 31;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // button10
            // 
            button10.Location = new Point(149, 267);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 30;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Boton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(349, 227);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 29;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Boton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(245, 227);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 28;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Boton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(149, 227);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 27;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Boton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(349, 183);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 26;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Boton_Click;
            // 
            // button5
            // 
            button5.Location = new Point(245, 183);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 25;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Boton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(149, 183);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 24;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Boton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(349, 137);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 23;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Boton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(245, 137);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 22;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Boton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(149, 137);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Boton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 28);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 20;
            label1.Text = "Calculadora";
            // 
            // ResultadoTextBox
            // 
            ResultadoTextBox.Location = new Point(149, 81);
            ResultadoTextBox.Name = "ResultadoTextBox";
            ResultadoTextBox.Size = new Size(296, 23);
            ResultadoTextBox.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOperacion);
            Controls.Add(divisionbutton);
            Controls.Add(multipliacionbutton);
            Controls.Add(restabutton);
            Controls.Add(sumabutton);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIgual);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ResultadoTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperacion;
        private Button divisionbutton;
        private Button multipliacionbutton;
        private Button restabutton;
        private Button sumabutton;
        private Button btnLimpiar;
        private Button btnIgual;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox ResultadoTextBox;
    }
}
