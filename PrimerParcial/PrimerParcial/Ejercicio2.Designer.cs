namespace PrimerParcial
{
    partial class Ejercicio2
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
            this.components = new System.ComponentModel.Container();
            this.num1label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.num1TextBox = new System.Windows.Forms.TextBox();
            this.num2TextBox = new System.Windows.Forms.TextBox();
            this.oPcomboBox = new System.Windows.Forms.ComboBox();
            this.ejecutarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.respuestaTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // num1label
            // 
            this.num1label.AutoSize = true;
            this.num1label.Location = new System.Drawing.Point(72, 52);
            this.num1label.Name = "num1label";
            this.num1label.Size = new System.Drawing.Size(94, 24);
            this.num1label.TabIndex = 0;
            this.num1label.Text = "Numero 1";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Location = new System.Drawing.Point(72, 99);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(94, 24);
            this.num2Label.TabIndex = 1;
            this.num2Label.Text = "Numero 2";
            // 
            // num1TextBox
            // 
            this.num1TextBox.Location = new System.Drawing.Point(186, 49);
            this.num1TextBox.Name = "num1TextBox";
            this.num1TextBox.Size = new System.Drawing.Size(53, 29);
            this.num1TextBox.TabIndex = 2;
            // 
            // num2TextBox
            // 
            this.num2TextBox.Location = new System.Drawing.Point(186, 96);
            this.num2TextBox.Name = "num2TextBox";
            this.num2TextBox.Size = new System.Drawing.Size(53, 29);
            this.num2TextBox.TabIndex = 3;
            // 
            // oPcomboBox
            // 
            this.oPcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oPcomboBox.FormattingEnabled = true;
            this.oPcomboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.oPcomboBox.Location = new System.Drawing.Point(186, 148);
            this.oPcomboBox.Name = "oPcomboBox";
            this.oPcomboBox.Size = new System.Drawing.Size(53, 32);
            this.oPcomboBox.TabIndex = 4;
            // 
            // ejecutarButton
            // 
            this.ejecutarButton.Location = new System.Drawing.Point(161, 199);
            this.ejecutarButton.Name = "ejecutarButton";
            this.ejecutarButton.Size = new System.Drawing.Size(98, 38);
            this.ejecutarButton.TabIndex = 5;
            this.ejecutarButton.Text = "Ejecutar";
            this.ejecutarButton.UseVisualStyleBackColor = true;
            this.ejecutarButton.Click += new System.EventHandler(this.ejecutarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Respuesta:";
            // 
            // respuestaTextBox
            // 
            this.respuestaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuestaTextBox.Location = new System.Drawing.Point(186, 267);
            this.respuestaTextBox.Name = "respuestaTextBox";
            this.respuestaTextBox.Size = new System.Drawing.Size(62, 29);
            this.respuestaTextBox.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 315);
            this.Controls.Add(this.respuestaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ejecutarButton);
            this.Controls.Add(this.oPcomboBox);
            this.Controls.Add(this.num2TextBox);
            this.Controls.Add(this.num1TextBox);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.TextBox num1TextBox;
        private System.Windows.Forms.TextBox num2TextBox;
        private System.Windows.Forms.ComboBox oPcomboBox;
        private System.Windows.Forms.Button ejecutarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox respuestaTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}