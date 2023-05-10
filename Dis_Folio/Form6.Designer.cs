
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtSoci = new System.Windows.Forms.TextBox();
            this.txRFC = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.Socio = new System.Windows.Forms.Label();
            this.Folio = new System.Windows.Forms.Label();
            this.RFC = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.DateTimePicker();
            this.BtImprimir = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSoci
            // 
            this.txtSoci.Location = new System.Drawing.Point(130, 24);
            this.txtSoci.Name = "txtSoci";
            this.txtSoci.Size = new System.Drawing.Size(100, 20);
            this.txtSoci.TabIndex = 2;
            // 
            // txRFC
            // 
            this.txRFC.Location = new System.Drawing.Point(130, 60);
            this.txRFC.Name = "txRFC";
            this.txRFC.Size = new System.Drawing.Size(100, 20);
            this.txRFC.TabIndex = 3;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(130, 103);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(100, 20);
            this.txtFolio.TabIndex = 4;
            // 
            // Socio
            // 
            this.Socio.AutoSize = true;
            this.Socio.Location = new System.Drawing.Point(32, 27);
            this.Socio.Name = "Socio";
            this.Socio.Size = new System.Drawing.Size(34, 13);
            this.Socio.TabIndex = 6;
            this.Socio.Text = "Socio";
            // 
            // Folio
            // 
            this.Folio.AutoSize = true;
            this.Folio.Location = new System.Drawing.Point(32, 106);
            this.Folio.Name = "Folio";
            this.Folio.Size = new System.Drawing.Size(29, 13);
            this.Folio.TabIndex = 7;
            this.Folio.Text = "Folio";
            // 
            // RFC
            // 
            this.RFC.AutoSize = true;
            this.RFC.Location = new System.Drawing.Point(32, 63);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(28, 13);
            this.RFC.TabIndex = 8;
            this.RFC.Text = "RFC";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(29, 149);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(91, 13);
            this.Fecha.TabIndex = 9;
            this.Fecha.Text = "Fecha Aportacion";
            // 
            // Tiempo
            // 
            this.Tiempo.Location = new System.Drawing.Point(130, 143);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(199, 20);
            this.Tiempo.TabIndex = 10;
            // 
            // BtImprimir
            // 
            this.BtImprimir.Location = new System.Drawing.Point(45, 236);
            this.BtImprimir.Name = "BtImprimir";
            this.BtImprimir.Size = new System.Drawing.Size(116, 49);
            this.BtImprimir.TabIndex = 11;
            this.BtImprimir.Text = "Imprimir";
            this.BtImprimir.UseVisualStyleBackColor = true;
            this.BtImprimir.Click += new System.EventHandler(this.BtImprimir_Click);
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
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 297);
            this.Controls.Add(this.BtImprimir);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.RFC);
            this.Controls.Add(this.Folio);
            this.Controls.Add(this.Socio);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.txRFC);
            this.Controls.Add(this.txtSoci);
            this.Controls.Add(this.button2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSoci;
        private System.Windows.Forms.TextBox txRFC;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label Socio;
        private System.Windows.Forms.Label Folio;
        private System.Windows.Forms.Label RFC;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker Tiempo;
        private System.Windows.Forms.Button BtImprimir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}