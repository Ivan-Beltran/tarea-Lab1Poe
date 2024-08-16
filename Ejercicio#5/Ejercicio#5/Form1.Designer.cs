namespace Ejercicio_5
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
            numero1textBox = new TextBox();
            numero1label = new Label();
            numero2label = new Label();
            numero2textBox = new TextBox();
            numero3label = new Label();
            numero3textBox = new TextBox();
            buttoncalcular = new Button();
            resultadoLabel = new Label();
            SuspendLayout();
            // 
            // numero1textBox
            // 
            numero1textBox.Location = new Point(332, 96);
            numero1textBox.Name = "numero1textBox";
            numero1textBox.Size = new Size(100, 23);
            numero1textBox.TabIndex = 0;
            // 
            // numero1label
            // 
            numero1label.AutoSize = true;
            numero1label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numero1label.Location = new Point(192, 96);
            numero1label.Name = "numero1label";
            numero1label.Size = new Size(107, 25);
            numero1label.TabIndex = 1;
            numero1label.Text = "Numero 1:";
            // 
            // numero2label
            // 
            numero2label.AutoSize = true;
            numero2label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numero2label.Location = new Point(192, 157);
            numero2label.Name = "numero2label";
            numero2label.Size = new Size(107, 25);
            numero2label.TabIndex = 3;
            numero2label.Text = "Numero 2:";
            // 
            // numero2textBox
            // 
            numero2textBox.Location = new Point(332, 162);
            numero2textBox.Name = "numero2textBox";
            numero2textBox.Size = new Size(100, 23);
            numero2textBox.TabIndex = 2;
            // 
            // numero3label
            // 
            numero3label.AutoSize = true;
            numero3label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numero3label.Location = new Point(192, 235);
            numero3label.Name = "numero3label";
            numero3label.Size = new Size(107, 25);
            numero3label.TabIndex = 5;
            numero3label.Text = "Numero 3:";
            // 
            // numero3textBox
            // 
            numero3textBox.Location = new Point(332, 235);
            numero3textBox.Name = "numero3textBox";
            numero3textBox.Size = new Size(100, 23);
            numero3textBox.TabIndex = 4;
            // 
            // buttoncalcular
            // 
            buttoncalcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttoncalcular.Location = new Point(192, 328);
            buttoncalcular.Name = "buttoncalcular";
            buttoncalcular.Size = new Size(155, 36);
            buttoncalcular.TabIndex = 6;
            buttoncalcular.Text = "Calcular MCD";
            buttoncalcular.UseVisualStyleBackColor = true;
            buttoncalcular.Click += Buttoncalcular_Click;
            // 
            // resultadoLabel
            // 
            resultadoLabel.AutoSize = true;
            resultadoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultadoLabel.ForeColor = Color.FromArgb(0, 0, 192);
            resultadoLabel.Location = new Point(236, 389);
            resultadoLabel.Name = "resultadoLabel";
            resultadoLabel.Size = new Size(0, 25);
            resultadoLabel.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultadoLabel);
            Controls.Add(buttoncalcular);
            Controls.Add(numero3label);
            Controls.Add(numero3textBox);
            Controls.Add(numero2label);
            Controls.Add(numero2textBox);
            Controls.Add(numero1label);
            Controls.Add(numero1textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numero1textBox;
        private Label numero1label;
        private Label numero2label;
        private TextBox numero2textBox;
        private Label numero3label;
        private TextBox numero3textBox;
        private Button buttoncalcular;
        private Label resultadoLabel;
    }
}
