namespace Ejercicio8
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
            Limpiarbutton = new Button();
            ResultadotextBox = new TextBox();
            enviarbutton = new Button();
            Tittlelabel = new Label();
            SuspendLayout();
            // 
            // Limpiarbutton
            // 
            Limpiarbutton.Location = new Point(365, 149);
            Limpiarbutton.Name = "Limpiarbutton";
            Limpiarbutton.Size = new Size(75, 23);
            Limpiarbutton.TabIndex = 5;
            Limpiarbutton.Text = "limpiar";
            Limpiarbutton.UseVisualStyleBackColor = true;
            Limpiarbutton.Click += Limpiarbutton_Click;
            // 
            // ResultadotextBox
            // 
            ResultadotextBox.Location = new Point(144, 89);
            ResultadotextBox.Name = "ResultadotextBox";
            ResultadotextBox.Size = new Size(357, 23);
            ResultadotextBox.TabIndex = 4;
            // 
            // enviarbutton
            // 
            enviarbutton.Location = new Point(168, 149);
            enviarbutton.Name = "enviarbutton";
            enviarbutton.Size = new Size(75, 23);
            enviarbutton.TabIndex = 3;
            enviarbutton.Text = "Enviar";
            enviarbutton.UseVisualStyleBackColor = true;
            enviarbutton.Click += enviarbutton_Click;
            // 
            // Tittlelabel
            // 
            Tittlelabel.AutoSize = true;
            Tittlelabel.Location = new Point(312, 26);
            Tittlelabel.Name = "Tittlelabel";
            Tittlelabel.Size = new Size(57, 15);
            Tittlelabel.TabIndex = 6;
            Tittlelabel.Text = "Ejercicio8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Tittlelabel);
            Controls.Add(Limpiarbutton);
            Controls.Add(ResultadotextBox);
            Controls.Add(enviarbutton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Limpiarbutton;
        private TextBox ResultadotextBox;
        private Button enviarbutton;
        private Label Tittlelabel;
    }
}
