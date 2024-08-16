namespace a1.forms
{
    partial class Form1
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
            tituloLabel = new Label();
            NumberOneTextBox = new TextBox();
            firstNumberLabel = new Label();
            secondNumberLabel = new Label();
            NumberTwoTextBox = new TextBox();
            thirtNumberLabel = new Label();
            NumberThreeTextBox = new TextBox();
            resultButton = new Button();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new Point(311, 26);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(98, 25);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Ejercicio 1";
            // 
            // NumberOneTextBox
            // 
            NumberOneTextBox.Location = new Point(107, 141);
            NumberOneTextBox.Name = "NumberOneTextBox";
            NumberOneTextBox.Size = new Size(79, 33);
            NumberOneTextBox.TabIndex = 1;
            // 
            // firstNumberLabel
            // 
            firstNumberLabel.AutoSize = true;
            firstNumberLabel.Location = new Point(107, 98);
            firstNumberLabel.Name = "firstNumberLabel";
            firstNumberLabel.RightToLeft = RightToLeft.No;
            firstNumberLabel.Size = new Size(96, 25);
            firstNumberLabel.TabIndex = 2;
            firstNumberLabel.Text = "Numero 1";
            // 
            // secondNumberLabel
            // 
            secondNumberLabel.AutoSize = true;
            secondNumberLabel.Location = new Point(311, 98);
            secondNumberLabel.Name = "secondNumberLabel";
            secondNumberLabel.RightToLeft = RightToLeft.No;
            secondNumberLabel.Size = new Size(96, 25);
            secondNumberLabel.TabIndex = 4;
            secondNumberLabel.Text = "Numero 2";
            // 
            // NumberTwoTextBox
            // 
            NumberTwoTextBox.Location = new Point(311, 141);
            NumberTwoTextBox.Name = "NumberTwoTextBox";
            NumberTwoTextBox.Size = new Size(79, 33);
            NumberTwoTextBox.TabIndex = 3;
            // 
            // thirtNumberLabel
            // 
            thirtNumberLabel.AutoSize = true;
            thirtNumberLabel.Location = new Point(536, 98);
            thirtNumberLabel.Name = "thirtNumberLabel";
            thirtNumberLabel.RightToLeft = RightToLeft.No;
            thirtNumberLabel.Size = new Size(96, 25);
            thirtNumberLabel.TabIndex = 6;
            thirtNumberLabel.Text = "Numero 3";
            // 
            // NumberThreeTextBox
            // 
            NumberThreeTextBox.Location = new Point(536, 142);
            NumberThreeTextBox.Name = "NumberThreeTextBox";
            NumberThreeTextBox.Size = new Size(79, 33);
            NumberThreeTextBox.TabIndex = 5;
            // 
            // resultButton
            // 
            resultButton.Location = new Point(307, 253);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(100, 42);
            resultButton.TabIndex = 7;
            resultButton.Text = "Analizar";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.MouseClick += resultButton_MouseClick;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(289, 383);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 25);
            ResultLabel.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 532);
            Controls.Add(ResultLabel);
            Controls.Add(resultButton);
            Controls.Add(thirtNumberLabel);
            Controls.Add(NumberThreeTextBox);
            Controls.Add(secondNumberLabel);
            Controls.Add(NumberTwoTextBox);
            Controls.Add(firstNumberLabel);
            Controls.Add(NumberOneTextBox);
            Controls.Add(tituloLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private TextBox NumberOneTextBox;
        private Label firstNumberLabel;
        private Label secondNumberLabel;
        private TextBox NumberTwoTextBox;
        private Label thirtNumberLabel;
        private TextBox NumberThreeTextBox;
        private Button resultButton;
        private Label ResultLabel;
    }
}