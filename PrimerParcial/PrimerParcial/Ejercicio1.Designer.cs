namespace PrimerParcial
{
    partial class Ejercicio1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sumarButton = new System.Windows.Forms.Button();
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sumarButton
            // 
            this.sumarButton.Location = new System.Drawing.Point(132, 121);
            this.sumarButton.Name = "sumarButton";
            this.sumarButton.Size = new System.Drawing.Size(75, 23);
            this.sumarButton.TabIndex = 0;
            this.sumarButton.Text = "Sumar";
            this.sumarButton.UseVisualStyleBackColor = true;
            this.sumarButton.Click += new System.EventHandler(this.sumarButton_Click);
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1Label.Location = new System.Drawing.Point(57, 31);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(81, 20);
            this.num1Label.TabIndex = 1;
            this.num1Label.Text = "Número1";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2Label.Location = new System.Drawing.Point(57, 70);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(81, 20);
            this.num2Label.TabIndex = 2;
            this.num2Label.Text = "Número2";
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(160, 33);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(47, 20);
            this.num1TextBox.TabIndex = 3;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(160, 72);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(47, 20);
            this.num2TextBox.TabIndex = 4;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(281, 199);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.Controls.Add(this.sumarButton);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumarButton;
        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
    }
}

