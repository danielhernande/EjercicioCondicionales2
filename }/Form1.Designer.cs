namespace _
{
    partial class calcular
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txthorastrabajadas = new System.Windows.Forms.TextBox();
            this.gbxresumenpago = new System.Windows.Forms.GroupBox();
            this.lblsalalrioapagar = new System.Windows.Forms.Label();
            this.lblincremento = new System.Windows.Forms.Label();
            this.lblpagosalud = new System.Windows.Forms.Label();
            this.lblsalariobase = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.btnlimpiarcampo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxrespuesta = new System.Windows.Forms.ComboBox();
            this.gbxresumenpago.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Salario empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese las horas Trabajadas ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ingrese el valor de la hora trabajadas ";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(580, 111);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(121, 34);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.Location = new System.Drawing.Point(291, 98);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txthorastrabajadas.TabIndex = 4;
            // 
            // gbxresumenpago
            // 
            this.gbxresumenpago.Controls.Add(this.lblsalalrioapagar);
            this.gbxresumenpago.Controls.Add(this.lblincremento);
            this.gbxresumenpago.Controls.Add(this.lblpagosalud);
            this.gbxresumenpago.Controls.Add(this.lblsalariobase);
            this.gbxresumenpago.Controls.Add(this.label7);
            this.gbxresumenpago.Controls.Add(this.label4);
            this.gbxresumenpago.Controls.Add(this.label5);
            this.gbxresumenpago.Controls.Add(this.label6);
            this.gbxresumenpago.Location = new System.Drawing.Point(33, 263);
            this.gbxresumenpago.Name = "gbxresumenpago";
            this.gbxresumenpago.Size = new System.Drawing.Size(703, 151);
            this.gbxresumenpago.TabIndex = 5;
            this.gbxresumenpago.TabStop = false;
            this.gbxresumenpago.Text = "Resumen de pago";
            this.gbxresumenpago.Visible = false;
            this.gbxresumenpago.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblsalalrioapagar
            // 
            this.lblsalalrioapagar.AutoSize = true;
            this.lblsalalrioapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblsalalrioapagar.Location = new System.Drawing.Point(504, 84);
            this.lblsalalrioapagar.Name = "lblsalalrioapagar";
            this.lblsalalrioapagar.Size = new System.Drawing.Size(95, 29);
            this.lblsalalrioapagar.TabIndex = 7;
            this.lblsalalrioapagar.Text = "label11";
            // 
            // lblincremento
            // 
            this.lblincremento.AutoSize = true;
            this.lblincremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblincremento.Location = new System.Drawing.Point(504, 21);
            this.lblincremento.Name = "lblincremento";
            this.lblincremento.Size = new System.Drawing.Size(95, 29);
            this.lblincremento.TabIndex = 6;
            this.lblincremento.Text = "label10";
            // 
            // lblpagosalud
            // 
            this.lblpagosalud.AutoSize = true;
            this.lblpagosalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblpagosalud.Location = new System.Drawing.Point(133, 84);
            this.lblpagosalud.Name = "lblpagosalud";
            this.lblpagosalud.Size = new System.Drawing.Size(81, 29);
            this.lblpagosalud.TabIndex = 5;
            this.lblpagosalud.Text = "label9";
            // 
            // lblsalariobase
            // 
            this.lblsalariobase.AutoSize = true;
            this.lblsalariobase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblsalariobase.Location = new System.Drawing.Point(133, 23);
            this.lblsalariobase.Name = "lblsalariobase";
            this.lblsalariobase.Size = new System.Drawing.Size(81, 29);
            this.lblsalariobase.TabIndex = 4;
            this.lblsalariobase.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Salario a Pagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Salario base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pago Salud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Incremento";
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Location = new System.Drawing.Point(289, 161);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(100, 20);
            this.txtvalorhora.TabIndex = 6;
            // 
            // btnlimpiarcampo
            // 
            this.btnlimpiarcampo.Location = new System.Drawing.Point(580, 192);
            this.btnlimpiarcampo.Name = "btnlimpiarcampo";
            this.btnlimpiarcampo.Size = new System.Drawing.Size(121, 34);
            this.btnlimpiarcampo.TabIndex = 7;
            this.btnlimpiarcampo.Text = "Limpiar Campo";
            this.btnlimpiarcampo.UseVisualStyleBackColor = true;
            this.btnlimpiarcampo.Click += new System.EventHandler(this.btnlimpiarcampo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Eres empleado Administrativo?";
            // 
            // cbxrespuesta
            // 
            this.cbxrespuesta.FormattingEnabled = true;
            this.cbxrespuesta.Items.AddRange(new object[] {
            "NO",
            "SI"});
            this.cbxrespuesta.Location = new System.Drawing.Point(173, 210);
            this.cbxrespuesta.Name = "cbxrespuesta";
            this.cbxrespuesta.Size = new System.Drawing.Size(121, 21);
            this.cbxrespuesta.TabIndex = 9;
            // 
            // calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxrespuesta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnlimpiarcampo);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.gbxresumenpago);
            this.Controls.Add(this.txthorastrabajadas);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "calcular";
            this.Text = "Calculadora de Salarios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxresumenpago.ResumeLayout(false);
            this.gbxresumenpago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txthorastrabajadas;
        private System.Windows.Forms.GroupBox gbxresumenpago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsalalrioapagar;
        private System.Windows.Forms.Label lblincremento;
        private System.Windows.Forms.Label lblpagosalud;
        private System.Windows.Forms.Label lblsalariobase;
        private System.Windows.Forms.Button btnlimpiarcampo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxrespuesta;
    }
}

