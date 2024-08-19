namespace Ej2
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
            this.nMes = new System.Windows.Forms.NumericUpDown();
            this.nAño = new System.Windows.Forms.NumericUpDown();
            this.lA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBdni = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tBaño = new System.Windows.Forms.TextBox();
            this.tBh100 = new System.Windows.Forms.TextBox();
            this.tBh50 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbEmpleados = new System.Windows.Forms.ListBox();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bGenerarliq = new System.Windows.Forms.Button();
            this.lbLiquidaciones = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAño)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nMes
            // 
            this.nMes.Location = new System.Drawing.Point(49, 19);
            this.nMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nMes.Name = "nMes";
            this.nMes.Size = new System.Drawing.Size(65, 20);
            this.nMes.TabIndex = 0;
            // 
            // nAño
            // 
            this.nAño.Location = new System.Drawing.Point(49, 55);
            this.nAño.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nAño.Name = "nAño";
            this.nAño.Size = new System.Drawing.Size(65, 20);
            this.nAño.TabIndex = 1;
            // 
            // lA
            // 
            this.lA.AutoSize = true;
            this.lA.Location = new System.Drawing.Point(14, 21);
            this.lA.Name = "lA";
            this.lA.Size = new System.Drawing.Size(29, 13);
            this.lA.TabIndex = 2;
            this.lA.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DNI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Año contratado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Horas extras al 50%:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Horas extras al 100%:";
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(133, 19);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(100, 20);
            this.tBnombre.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bRegistrar);
            this.groupBox1.Controls.Add(this.lbEmpleados);
            this.groupBox1.Controls.Add(this.tBh50);
            this.groupBox1.Controls.Add(this.tBh100);
            this.groupBox1.Controls.Add(this.tBaño);
            this.groupBox1.Controls.Add(this.tbApellido);
            this.groupBox1.Controls.Add(this.tBdni);
            this.groupBox1.Controls.Add(this.tBnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 333);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar empleado";
            // 
            // tBdni
            // 
            this.tBdni.Location = new System.Drawing.Point(132, 69);
            this.tBdni.Name = "tBdni";
            this.tBdni.Size = new System.Drawing.Size(101, 20);
            this.tBdni.TabIndex = 11;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(133, 44);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(100, 20);
            this.tbApellido.TabIndex = 12;
            // 
            // tBaño
            // 
            this.tBaño.Location = new System.Drawing.Point(132, 92);
            this.tBaño.Name = "tBaño";
            this.tBaño.Size = new System.Drawing.Size(49, 20);
            this.tBaño.TabIndex = 13;
            // 
            // tBh100
            // 
            this.tBh100.Location = new System.Drawing.Point(132, 145);
            this.tBh100.Name = "tBh100";
            this.tBh100.Size = new System.Drawing.Size(49, 20);
            this.tBh100.TabIndex = 14;
            // 
            // tBh50
            // 
            this.tBh50.Location = new System.Drawing.Point(132, 118);
            this.tBh50.Name = "tBh50";
            this.tBh50.Size = new System.Drawing.Size(49, 20);
            this.tBh50.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLiquidaciones);
            this.groupBox2.Controls.Add(this.bGenerarliq);
            this.groupBox2.Controls.Add(this.nMes);
            this.groupBox2.Controls.Add(this.nAño);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lA);
            this.groupBox2.Location = new System.Drawing.Point(279, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 280);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar Liquidaciones";
            // 
            // lbEmpleados
            // 
            this.lbEmpleados.FormattingEnabled = true;
            this.lbEmpleados.Location = new System.Drawing.Point(6, 171);
            this.lbEmpleados.Name = "lbEmpleados";
            this.lbEmpleados.Size = new System.Drawing.Size(240, 121);
            this.lbEmpleados.TabIndex = 13;
            // 
            // bRegistrar
            // 
            this.bRegistrar.Location = new System.Drawing.Point(32, 298);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(75, 23);
            this.bRegistrar.TabIndex = 16;
            this.bRegistrar.Text = "Registrar";
            this.bRegistrar.UseVisualStyleBackColor = true;
            this.bRegistrar.Click += new System.EventHandler(this.bRegistrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bGenerarliq
            // 
            this.bGenerarliq.Location = new System.Drawing.Point(167, 22);
            this.bGenerarliq.Name = "bGenerarliq";
            this.bGenerarliq.Size = new System.Drawing.Size(90, 38);
            this.bGenerarliq.TabIndex = 4;
            this.bGenerarliq.Text = "Generar";
            this.bGenerarliq.UseVisualStyleBackColor = true;
            this.bGenerarliq.Click += new System.EventHandler(this.bGenerarliq_Click);
            // 
            // lbLiquidaciones
            // 
            this.lbLiquidaciones.FormattingEnabled = true;
            this.lbLiquidaciones.Location = new System.Drawing.Point(6, 119);
            this.lbLiquidaciones.Name = "lbLiquidaciones";
            this.lbLiquidaciones.Size = new System.Drawing.Size(581, 147);
            this.lbLiquidaciones.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nAño)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nMes;
        private System.Windows.Forms.NumericUpDown nAño;
        private System.Windows.Forms.Label lA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBh50;
        private System.Windows.Forms.TextBox tBh100;
        private System.Windows.Forms.TextBox tBaño;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tBdni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbEmpleados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bRegistrar;
        private System.Windows.Forms.Button bGenerarliq;
        private System.Windows.Forms.ListBox lbLiquidaciones;
    }
}

