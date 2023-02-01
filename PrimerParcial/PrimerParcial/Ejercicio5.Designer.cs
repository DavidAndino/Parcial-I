namespace PrimerParcial
{
    partial class Ejercicio5
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
            this.hornearButton = new System.Windows.Forms.Button();
            this.hornearAsinButton = new System.Windows.Forms.Button();
            this.calcularButtom = new System.Windows.Forms.Button();
            this.Num1Label = new System.Windows.Forms.Label();
            this.Num2Label = new System.Windows.Forms.Label();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hornearButton
            // 
            this.hornearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hornearButton.Location = new System.Drawing.Point(28, 25);
            this.hornearButton.Name = "hornearButton";
            this.hornearButton.Size = new System.Drawing.Size(152, 59);
            this.hornearButton.TabIndex = 0;
            this.hornearButton.Text = "Hornear Pizza";
            this.hornearButton.UseVisualStyleBackColor = true;
            this.hornearButton.Click += new System.EventHandler(this.hornearButton_Click);
            // 
            // hornearAsinButton
            // 
            this.hornearAsinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hornearAsinButton.Location = new System.Drawing.Point(282, 25);
            this.hornearAsinButton.Name = "hornearAsinButton";
            this.hornearAsinButton.Size = new System.Drawing.Size(152, 59);
            this.hornearAsinButton.TabIndex = 1;
            this.hornearAsinButton.Text = "Hornear Pizza";
            this.hornearAsinButton.UseVisualStyleBackColor = true;
            this.hornearAsinButton.Click += new System.EventHandler(this.hornearAsinButton_Click);
            // 
            // calcularButtom
            // 
            this.calcularButtom.Location = new System.Drawing.Point(189, 187);
            this.calcularButtom.Name = "calcularButtom";
            this.calcularButtom.Size = new System.Drawing.Size(75, 23);
            this.calcularButtom.TabIndex = 2;
            this.calcularButtom.Text = "Calcular";
            this.calcularButtom.UseVisualStyleBackColor = true;
            this.calcularButtom.Click += new System.EventHandler(this.calcularButtom_Click);
            // 
            // Num1Label
            // 
            this.Num1Label.AutoSize = true;
            this.Num1Label.Location = new System.Drawing.Point(131, 114);
            this.Num1Label.Name = "Num1Label";
            this.Num1Label.Size = new System.Drawing.Size(35, 13);
            this.Num1Label.TabIndex = 3;
            this.Num1Label.Text = "Num1";
            // 
            // Num2Label
            // 
            this.Num2Label.AutoSize = true;
            this.Num2Label.Location = new System.Drawing.Point(131, 151);
            this.Num2Label.Name = "Num2Label";
            this.Num2Label.Size = new System.Drawing.Size(35, 13);
            this.Num2Label.TabIndex = 4;
            this.Num2Label.Text = "Num2";
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(189, 107);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(100, 20);
            this.num1TextBox.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 232);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.num1TextBox);
            this.Controls.Add(this.Num2Label);
            this.Controls.Add(this.Num1Label);
            this.Controls.Add(this.calcularButtom);
            this.Controls.Add(this.hornearAsinButton);
            this.Controls.Add(this.hornearButton);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hornearButton;
        private System.Windows.Forms.Button hornearAsinButton;
        private System.Windows.Forms.Button calcularButtom;
        private System.Windows.Forms.Label Num1Label;
        private System.Windows.Forms.Label Num2Label;
        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}