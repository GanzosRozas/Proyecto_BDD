
namespace Dis_Folio
{
    partial class Form4
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
            this.BtSalir = new System.Windows.Forms.Button();
            this.btAcept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.lbIngreso = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.txtCorreoEle = new System.Windows.Forms.TextBox();
            this.Ciudad = new System.Windows.Forms.TextBox();
            this.txtFechaIngre = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(185, 306);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(75, 42);
            this.BtSalir.TabIndex = 0;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // btAcept
            // 
            this.btAcept.Location = new System.Drawing.Point(68, 306);
            this.btAcept.Name = "btAcept";
            this.btAcept.Size = new System.Drawing.Size(75, 42);
            this.btAcept.TabIndex = 1;
            this.btAcept.Text = "Aportar";
            this.btAcept.UseVisualStyleBackColor = true;
            this.btAcept.Click += new System.EventHandler(this.btAcept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RFC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo Electronico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "¿Desea realizar su primer aporte en la empresa?";
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Location = new System.Drawing.Point(12, 193);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(40, 13);
            this.lbCiudad.TabIndex = 7;
            this.lbCiudad.Text = "Ciudad";
            // 
            // lbIngreso
            // 
            this.lbIngreso.AutoSize = true;
            this.lbIngreso.Location = new System.Drawing.Point(12, 224);
            this.lbIngreso.Name = "lbIngreso";
            this.lbIngreso.Size = new System.Drawing.Size(89, 13);
            this.lbIngreso.TabIndex = 8;
            this.lbIngreso.Text = "Fecha de ingreso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefono";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(126, 17);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 10;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(126, 52);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 11;
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(126, 120);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(100, 20);
            this.txtRfc.TabIndex = 12;
            // 
            // txtCorreoEle
            // 
            this.txtCorreoEle.Location = new System.Drawing.Point(126, 154);
            this.txtCorreoEle.Name = "txtCorreoEle";
            this.txtCorreoEle.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoEle.TabIndex = 13;
            // 
            // Ciudad
            // 
            this.Ciudad.Location = new System.Drawing.Point(126, 186);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(100, 20);
            this.Ciudad.TabIndex = 14;
            // 
            // txtFechaIngre
            // 
            this.txtFechaIngre.Location = new System.Drawing.Point(126, 221);
            this.txtFechaIngre.Name = "txtFechaIngre";
            this.txtFechaIngre.Size = new System.Drawing.Size(100, 20);
            this.txtFechaIngre.TabIndex = 15;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(126, 85);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 16;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 360);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtFechaIngre);
            this.Controls.Add(this.Ciudad);
            this.Controls.Add(this.txtCorreoEle);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbIngreso);
            this.Controls.Add(this.lbCiudad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAcept);
            this.Controls.Add(this.BtSalir);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button btAcept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Label lbIngreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.TextBox txtCorreoEle;
        private System.Windows.Forms.TextBox Ciudad;
        private System.Windows.Forms.TextBox txtFechaIngre;
        private System.Windows.Forms.TextBox txtTel;
    }
}