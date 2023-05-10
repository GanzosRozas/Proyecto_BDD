
namespace Dis_Folio
{
    partial class Form5
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
            this.BtSalir_1 = new System.Windows.Forms.Button();
            this.bt_Recibo = new System.Windows.Forms.Button();
            this.txtSocio = new System.Windows.Forms.TextBox();
            this.TxtRfC = new System.Windows.Forms.TextBox();
            this.txtAportacion = new System.Windows.Forms.TextBox();
            this.lblSocio = new System.Windows.Forms.Label();
            this.LblRFC = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.lblAportacion = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtSalir_1
            // 
            this.BtSalir_1.Location = new System.Drawing.Point(140, 234);
            this.BtSalir_1.Name = "BtSalir_1";
            this.BtSalir_1.Size = new System.Drawing.Size(78, 45);
            this.BtSalir_1.TabIndex = 0;
            this.BtSalir_1.Text = "Salir";
            this.BtSalir_1.UseVisualStyleBackColor = true;
            this.BtSalir_1.Click += new System.EventHandler(this.BtSalir_1_Click);
            // 
            // bt_Recibo
            // 
            this.bt_Recibo.Location = new System.Drawing.Point(12, 234);
            this.bt_Recibo.Name = "bt_Recibo";
            this.bt_Recibo.Size = new System.Drawing.Size(78, 45);
            this.bt_Recibo.TabIndex = 1;
            this.bt_Recibo.Text = "Recibo";
            this.bt_Recibo.UseVisualStyleBackColor = true;
            this.bt_Recibo.Click += new System.EventHandler(this.bt_Recibo_Click);
            // 
            // txtSocio
            // 
            this.txtSocio.Location = new System.Drawing.Point(118, 40);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(100, 20);
            this.txtSocio.TabIndex = 2;
            // 
            // TxtRfC
            // 
            this.TxtRfC.Location = new System.Drawing.Point(118, 88);
            this.TxtRfC.Name = "TxtRfC";
            this.TxtRfC.Size = new System.Drawing.Size(100, 20);
            this.TxtRfC.TabIndex = 3;
            // 
            // txtAportacion
            // 
            this.txtAportacion.Location = new System.Drawing.Point(118, 130);
            this.txtAportacion.Name = "txtAportacion";
            this.txtAportacion.Size = new System.Drawing.Size(100, 20);
            this.txtAportacion.TabIndex = 4;
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(34, 43);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(34, 13);
            this.lblSocio.TabIndex = 5;
            this.lblSocio.Text = "Socio";
            // 
            // LblRFC
            // 
            this.LblRFC.AutoSize = true;
            this.LblRFC.Location = new System.Drawing.Point(34, 91);
            this.LblRFC.Name = "LblRFC";
            this.LblRFC.Size = new System.Drawing.Size(28, 13);
            this.LblRFC.TabIndex = 6;
            this.LblRFC.Text = "RFC";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(34, 178);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 7;
            this.LblFecha.Text = "Fecha";
            // 
            // lblAportacion
            // 
            this.lblAportacion.AutoSize = true;
            this.lblAportacion.Location = new System.Drawing.Point(34, 137);
            this.lblAportacion.Name = "lblAportacion";
            this.lblAportacion.Size = new System.Drawing.Size(58, 13);
            this.lblAportacion.TabIndex = 8;
            this.lblAportacion.Text = "Aportacion";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(118, 175);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 9;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 331);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblAportacion);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblRFC);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.txtAportacion);
            this.Controls.Add(this.TxtRfC);
            this.Controls.Add(this.txtSocio);
            this.Controls.Add(this.bt_Recibo);
            this.Controls.Add(this.BtSalir_1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSalir_1;
        private System.Windows.Forms.Button bt_Recibo;
        private System.Windows.Forms.TextBox txtSocio;
        private System.Windows.Forms.TextBox TxtRfC;
        private System.Windows.Forms.TextBox txtAportacion;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label LblRFC;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label lblAportacion;
        private System.Windows.Forms.TextBox txtFecha;
    }
}