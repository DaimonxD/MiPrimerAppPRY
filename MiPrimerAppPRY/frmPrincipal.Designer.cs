namespace MiPrimerAppPRY
{
    partial class frmCalculoDelMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoDelMes));
            this.mrcIngreso = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcGastosFijos = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.mrcGastosVarios = new System.Windows.Forms.GroupBox();
            this.txtJoda = new System.Windows.Forms.TextBox();
            this.lblJoda = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdAlacena = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.mrcIngreso.SuspendLayout();
            this.mrcGastosFijos.SuspendLayout();
            this.mrcGastosVarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcIngreso
            // 
            this.mrcIngreso.AutoSize = true;
            this.mrcIngreso.Controls.Add(this.txtDeposito);
            this.mrcIngreso.Controls.Add(this.lblDeposito);
            this.mrcIngreso.Location = new System.Drawing.Point(12, 12);
            this.mrcIngreso.Name = "mrcIngreso";
            this.mrcIngreso.Size = new System.Drawing.Size(532, 90);
            this.mrcIngreso.TabIndex = 0;
            this.mrcIngreso.TabStop = false;
            this.mrcIngreso.Text = "Ingreso";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(238, 28);
            this.txtDeposito.Multiline = true;
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(288, 34);
            this.txtDeposito.TabIndex = 1;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(49, 33);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(110, 29);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Depòsito";
            // 
            // mrcGastosFijos
            // 
            this.mrcGastosFijos.AutoSize = true;
            this.mrcGastosFijos.Controls.Add(this.txtComida);
            this.mrcGastosFijos.Controls.Add(this.txtImpuestos);
            this.mrcGastosFijos.Controls.Add(this.txtAlquiler);
            this.mrcGastosFijos.Controls.Add(this.lblComida);
            this.mrcGastosFijos.Controls.Add(this.lblImpuestos);
            this.mrcGastosFijos.Controls.Add(this.lblAlquiler);
            this.mrcGastosFijos.Location = new System.Drawing.Point(12, 108);
            this.mrcGastosFijos.Name = "mrcGastosFijos";
            this.mrcGastosFijos.Size = new System.Drawing.Size(532, 166);
            this.mrcGastosFijos.TabIndex = 2;
            this.mrcGastosFijos.TabStop = false;
            this.mrcGastosFijos.Text = "Gastos Fijos";
            // 
            // txtComida
            // 
            this.txtComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtComida.Location = new System.Drawing.Point(238, 113);
            this.txtComida.Multiline = true;
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(288, 34);
            this.txtComida.TabIndex = 6;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtImpuestos.Location = new System.Drawing.Point(238, 69);
            this.txtImpuestos.Multiline = true;
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(288, 34);
            this.txtImpuestos.TabIndex = 5;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtAlquiler.Location = new System.Drawing.Point(238, 23);
            this.txtAlquiler.Multiline = true;
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(288, 34);
            this.txtAlquiler.TabIndex = 2;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.Location = new System.Drawing.Point(49, 118);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(97, 29);
            this.lblComida.TabIndex = 4;
            this.lblComida.Text = "Comida";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(49, 74);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(124, 29);
            this.lblImpuestos.TabIndex = 2;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquiler.Location = new System.Drawing.Point(49, 28);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(95, 29);
            this.lblAlquiler.TabIndex = 0;
            this.lblAlquiler.Text = "Alquiler";
            // 
            // mrcGastosVarios
            // 
            this.mrcGastosVarios.AutoSize = true;
            this.mrcGastosVarios.Controls.Add(this.txtJoda);
            this.mrcGastosVarios.Controls.Add(this.lblJoda);
            this.mrcGastosVarios.Location = new System.Drawing.Point(12, 280);
            this.mrcGastosVarios.Name = "mrcGastosVarios";
            this.mrcGastosVarios.Size = new System.Drawing.Size(535, 72);
            this.mrcGastosVarios.TabIndex = 3;
            this.mrcGastosVarios.TabStop = false;
            this.mrcGastosVarios.Text = "Gastos Varios";
            // 
            // txtJoda
            // 
            this.txtJoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtJoda.Location = new System.Drawing.Point(241, 19);
            this.txtJoda.Multiline = true;
            this.txtJoda.Name = "txtJoda";
            this.txtJoda.Size = new System.Drawing.Size(288, 34);
            this.txtJoda.TabIndex = 7;
            // 
            // lblJoda
            // 
            this.lblJoda.AutoSize = true;
            this.lblJoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoda.Location = new System.Drawing.Point(49, 19);
            this.lblJoda.Name = "lblJoda";
            this.lblJoda.Size = new System.Drawing.Size(66, 29);
            this.lblJoda.TabIndex = 0;
            this.lblJoda.Text = "Joda";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(409, 396);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(132, 42);
            this.cmdGuardar.TabIndex = 4;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdAlacena
            // 
            this.cmdAlacena.Location = new System.Drawing.Point(210, 396);
            this.cmdAlacena.Name = "cmdAlacena";
            this.cmdAlacena.Size = new System.Drawing.Size(132, 42);
            this.cmdAlacena.TabIndex = 5;
            this.cmdAlacena.Text = "Alacena";
            this.cmdAlacena.UseVisualStyleBackColor = true;
            this.cmdAlacena.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(12, 396);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(132, 42);
            this.cmdCancelar.TabIndex = 6;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(190, 355);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total...";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.Location = new System.Drawing.Point(272, 355);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(0, 25);
            this.lblTotalNum.TabIndex = 8;
            // 
            // frmCalculoDelMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAlacena);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.mrcGastosVarios);
            this.Controls.Add(this.mrcGastosFijos);
            this.Controls.Add(this.mrcIngreso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculoDelMes";
            this.Text = "Càlculo del mes";
            this.mrcIngreso.ResumeLayout(false);
            this.mrcIngreso.PerformLayout();
            this.mrcGastosFijos.ResumeLayout(false);
            this.mrcGastosFijos.PerformLayout();
            this.mrcGastosVarios.ResumeLayout(false);
            this.mrcGastosVarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcIngreso;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.GroupBox mrcGastosFijos;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.GroupBox mrcGastosVarios;
        private System.Windows.Forms.TextBox txtJoda;
        private System.Windows.Forms.Label lblJoda;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdAlacena;
        private System.Windows.Forms.Button cmdCancelar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalNum;
    }
}

