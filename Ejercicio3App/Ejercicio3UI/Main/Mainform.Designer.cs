namespace Ejercicio3UI.Main
{
    partial class Mainform
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
            CirclegroupBox = new GroupBox();
            circleResultlabel = new Label();
            CircletextBox = new TextBox();
            circleInputRadius = new TextBox();
            circlePerimeterButton = new Button();
            circleAreaButton = new Button();
            circleRadiusLabel = new Label();
            decagonGroupBox = new GroupBox();
            decagonResultLabel = new Label();
            decagonTextBox = new TextBox();
            decagonInputSide = new TextBox();
            decagonPerimeterButton = new Button();
            decagonAreaButton = new Button();
            DecagonSideLabel = new Label();
            CirclegroupBox.SuspendLayout();
            decagonGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CirclegroupBox
            // 
            CirclegroupBox.BackColor = SystemColors.ActiveCaption;
            CirclegroupBox.Controls.Add(circleResultlabel);
            CirclegroupBox.Controls.Add(CircletextBox);
            CirclegroupBox.Controls.Add(circleInputRadius);
            CirclegroupBox.Controls.Add(circlePerimeterButton);
            CirclegroupBox.Controls.Add(circleAreaButton);
            CirclegroupBox.Controls.Add(circleRadiusLabel);
            CirclegroupBox.Location = new Point(36, 35);
            CirclegroupBox.Name = "CirclegroupBox";
            CirclegroupBox.Size = new Size(371, 448);
            CirclegroupBox.TabIndex = 1;
            CirclegroupBox.TabStop = false;
            CirclegroupBox.Text = "circulo";
            // 
            // circleResultlabel
            // 
            circleResultlabel.AutoSize = true;
            circleResultlabel.BackColor = SystemColors.ButtonHighlight;
            circleResultlabel.Location = new Point(133, 358);
            circleResultlabel.Name = "circleResultlabel";
            circleResultlabel.Size = new Size(0, 20);
            circleResultlabel.TabIndex = 8;
            // 
            // CircletextBox
            // 
            CircletextBox.Location = new Point(6, 53);
            CircletextBox.Multiline = true;
            CircletextBox.Name = "CircletextBox";
            CircletextBox.Size = new Size(276, 68);
            CircletextBox.TabIndex = 7;
            CircletextBox.Text = "para calcular el area y perimetro de un circulo  se nesecita saber su radio";
            // 
            // circleInputRadius
            // 
            circleInputRadius.BorderStyle = BorderStyle.FixedSingle;
            circleInputRadius.Location = new Point(15, 214);
            circleInputRadius.Name = "circleInputRadius";
            circleInputRadius.Size = new Size(125, 27);
            circleInputRadius.TabIndex = 6;
            // 
            // circlePerimeterButton
            // 
            circlePerimeterButton.Location = new Point(158, 284);
            circlePerimeterButton.Name = "circlePerimeterButton";
            circlePerimeterButton.Size = new Size(153, 29);
            circlePerimeterButton.TabIndex = 5;
            circlePerimeterButton.Text = "calcular perimetro";
            circlePerimeterButton.UseVisualStyleBackColor = true;
            circlePerimeterButton.Click += circlePerimeterButton_Click;
            // 
            // circleAreaButton
            // 
            circleAreaButton.Location = new Point(15, 284);
            circleAreaButton.Name = "circleAreaButton";
            circleAreaButton.Size = new Size(112, 29);
            circleAreaButton.TabIndex = 4;
            circleAreaButton.Text = "calcular area";
            circleAreaButton.UseVisualStyleBackColor = true;
            circleAreaButton.Click += circleAreaButton_Click;
            // 
            // circleRadiusLabel
            // 
            circleRadiusLabel.AutoSize = true;
            circleRadiusLabel.BackColor = SystemColors.ButtonFace;
            circleRadiusLabel.BorderStyle = BorderStyle.FixedSingle;
            circleRadiusLabel.Location = new Point(15, 149);
            circleRadiusLabel.Name = "circleRadiusLabel";
            circleRadiusLabel.Size = new Size(158, 22);
            circleRadiusLabel.TabIndex = 0;
            circleRadiusLabel.Text = "ingrese el radio en cm";
            // 
            // decagonGroupBox
            // 
            decagonGroupBox.BackColor = SystemColors.ActiveCaption;
            decagonGroupBox.Controls.Add(decagonResultLabel);
            decagonGroupBox.Controls.Add(decagonTextBox);
            decagonGroupBox.Controls.Add(decagonInputSide);
            decagonGroupBox.Controls.Add(decagonPerimeterButton);
            decagonGroupBox.Controls.Add(decagonAreaButton);
            decagonGroupBox.Controls.Add(DecagonSideLabel);
            decagonGroupBox.Location = new Point(656, 35);
            decagonGroupBox.Name = "decagonGroupBox";
            decagonGroupBox.Size = new Size(371, 448);
            decagonGroupBox.TabIndex = 9;
            decagonGroupBox.TabStop = false;
            decagonGroupBox.Text = "decagono";
            // 
            // decagonResultLabel
            // 
            decagonResultLabel.AutoSize = true;
            decagonResultLabel.BackColor = SystemColors.ButtonHighlight;
            decagonResultLabel.Location = new Point(158, 358);
            decagonResultLabel.Name = "decagonResultLabel";
            decagonResultLabel.Size = new Size(0, 20);
            decagonResultLabel.TabIndex = 8;
            // 
            // decagonTextBox
            // 
            decagonTextBox.Location = new Point(6, 53);
            decagonTextBox.Multiline = true;
            decagonTextBox.Name = "decagonTextBox";
            decagonTextBox.Size = new Size(276, 68);
            decagonTextBox.TabIndex = 7;
            decagonTextBox.Text = "para calcular el area y perimetro de un decagono se nesecita saber la longitud de uno de sus lados";
            // 
            // decagonInputSide
            // 
            decagonInputSide.BorderStyle = BorderStyle.FixedSingle;
            decagonInputSide.Location = new Point(15, 214);
            decagonInputSide.Name = "decagonInputSide";
            decagonInputSide.Size = new Size(125, 27);
            decagonInputSide.TabIndex = 6;
            // 
            // decagonPerimeterButton
            // 
            decagonPerimeterButton.Location = new Point(158, 284);
            decagonPerimeterButton.Name = "decagonPerimeterButton";
            decagonPerimeterButton.Size = new Size(153, 29);
            decagonPerimeterButton.TabIndex = 5;
            decagonPerimeterButton.Text = "calcular perimetro";
            decagonPerimeterButton.UseVisualStyleBackColor = true;
            decagonPerimeterButton.Click += decagonPerimeterButton_Click;
            // 
            // decagonAreaButton
            // 
            decagonAreaButton.Location = new Point(15, 284);
            decagonAreaButton.Name = "decagonAreaButton";
            decagonAreaButton.Size = new Size(112, 29);
            decagonAreaButton.TabIndex = 4;
            decagonAreaButton.Text = "calcular area";
            decagonAreaButton.UseVisualStyleBackColor = true;
            decagonAreaButton.Click += decagonAreaButton_Click;
            // 
            // DecagonSideLabel
            // 
            DecagonSideLabel.AutoSize = true;
            DecagonSideLabel.BackColor = SystemColors.ButtonFace;
            DecagonSideLabel.BorderStyle = BorderStyle.FixedSingle;
            DecagonSideLabel.Location = new Point(15, 149);
            DecagonSideLabel.Name = "DecagonSideLabel";
            DecagonSideLabel.Size = new Size(254, 22);
            DecagonSideLabel.TabIndex = 0;
            DecagonSideLabel.Text = "ingrese la longitud de un lado en cm";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 695);
            Controls.Add(decagonGroupBox);
            Controls.Add(CirclegroupBox);
            Name = "Mainform";
            CirclegroupBox.ResumeLayout(false);
            CirclegroupBox.PerformLayout();
            decagonGroupBox.ResumeLayout(false);
            decagonGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CirclegroupBox;
        private Label circleResultlabel;
        private TextBox CircletextBox;
        private TextBox circleInputRadius;
        private Button circlePerimeterButton;
        private Button circleAreaButton;
        private Label circleRadiusLabel;
        private GroupBox decagonGroupBox;
        private Label decagonResultLabel;
        private TextBox decagonTextBox;
        private TextBox decagonInputSide;
        private Button decagonPerimeterButton;
        private Button decagonAreaButton;
        private Label DecagonSideLabel;
    }
}