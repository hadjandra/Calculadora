namespace Calculadora
{
    partial class Resultado
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
            Somar = new Button();
            primeiroNumero = new TextBox();
            segundoNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Somar
            // 
            Somar.Location = new Point(274, 233);
            Somar.Name = "Somar";
            Somar.Size = new Size(112, 34);
            Somar.TabIndex = 0;
            Somar.Text = "Somar";
            Somar.UseVisualStyleBackColor = true;
            // 
            // primeiroNumero
            // 
            primeiroNumero.Location = new Point(274, 84);
            primeiroNumero.Name = "primeiroNumero";
            primeiroNumero.Size = new Size(150, 31);
            primeiroNumero.TabIndex = 1;
            // 
            // segundoNumero
            // 
            segundoNumero.Location = new Point(274, 161);
            segundoNumero.Name = "segundoNumero";
            segundoNumero.Size = new Size(150, 31);
            segundoNumero.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 84);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 3;
            label1.Text = "Primeiro Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 167);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 4;
            label2.Text = "Segundo Número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 137);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 5;
            label3.Text = "0";
            // 
            // Resultado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(segundoNumero);
            Controls.Add(primeiroNumero);
            Controls.Add(Somar);
            Name = "Resultado";
            Text = "0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Somar;
        private TextBox primeiroNumero;
        private TextBox segundoNumero;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}