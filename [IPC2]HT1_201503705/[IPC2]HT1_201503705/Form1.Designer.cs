namespace _IPC2_HT1_201503705
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.BtnHipotenusa = new System.Windows.Forms.Button();
            this.BtnVocales = new System.Windows.Forms.Button();
            this.BtnNombre = new System.Windows.Forms.Button();
            this.BtnRegla3 = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(41, 37);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 0;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(41, 80);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 1;
            // 
            // Txt3
            // 
            this.Txt3.Location = new System.Drawing.Point(41, 117);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(100, 20);
            this.Txt3.TabIndex = 2;
            // 
            // BtnHipotenusa
            // 
            this.BtnHipotenusa.Location = new System.Drawing.Point(181, 53);
            this.BtnHipotenusa.Name = "BtnHipotenusa";
            this.BtnHipotenusa.Size = new System.Drawing.Size(75, 23);
            this.BtnHipotenusa.TabIndex = 3;
            this.BtnHipotenusa.Text = "Hipotenusa";
            this.BtnHipotenusa.UseVisualStyleBackColor = true;
            this.BtnHipotenusa.Click += new System.EventHandler(this.BtnHipotenusa_Click);
            // 
            // BtnVocales
            // 
            this.BtnVocales.Location = new System.Drawing.Point(262, 53);
            this.BtnVocales.Name = "BtnVocales";
            this.BtnVocales.Size = new System.Drawing.Size(75, 23);
            this.BtnVocales.TabIndex = 4;
            this.BtnVocales.Text = "Vocales";
            this.BtnVocales.UseVisualStyleBackColor = true;
            // 
            // BtnNombre
            // 
            this.BtnNombre.Location = new System.Drawing.Point(181, 98);
            this.BtnNombre.Name = "BtnNombre";
            this.BtnNombre.Size = new System.Drawing.Size(75, 23);
            this.BtnNombre.TabIndex = 5;
            this.BtnNombre.Text = "Nombre";
            this.BtnNombre.UseVisualStyleBackColor = true;
            // 
            // BtnRegla3
            // 
            this.BtnRegla3.Location = new System.Drawing.Point(262, 98);
            this.BtnRegla3.Name = "BtnRegla3";
            this.BtnRegla3.Size = new System.Drawing.Size(75, 23);
            this.BtnRegla3.TabIndex = 6;
            this.BtnRegla3.Text = "Regla 3";
            this.BtnRegla3.UseVisualStyleBackColor = true;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(137, 155);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(82, 20);
            this.LblResultado.TabIndex = 7;
            this.LblResultado.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "#2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "#1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "#3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 193);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.BtnRegla3);
            this.Controls.Add(this.BtnNombre);
            this.Controls.Add(this.BtnVocales);
            this.Controls.Add(this.BtnHipotenusa);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.Button BtnHipotenusa;
        private System.Windows.Forms.Button BtnVocales;
        private System.Windows.Forms.Button BtnNombre;
        private System.Windows.Forms.Button BtnRegla3;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

