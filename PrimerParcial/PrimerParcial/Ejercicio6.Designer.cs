namespace PrimerParcial
{
    partial class Ejercicio6
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
            this.arrayListBox = new System.Windows.Forms.ListBox();
            this.arrayButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // arrayListBox
            // 
            this.arrayListBox.FormattingEnabled = true;
            this.arrayListBox.Location = new System.Drawing.Point(45, 23);
            this.arrayListBox.Name = "arrayListBox";
            this.arrayListBox.Size = new System.Drawing.Size(120, 95);
            this.arrayListBox.TabIndex = 0;
            // 
            // arrayButton
            // 
            this.arrayButton.Location = new System.Drawing.Point(186, 23);
            this.arrayButton.Name = "arrayButton";
            this.arrayButton.Size = new System.Drawing.Size(75, 23);
            this.arrayButton.TabIndex = 1;
            this.arrayButton.Text = "Arreglos";
            this.arrayButton.UseVisualStyleBackColor = true;
            this.arrayButton.Click += new System.EventHandler(this.arrayButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(360, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 224);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.arrayButton);
            this.Controls.Add(this.arrayListBox);
            this.Name = "Ejercicio6";
            this.Text = "Ejercicio6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox arrayListBox;
        private System.Windows.Forms.Button arrayButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}