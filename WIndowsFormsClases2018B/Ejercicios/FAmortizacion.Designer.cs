namespace WIndowsFormsClases2018B.Ejercicios
{
    partial class FAmortizacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_modPrestamo = new System.Windows.Forms.TextBox();
            this.txt_interes = new System.Windows.Forms.TextBox();
            this.txt_plazo = new System.Windows.Forms.TextBox();
            this.cb_tipoPrestamo = new System.Windows.Forms.ComboBox();
            this.cb_plazo = new System.Windows.Forms.ComboBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_amortizacion = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_amortizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_calcular);
            this.panel1.Controls.Add(this.cb_plazo);
            this.panel1.Controls.Add(this.cb_tipoPrestamo);
            this.panel1.Controls.Add(this.txt_plazo);
            this.panel1.Controls.Add(this.txt_interes);
            this.panel1.Controls.Add(this.txt_modPrestamo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 136);
            this.panel1.TabIndex = 0;
            // 
            // txt_modPrestamo
            // 
            this.txt_modPrestamo.Location = new System.Drawing.Point(116, 19);
            this.txt_modPrestamo.Name = "txt_modPrestamo";
            this.txt_modPrestamo.Size = new System.Drawing.Size(119, 20);
            this.txt_modPrestamo.TabIndex = 0;
            // 
            // txt_interes
            // 
            this.txt_interes.Location = new System.Drawing.Point(116, 78);
            this.txt_interes.Name = "txt_interes";
            this.txt_interes.Size = new System.Drawing.Size(119, 20);
            this.txt_interes.TabIndex = 1;
            // 
            // txt_plazo
            // 
            this.txt_plazo.Location = new System.Drawing.Point(116, 50);
            this.txt_plazo.Name = "txt_plazo";
            this.txt_plazo.Size = new System.Drawing.Size(119, 20);
            this.txt_plazo.TabIndex = 2;
            // 
            // cb_tipoPrestamo
            // 
            this.cb_tipoPrestamo.FormattingEnabled = true;
            this.cb_tipoPrestamo.Items.AddRange(new object[] {
            "Francesa, Alemana"});
            this.cb_tipoPrestamo.Location = new System.Drawing.Point(316, 18);
            this.cb_tipoPrestamo.Name = "cb_tipoPrestamo";
            this.cb_tipoPrestamo.Size = new System.Drawing.Size(169, 21);
            this.cb_tipoPrestamo.TabIndex = 3;
            // 
            // cb_plazo
            // 
            this.cb_plazo.FormattingEnabled = true;
            this.cb_plazo.Items.AddRange(new object[] {
            "5,10,15,20"});
            this.cb_plazo.Location = new System.Drawing.Point(316, 45);
            this.cb_plazo.Name = "cb_plazo";
            this.cb_plazo.Size = new System.Drawing.Size(169, 21);
            this.cb_plazo.TabIndex = 4;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(364, 76);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(121, 23);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Monto Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Plazo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interés";
            // 
            // grid_amortizacion
            // 
            this.grid_amortizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_amortizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Interes,
            this.Total,
            this.Numero});
            this.grid_amortizacion.Location = new System.Drawing.Point(12, 154);
            this.grid_amortizacion.Name = "grid_amortizacion";
            this.grid_amortizacion.Size = new System.Drawing.Size(516, 273);
            this.grid_amortizacion.TabIndex = 1;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            // 
            // Interes
            // 
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // FAmortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.grid_amortizacion);
            this.Controls.Add(this.panel1);
            this.Name = "FAmortizacion";
            this.Text = "FAmortizacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_amortizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.ComboBox cb_plazo;
        private System.Windows.Forms.ComboBox cb_tipoPrestamo;
        private System.Windows.Forms.TextBox txt_plazo;
        private System.Windows.Forms.TextBox txt_interes;
        private System.Windows.Forms.TextBox txt_modPrestamo;
        private System.Windows.Forms.DataGridView grid_amortizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
    }
}