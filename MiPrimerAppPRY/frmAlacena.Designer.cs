namespace MiPrimerAppPRY
{
    partial class frmAlacena
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.mrcAlacena = new System.Windows.Forms.GroupBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.optAlacena = new System.Windows.Forms.RadioButton();
            this.optHeladera = new System.Windows.Forms.RadioButton();
            this.optBaño = new System.Windows.Forms.RadioButton();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.xd = new System.Windows.Forms.ListBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.mrcAlacena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // mrcAlacena
            // 
            this.mrcAlacena.Controls.Add(this.dateTimePicker1);
            this.mrcAlacena.Controls.Add(this.lblFechaVencimiento);
            this.mrcAlacena.Controls.Add(this.optBaño);
            this.mrcAlacena.Controls.Add(this.optHeladera);
            this.mrcAlacena.Controls.Add(this.optAlacena);
            this.mrcAlacena.Controls.Add(this.nudCantidad);
            this.mrcAlacena.Controls.Add(this.cboProducto);
            this.mrcAlacena.Controls.Add(this.lblCantidad);
            this.mrcAlacena.Controls.Add(this.lblProducto);
            this.mrcAlacena.Controls.Add(this.lblLugar);
            this.mrcAlacena.Location = new System.Drawing.Point(13, 13);
            this.mrcAlacena.Name = "mrcAlacena";
            this.mrcAlacena.Size = new System.Drawing.Size(413, 193);
            this.mrcAlacena.TabIndex = 0;
            this.mrcAlacena.TabStop = false;
            this.mrcAlacena.Text = "Alimentos / Productos";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(47, 30);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 0;
            this.lblLugar.Text = "Lugar";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(192, 30);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(338, 30);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "Comida1",
            "Comida2",
            "Originalidad1",
            "Originalidad2"});
            this.cboProducto.Location = new System.Drawing.Point(141, 46);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(121, 21);
            this.cboProducto.TabIndex = 3;
            this.cboProducto.Text = "Ingrese Producto";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(287, 46);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 4;
            // 
            // optAlacena
            // 
            this.optAlacena.AutoSize = true;
            this.optAlacena.Location = new System.Drawing.Point(17, 49);
            this.optAlacena.Name = "optAlacena";
            this.optAlacena.Size = new System.Drawing.Size(64, 17);
            this.optAlacena.TabIndex = 5;
            this.optAlacena.TabStop = true;
            this.optAlacena.Text = "Alacena";
            this.optAlacena.UseVisualStyleBackColor = true;
            // 
            // optHeladera
            // 
            this.optHeladera.AutoSize = true;
            this.optHeladera.Location = new System.Drawing.Point(17, 72);
            this.optHeladera.Name = "optHeladera";
            this.optHeladera.Size = new System.Drawing.Size(68, 17);
            this.optHeladera.TabIndex = 6;
            this.optHeladera.TabStop = true;
            this.optHeladera.Text = "Heladera";
            this.optHeladera.UseVisualStyleBackColor = true;
            // 
            // optBaño
            // 
            this.optBaño.AutoSize = true;
            this.optBaño.Location = new System.Drawing.Point(17, 95);
            this.optBaño.Name = "optBaño";
            this.optBaño.Size = new System.Drawing.Size(50, 17);
            this.optBaño.TabIndex = 7;
            this.optBaño.TabStop = true;
            this.optBaño.Text = "Baño";
            this.optBaño.UseVisualStyleBackColor = true;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(6, 128);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVencimiento.TabIndex = 8;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // xd
            // 
            this.xd.BackColor = System.Drawing.Color.White;
            this.xd.FormattingEnabled = true;
            this.xd.Location = new System.Drawing.Point(13, 212);
            this.xd.Name = "xd";
            this.xd.Size = new System.Drawing.Size(413, 95);
            this.xd.TabIndex = 1;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(344, 319);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 2;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(12, 319);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmAlacena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 354);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.xd);
            this.Controls.Add(this.mrcAlacena);
            this.Name = "frmAlacena";
            this.Text = "Alacena";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.mrcAlacena.ResumeLayout(false);
            this.mrcAlacena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox mrcAlacena;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.ListBox xd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.RadioButton optBaño;
        private System.Windows.Forms.RadioButton optHeladera;
        private System.Windows.Forms.RadioButton optAlacena;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cboProducto;
    }
}