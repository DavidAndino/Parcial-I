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
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
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
            this.hornearAsinButton.Text = "Hornear Pizza Asyn";
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
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Location = new System.Drawing.Point(127, 110);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(53, 13);
            this.num1Label.TabIndex = 3;
            this.num1Label.Text = "Numero 1";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Location = new System.Drawing.Point(127, 154);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(53, 13);
            this.num2Label.TabIndex = 4;
            this.num2Label.Text = "Numero 2";
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(189, 107);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(100, 20);
            this.num1TextBox.TabIndex = 5;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(189, 151);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(100, 20);
            this.num2TextBox.TabIndex = 6;
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 232);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
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
        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
    }
}