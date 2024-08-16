namespace Ejercicio6
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            inputTextBox = new TextBox();
            kmOpcion = new RadioButton();
            mtsOpcion = new RadioButton();
            calcularBtn = new Button();
            
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 58);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 0;
            label1.Text = "Conversor";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(307, 115);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(173, 23);
            inputTextBox.TabIndex = 1;
            // 
            // kmOpcion
            // 
            kmOpcion.AutoSize = true;
            kmOpcion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kmOpcion.Location = new Point(335, 168);
            kmOpcion.Name = "kmOpcion";
            kmOpcion.Size = new Size(112, 29);
            kmOpcion.TabIndex = 2;
            kmOpcion.TabStop = true;
            kmOpcion.Text = "Km a Mts";
            kmOpcion.UseVisualStyleBackColor = true;
            // 
            // mtsOpcion
            // 
            mtsOpcion.AutoSize = true;
            mtsOpcion.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtsOpcion.Location = new Point(335, 218);
            mtsOpcion.Name = "mtsOpcion";
            mtsOpcion.Size = new Size(112, 29);
            mtsOpcion.TabIndex = 3;
            mtsOpcion.TabStop = true;
            mtsOpcion.Text = "Mts a Km";
            mtsOpcion.UseVisualStyleBackColor = true;
            // 
            // calcularBtn
            // 
            calcularBtn.BackColor = SystemColors.GradientActiveCaption;
            calcularBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calcularBtn.Location = new Point(353, 277);
            calcularBtn.Name = "calcularBtn";
            calcularBtn.Size = new Size(92, 45);
            calcularBtn.TabIndex = 4;
            calcularBtn.Text = "Calcular";
            calcularBtn.UseVisualStyleBackColor = false;
            calcularBtn.Click += calcularBtn_Click;
            // 
          
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
          
            Controls.Add(calcularBtn);
            Controls.Add(mtsOpcion);
            Controls.Add(kmOpcion);
            Controls.Add(inputTextBox);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private RadioButton kmOpcion;
        private RadioButton mtsOpcion;
        private Button calcularBtn;
       
    }
}