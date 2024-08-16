namespace Ejercicio4UI
{
    partial class MainForm
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
            InputTextBox = new TextBox();
            titleLabel = new Label();
            descriptionLabel = new Label();
            writeLabel = new Label();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(150, 148);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(377, 81);
            InputTextBox.TabIndex = 0;
            InputTextBox.KeyPress += InputTextBox_KeyPress;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F);
            titleLabel.Location = new Point(41, 27);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(359, 37);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "identificador de consonantes";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(52, 84);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(304, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "este programa solo permite ingresar vocales";
            // 
            // writeLabel
            // 
            writeLabel.AutoSize = true;
            writeLabel.Location = new Point(52, 173);
            writeLabel.Name = "writeLabel";
            writeLabel.Size = new Size(86, 20);
            writeLabel.TabIndex = 3;
            writeLabel.Text = "esribir aqui:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(writeLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Label titleLabel;
        private Label descriptionLabel;
        private Label writeLabel;
    }
}
