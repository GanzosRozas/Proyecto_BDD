
namespace Dis_Folio
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
            this.Bt_Aceptar = new System.Windows.Forms.Button();
            this.Bt_Nsocio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RFC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtSocio = new System.Windows.Forms.TextBox();
            this.Rfc_olvidada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bt_Aceptar
            // 
            this.Bt_Aceptar.Location = new System.Drawing.Point(31, 189);
            this.Bt_Aceptar.Name = "Bt_Aceptar";
            this.Bt_Aceptar.Size = new System.Drawing.Size(98, 52);
            this.Bt_Aceptar.TabIndex = 0;
            this.Bt_Aceptar.Text = "Aceptar";
            this.Bt_Aceptar.UseVisualStyleBackColor = true;
            this.Bt_Aceptar.Click += new System.EventHandler(this.Bt_Aceptar_Click);
            // 
            // Bt_Nsocio
            // 
            this.Bt_Nsocio.Location = new System.Drawing.Point(203, 189);
            this.Bt_Nsocio.Name = "Bt_Nsocio";
            this.Bt_Nsocio.Size = new System.Drawing.Size(96, 52);
            this.Bt_Nsocio.TabIndex = 2;
            this.Bt_Nsocio.Text = "Nuevo Socio";
            this.Bt_Nsocio.UseVisualStyleBackColor = true;
            this.Bt_Nsocio.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Socio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RFC
            // 
            this.RFC.AutoSize = true;
            this.RFC.Location = new System.Drawing.Point(50, 84);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(28, 13);
            this.RFC.TabIndex = 4;
            this.RFC.Text = "RFC";
            this.RFC.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(104, 84);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(142, 20);
            this.txtRFC.TabIndex = 7;
            // 
            // txtSocio
            // 
            this.txtSocio.Location = new System.Drawing.Point(104, 34);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(142, 20);
            this.txtSocio.TabIndex = 8;
            // 
            // Rfc_olvidada
            // 
            this.Rfc_olvidada.Location = new System.Drawing.Point(104, 122);
            this.Rfc_olvidada.Name = "Rfc_olvidada";
            this.Rfc_olvidada.Size = new System.Drawing.Size(125, 23);
            this.Rfc_olvidada.TabIndex = 9;
            this.Rfc_olvidada.Text = "Ayuda Clave RFC olvidada";
            this.Rfc_olvidada.UseVisualStyleBackColor = true;
            this.Rfc_olvidada.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(372, 280);
            this.Controls.Add(this.Rfc_olvidada);
            this.Controls.Add(this.txtSocio);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt_Nsocio);
            this.Controls.Add(this.Bt_Aceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Aceptar;
        private System.Windows.Forms.Button Bt_Nsocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtSocio;
        private System.Windows.Forms.Button Rfc_olvidada;
    }
}

