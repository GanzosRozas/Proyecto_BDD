
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
            this.txtSocio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRFC = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSocio = new MaterialSkin.Controls.MaterialLabel();
            this.lblRFC = new MaterialSkin.Controls.MaterialLabel();
            this.Bt_Aceptar2 = new MaterialSkin.Controls.MaterialButton();
            this.Rfc_olvidada2 = new MaterialSkin.Controls.MaterialButton();
            this.Bt_Nsocio2 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtSocio
            // 
            this.txtSocio.AnimateReadOnly = false;
            this.txtSocio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSocio.Depth = 0;
            this.txtSocio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSocio.LeadingIcon = null;
            this.txtSocio.Location = new System.Drawing.Point(117, 95);
            this.txtSocio.MaxLength = 50;
            this.txtSocio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSocio.Multiline = false;
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(259, 50);
            this.txtSocio.TabIndex = 10;
            this.txtSocio.Text = "";
            this.txtSocio.TrailingIcon = null;
            // 
            // txtRFC
            // 
            this.txtRFC.AnimateReadOnly = false;
            this.txtRFC.Depth = 0;
            this.txtRFC.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRFC.LeadingIcon = null;
            this.txtRFC.Location = new System.Drawing.Point(117, 182);
            this.txtRFC.MaxLength = 50;
            this.txtRFC.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRFC.Multiline = false;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(259, 50);
            this.txtRFC.TabIndex = 11;
            this.txtRFC.Text = "";
            this.txtRFC.TrailingIcon = null;
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Depth = 0;
            this.lblSocio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSocio.Location = new System.Drawing.Point(47, 119);
            this.lblSocio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(41, 19);
            this.lblSocio.TabIndex = 12;
            this.lblSocio.Text = "Socio";
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Depth = 0;
            this.lblRFC.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRFC.Location = new System.Drawing.Point(58, 200);
            this.lblRFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(30, 19);
            this.lblRFC.TabIndex = 13;
            this.lblRFC.Text = "RFC";
            // 
            // Bt_Aceptar2
            // 
            this.Bt_Aceptar2.AutoSize = false;
            this.Bt_Aceptar2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_Aceptar2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Bt_Aceptar2.Depth = 0;
            this.Bt_Aceptar2.HighEmphasis = true;
            this.Bt_Aceptar2.Icon = null;
            this.Bt_Aceptar2.Location = new System.Drawing.Point(16, 310);
            this.Bt_Aceptar2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bt_Aceptar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bt_Aceptar2.Name = "Bt_Aceptar2";
            this.Bt_Aceptar2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Bt_Aceptar2.Size = new System.Drawing.Size(167, 36);
            this.Bt_Aceptar2.TabIndex = 14;
            this.Bt_Aceptar2.Text = "Aceptar";
            this.Bt_Aceptar2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Bt_Aceptar2.UseAccentColor = false;
            this.Bt_Aceptar2.UseVisualStyleBackColor = true;
            this.Bt_Aceptar2.Click += new System.EventHandler(this.Bt_Aceptar_Click);
            // 
            // Rfc_olvidada2
            // 
            this.Rfc_olvidada2.AutoSize = false;
            this.Rfc_olvidada2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Rfc_olvidada2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Rfc_olvidada2.Depth = 0;
            this.Rfc_olvidada2.HighEmphasis = true;
            this.Rfc_olvidada2.Icon = null;
            this.Rfc_olvidada2.Location = new System.Drawing.Point(153, 262);
            this.Rfc_olvidada2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Rfc_olvidada2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rfc_olvidada2.Name = "Rfc_olvidada2";
            this.Rfc_olvidada2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Rfc_olvidada2.Size = new System.Drawing.Size(163, 26);
            this.Rfc_olvidada2.TabIndex = 15;
            this.Rfc_olvidada2.Text = "Ayuda Clave RFC";
            this.Rfc_olvidada2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Rfc_olvidada2.UseAccentColor = false;
            this.Rfc_olvidada2.UseVisualStyleBackColor = true;
            this.Rfc_olvidada2.Click += new System.EventHandler(this.Bt_ayuda_Click);
            // 
            // Bt_Nsocio2
            // 
            this.Bt_Nsocio2.AutoSize = false;
            this.Bt_Nsocio2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_Nsocio2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Bt_Nsocio2.Depth = 0;
            this.Bt_Nsocio2.HighEmphasis = true;
            this.Bt_Nsocio2.Icon = null;
            this.Bt_Nsocio2.Location = new System.Drawing.Point(279, 310);
            this.Bt_Nsocio2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bt_Nsocio2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bt_Nsocio2.Name = "Bt_Nsocio2";
            this.Bt_Nsocio2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Bt_Nsocio2.Size = new System.Drawing.Size(157, 36);
            this.Bt_Nsocio2.TabIndex = 16;
            this.Bt_Nsocio2.Text = "Nuevo Socio";
            this.Bt_Nsocio2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Bt_Nsocio2.UseAccentColor = false;
            this.Bt_Nsocio2.UseVisualStyleBackColor = true;
            this.Bt_Nsocio2.Click += new System.EventHandler(this.Bt_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(508, 395);
            this.Controls.Add(this.Bt_Nsocio2);
            this.Controls.Add(this.Rfc_olvidada2);
            this.Controls.Add(this.Bt_Aceptar2);
            this.Controls.Add(this.lblRFC);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtSocio);
            this.Name = "Form1";
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtSocio;
        private MaterialSkin.Controls.MaterialTextBox txtRFC;
        private MaterialSkin.Controls.MaterialLabel lblSocio;
        private MaterialSkin.Controls.MaterialLabel lblRFC;
        private MaterialSkin.Controls.MaterialButton Bt_Aceptar2;
        private MaterialSkin.Controls.MaterialButton Rfc_olvidada2;
        private MaterialSkin.Controls.MaterialButton Bt_Nsocio2;
    }
}

