namespace EjerciciosGuia4
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
            this.label1 = new System.Windows.Forms.Label();
            this.IngresoDeValor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnNumero = new System.Windows.Forms.Button();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listbArreglo = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un valor  al arreglo ";
            // 
            // IngresoDeValor
            // 
            this.IngresoDeValor.Location = new System.Drawing.Point(246, 27);
            this.IngresoDeValor.Multiline = true;
            this.IngresoDeValor.Name = "IngresoDeValor";
            this.IngresoDeValor.Size = new System.Drawing.Size(110, 128);
            this.IngresoDeValor.TabIndex = 1;
            this.IngresoDeValor.TextChanged += new System.EventHandler(this.IngresoDeValor_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(377, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ingresar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMayor);
            this.groupBox1.Controls.Add(this.btnPromedio);
            this.groupBox1.Controls.Add(this.btnPorcentaje);
            this.groupBox1.Controls.Add(this.btnNumero);
            this.groupBox1.Controls.Add(this.txtMayor);
            this.groupBox1.Controls.Add(this.txtPromedio);
            this.groupBox1.Controls.Add(this.txtPorcentaje);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(204, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 186);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERACIONES CON ARREGLOS";
            // 
            // btnMayor
            // 
            this.btnMayor.BackColor = System.Drawing.Color.PaleGreen;
            this.btnMayor.Location = new System.Drawing.Point(351, 119);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(75, 23);
            this.btnMayor.TabIndex = 11;
            this.btnMayor.Text = "INGRESAR";
            this.btnMayor.UseVisualStyleBackColor = false;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPromedio.Location = new System.Drawing.Point(351, 89);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 10;
            this.btnPromedio.Text = "INGRESAR";
            this.btnPromedio.UseVisualStyleBackColor = false;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPorcentaje.Location = new System.Drawing.Point(351, 59);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(75, 23);
            this.btnPorcentaje.TabIndex = 9;
            this.btnPorcentaje.Text = "INGRESAR";
            this.btnPorcentaje.UseVisualStyleBackColor = false;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnNumero
            // 
            this.btnNumero.BackColor = System.Drawing.Color.PaleGreen;
            this.btnNumero.Location = new System.Drawing.Point(351, 28);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(75, 23);
            this.btnNumero.TabIndex = 8;
            this.btnNumero.Text = "INGRESAR";
            this.btnNumero.UseVisualStyleBackColor = false;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // txtMayor
            // 
            this.txtMayor.BackColor = System.Drawing.SystemColors.Control;
            this.txtMayor.Location = new System.Drawing.Point(227, 122);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.ReadOnly = true;
            this.txtMayor.Size = new System.Drawing.Size(100, 20);
            this.txtMayor.TabIndex = 7;
            // 
            // txtPromedio
            // 
            this.txtPromedio.BackColor = System.Drawing.SystemColors.Control;
            this.txtPromedio.Location = new System.Drawing.Point(227, 92);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 6;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BackColor = System.Drawing.SystemColors.Control;
            this.txtPorcentaje.Location = new System.Drawing.Point(227, 62);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.ReadOnly = true;
            this.txtPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.txtPorcentaje.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumero.Location = new System.Drawing.Point(227, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mayor de los pares positivios ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Promedio de impares positivos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Porcentaje de ceros en el arreglo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número mayor de pares negativos";
            // 
            // listbArreglo
            // 
            this.listbArreglo.Location = new System.Drawing.Point(25, 176);
            this.listbArreglo.Name = "listbArreglo";
            this.listbArreglo.Size = new System.Drawing.Size(121, 186);
            this.listbArreglo.TabIndex = 5;
            this.listbArreglo.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 416);
            this.Controls.Add(this.listbArreglo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IngresoDeValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculos Basicos ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IngresoDeValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listbArreglo;
    }
}

