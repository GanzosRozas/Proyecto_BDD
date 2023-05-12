
namespace Dis_Folio
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Tiempo = new System.Windows.Forms.DateTimePicker();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtSoci = new MaterialSkin.Controls.MaterialTextBox();
            this.txRFC = new MaterialSkin.Controls.MaterialTextBox();
            this.txtFolio = new MaterialSkin.Controls.MaterialTextBox();
            this.Socio = new MaterialSkin.Controls.MaterialLabel();
            this.RFC = new MaterialSkin.Controls.MaterialLabel();
            this.Folio = new MaterialSkin.Controls.MaterialLabel();
            this.Fecha = new MaterialSkin.Controls.MaterialLabel();
            this.cmd_Imprimir = new MaterialSkin.Controls.MaterialButton();
            this.cmd_Salir = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Tiempo
            // 
            this.Tiempo.Location = new System.Drawing.Point(358, 97);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(199, 20);
            this.Tiempo.TabIndex = 10;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtSoci
            // 
            this.txtSoci.AnimateReadOnly = false;
            this.txtSoci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoci.Depth = 0;
            this.txtSoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoci.LeadingIcon = null;
            this.txtSoci.Location = new System.Drawing.Point(100, 67);
            this.txtSoci.MaxLength = 50;
            this.txtSoci.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoci.Multiline = false;
            this.txtSoci.Name = "txtSoci";
            this.txtSoci.Size = new System.Drawing.Size(100, 50);
            this.txtSoci.TabIndex = 12;
            this.txtSoci.Text = "";
            this.txtSoci.TrailingIcon = null;
            // 
            // txRFC
            // 
            this.txRFC.AnimateReadOnly = false;
            this.txRFC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txRFC.Depth = 0;
            this.txRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txRFC.LeadingIcon = null;
            this.txRFC.Location = new System.Drawing.Point(100, 123);
            this.txRFC.MaxLength = 50;
            this.txRFC.MouseState = MaterialSkin.MouseState.OUT;
            this.txRFC.Multiline = false;
            this.txRFC.Name = "txRFC";
            this.txRFC.Size = new System.Drawing.Size(100, 50);
            this.txRFC.TabIndex = 13;
            this.txRFC.Text = "";
            this.txRFC.TrailingIcon = null;
            // 
            // txtFolio
            // 
            this.txtFolio.AnimateReadOnly = false;
            this.txtFolio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFolio.Depth = 0;
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFolio.LeadingIcon = null;
            this.txtFolio.Location = new System.Drawing.Point(100, 179);
            this.txtFolio.MaxLength = 50;
            this.txtFolio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFolio.Multiline = false;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(100, 50);
            this.txtFolio.TabIndex = 14;
            this.txtFolio.Text = "";
            this.txtFolio.TrailingIcon = null;
            // 
            // Socio
            // 
            this.Socio.AutoSize = true;
            this.Socio.Depth = 0;
            this.Socio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Socio.Location = new System.Drawing.Point(42, 81);
            this.Socio.MouseState = MaterialSkin.MouseState.HOVER;
            this.Socio.Name = "Socio";
            this.Socio.Size = new System.Drawing.Size(41, 19);
            this.Socio.TabIndex = 15;
            this.Socio.Text = "Socio";
            // 
            // RFC
            // 
            this.RFC.AutoSize = true;
            this.RFC.Depth = 0;
            this.RFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RFC.Location = new System.Drawing.Point(42, 139);
            this.RFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(30, 19);
            this.RFC.TabIndex = 16;
            this.RFC.Text = "RFC";
            // 
            // Folio
            // 
            this.Folio.AutoSize = true;
            this.Folio.Depth = 0;
            this.Folio.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Folio.Location = new System.Drawing.Point(42, 193);
            this.Folio.MouseState = MaterialSkin.MouseState.HOVER;
            this.Folio.Name = "Folio";
            this.Folio.Size = new System.Drawing.Size(36, 19);
            this.Folio.TabIndex = 17;
            this.Folio.Text = "Folio";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Depth = 0;
            this.Fecha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Fecha.Location = new System.Drawing.Point(235, 98);
            this.Fecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(117, 19);
            this.Fecha.TabIndex = 18;
            this.Fecha.Text = "Fecha De Aporte";
            // 
            // cmd_Imprimir
            // 
            this.cmd_Imprimir.AutoSize = false;
            this.cmd_Imprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmd_Imprimir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmd_Imprimir.Depth = 0;
            this.cmd_Imprimir.HighEmphasis = true;
            this.cmd_Imprimir.Icon = null;
            this.cmd_Imprimir.Location = new System.Drawing.Point(258, 181);
            this.cmd_Imprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmd_Imprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmd_Imprimir.Name = "cmd_Imprimir";
            this.cmd_Imprimir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmd_Imprimir.Size = new System.Drawing.Size(160, 40);
            this.cmd_Imprimir.TabIndex = 19;
            this.cmd_Imprimir.Text = "Imprimir";
            this.cmd_Imprimir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmd_Imprimir.UseAccentColor = false;
            this.cmd_Imprimir.UseVisualStyleBackColor = true;
            this.cmd_Imprimir.Click += new System.EventHandler(this.BtImprimir_Click);
            // 
            // cmd_Salir
            // 
            this.cmd_Salir.AutoSize = false;
            this.cmd_Salir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmd_Salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cmd_Salir.Depth = 0;
            this.cmd_Salir.HighEmphasis = true;
            this.cmd_Salir.Icon = null;
            this.cmd_Salir.Location = new System.Drawing.Point(426, 181);
            this.cmd_Salir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmd_Salir.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmd_Salir.Name = "cmd_Salir";
            this.cmd_Salir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cmd_Salir.Size = new System.Drawing.Size(160, 40);
            this.cmd_Salir.TabIndex = 20;
            this.cmd_Salir.Text = "Salir";
            this.cmd_Salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cmd_Salir.UseAccentColor = false;
            this.cmd_Salir.UseVisualStyleBackColor = true;
            this.cmd_Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 274);
            this.Controls.Add(this.cmd_Salir);
            this.Controls.Add(this.cmd_Imprimir);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Folio);
            this.Controls.Add(this.RFC);
            this.Controls.Add(this.Socio);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.txRFC);
            this.Controls.Add(this.txtSoci);
            this.Controls.Add(this.Tiempo);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DateTimePicker Tiempo;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MaterialSkin.Controls.MaterialTextBox txtSoci;
        private MaterialSkin.Controls.MaterialTextBox txRFC;
        private MaterialSkin.Controls.MaterialTextBox txtFolio;
        private MaterialSkin.Controls.MaterialLabel Socio;
        private MaterialSkin.Controls.MaterialLabel RFC;
        private MaterialSkin.Controls.MaterialLabel Folio;
        private MaterialSkin.Controls.MaterialLabel Fecha;
        private MaterialSkin.Controls.MaterialButton cmd_Imprimir;
        private MaterialSkin.Controls.MaterialButton cmd_Salir;
    }
}