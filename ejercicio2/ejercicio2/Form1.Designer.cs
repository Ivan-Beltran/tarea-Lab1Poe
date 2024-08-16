namespace ejercicio2
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
            btnEnviar = new Button();
            comboBoxCosecante = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(333, 233);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.MouseClick += btnEnviar_MouseClick;
            // 
            // comboBoxCosecante
            // 
            comboBoxCosecante.FormattingEnabled = true;
            comboBoxCosecante.Location = new Point(302, 123);
            comboBoxCosecante.Name = "comboBoxCosecante";
            comboBoxCosecante.Size = new Size(180, 23);
            comboBoxCosecante.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 126);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Cosecante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(comboBoxCosecante);
            Controls.Add(btnEnviar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEnviar;
        private ComboBox comboBoxCosecante;
        private Label label1;
    }
}
