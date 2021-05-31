namespace Presentacion
{
    partial class Principal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtgTokens = new System.Windows.Forms.DataGridView();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.btnSeparar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAlarma = new System.Windows.Forms.ComboBox();
            this.CmbCaliente = new System.Windows.Forms.ComboBox();
            this.cmbFria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPlaca = new System.Windows.Forms.ComboBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1241, 52);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(857, 56);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(157, 51);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(213, 55);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(160, 51);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtgTokens
            // 
            this.dtgTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTokens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgTokens.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTokens.Location = new System.Drawing.Point(417, 121);
            this.dtgTokens.Name = "dtgTokens";
            this.dtgTokens.RowHeadersWidth = 51;
            this.dtgTokens.RowTemplate.Height = 24;
            this.dtgTokens.Size = new System.Drawing.Size(606, 456);
            this.dtgTokens.TabIndex = 9;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(12, 121);
            this.TxtCodigo.Multiline = true;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtCodigo.Size = new System.Drawing.Size(385, 456);
            this.TxtCodigo.TabIndex = 8;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // btnSeparar
            // 
            this.btnSeparar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSeparar.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeparar.ForeColor = System.Drawing.Color.White;
            this.btnSeparar.Location = new System.Drawing.Point(12, 55);
            this.btnSeparar.Name = "btnSeparar";
            this.btnSeparar.Size = new System.Drawing.Size(163, 51);
            this.btnSeparar.TabIndex = 7;
            this.btnSeparar.Text = "Compilar";
            this.btnSeparar.UseVisualStyleBackColor = false;
            this.btnSeparar.Click += new System.EventHandler(this.btnSeparar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(403, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Compilador Despachador de Agua";
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(1044, 394);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(163, 35);
            this.cmbPuertos.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1043, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Puerto Arduino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1039, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pin Alarma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1039, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pin Caliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1043, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pin Fria";
            // 
            // cmbAlarma
            // 
            this.cmbAlarma.FormattingEnabled = true;
            this.cmbAlarma.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmbAlarma.Location = new System.Drawing.Point(1041, 158);
            this.cmbAlarma.Name = "cmbAlarma";
            this.cmbAlarma.Size = new System.Drawing.Size(159, 35);
            this.cmbAlarma.TabIndex = 22;
            // 
            // CmbCaliente
            // 
            this.CmbCaliente.FormattingEnabled = true;
            this.CmbCaliente.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.CmbCaliente.Location = new System.Drawing.Point(1041, 240);
            this.CmbCaliente.Name = "CmbCaliente";
            this.CmbCaliente.Size = new System.Drawing.Size(159, 35);
            this.CmbCaliente.TabIndex = 23;
            // 
            // cmbFria
            // 
            this.cmbFria.FormattingEnabled = true;
            this.cmbFria.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmbFria.Location = new System.Drawing.Point(1044, 316);
            this.cmbFria.Name = "cmbFria";
            this.cmbFria.Size = new System.Drawing.Size(156, 35);
            this.cmbFria.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1043, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Placa Arduino";
            // 
            // cmbPlaca
            // 
            this.cmbPlaca.FormattingEnabled = true;
            this.cmbPlaca.Items.AddRange(new object[] {
            "Uno",
            "Leonardo",
            "Esplora",
            "Micro",
            "Duemilanove 328",
            "Duemilanove 168",
            "Nano 328",
            "Nano 168",
            "Mini 328",
            "Mini 168",
            "Pro Mini 328",
            "Pro Mini 168",
            "Mega 2560/ADK",
            "Mega 1280",
            "Mega 8",
            "Microduino Core +",
            "Freematics"});
            this.cmbPlaca.Location = new System.Drawing.Point(1044, 476);
            this.cmbPlaca.Name = "cmbPlaca";
            this.cmbPlaca.Size = new System.Drawing.Size(163, 35);
            this.cmbPlaca.TabIndex = 25;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAbrir.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(420, 56);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(160, 51);
            this.btnAbrir.TabIndex = 27;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(642, 56);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 51);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 607);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbPlaca);
            this.Controls.Add(this.cmbFria);
            this.Controls.Add(this.CmbCaliente);
            this.Controls.Add(this.cmbAlarma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPuertos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtgTokens);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.btnSeparar);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dtgTokens;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button btnSeparar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAlarma;
        private System.Windows.Forms.ComboBox CmbCaliente;
        private System.Windows.Forms.ComboBox cmbFria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPlaca;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
    }
}