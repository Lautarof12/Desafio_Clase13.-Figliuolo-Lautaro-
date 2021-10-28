
namespace Desafio_clase_13
{
    partial class Form1
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
            this.tipoInm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pisos = new System.Windows.Forms.TextBox();
            this.Ventanas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Metros = new System.Windows.Forms.TextBox();
            this.Antiguedad = new System.Windows.Forms.TextBox();
            this.precioBase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.rbPiso = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tipoInm
            // 
            this.tipoInm.AutoSize = true;
            this.tipoInm.Location = new System.Drawing.Point(13, 25);
            this.tipoInm.Name = "tipoInm";
            this.tipoInm.Size = new System.Drawing.Size(88, 13);
            this.tipoInm.TabIndex = 0;
            this.tipoInm.Text = "Tipo de inmueble";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Piso Nro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro de ventanas";
            // 
            // Pisos
            // 
            this.Pisos.Location = new System.Drawing.Point(19, 125);
            this.Pisos.Name = "Pisos";
            this.Pisos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pisos.Size = new System.Drawing.Size(56, 20);
            this.Pisos.TabIndex = 5;
            // 
            // Ventanas
            // 
            this.Ventanas.Location = new System.Drawing.Point(155, 124);
            this.Ventanas.Name = "Ventanas";
            this.Ventanas.Size = new System.Drawing.Size(83, 20);
            this.Ventanas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DIRECCION";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(19, 200);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(207, 20);
            this.Direccion.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Superficie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Antiguedad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio base";
            // 
            // Metros
            // 
            this.Metros.Location = new System.Drawing.Point(22, 259);
            this.Metros.Name = "Metros";
            this.Metros.Size = new System.Drawing.Size(53, 20);
            this.Metros.TabIndex = 12;
            // 
            // Antiguedad
            // 
            this.Antiguedad.Location = new System.Drawing.Point(119, 258);
            this.Antiguedad.Name = "Antiguedad";
            this.Antiguedad.Size = new System.Drawing.Size(58, 20);
            this.Antiguedad.TabIndex = 13;
            // 
            // precioBase
            // 
            this.precioBase.Location = new System.Drawing.Point(216, 258);
            this.precioBase.Name = "precioBase";
            this.precioBase.Size = new System.Drawing.Size(68, 20);
            this.precioBase.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "(m2)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "(años)";
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calcular.Location = new System.Drawing.Point(22, 297);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(239, 46);
            this.calcular.TabIndex = 17;
            this.calcular.Text = "CALCULAR EL PRECIO FINAL";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // rbPiso
            // 
            this.rbPiso.AutoSize = true;
            this.rbPiso.Location = new System.Drawing.Point(16, 61);
            this.rbPiso.Name = "rbPiso";
            this.rbPiso.Size = new System.Drawing.Size(45, 17);
            this.rbPiso.TabIndex = 18;
            this.rbPiso.TabStop = true;
            this.rbPiso.Text = "Piso";
            this.rbPiso.UseVisualStyleBackColor = true;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(155, 61);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(51, 17);
            this.rbLocal.TabIndex = 19;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 355);
            this.Controls.Add(this.rbLocal);
            this.Controls.Add(this.rbPiso);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.precioBase);
            this.Controls.Add(this.Antiguedad);
            this.Controls.Add(this.Metros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ventanas);
            this.Controls.Add(this.Pisos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoInm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tipoInm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pisos;
        private System.Windows.Forms.TextBox Ventanas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Metros;
        private System.Windows.Forms.TextBox Antiguedad;
        private System.Windows.Forms.TextBox precioBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.RadioButton rbPiso;
        private System.Windows.Forms.RadioButton rbLocal;
    }
}

