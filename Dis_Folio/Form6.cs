using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Dis_Folio
{
    public partial class Form6 : MaterialForm
    {
        public Form6(Form_Recibo.Folio informacion)
        {
            InitializeComponent();
            txtSoci.Text = informacion.Socios;
            txRFC.Text = informacion.RFC;
            txtFolio.Text = Convert.ToString(informacion.folio);
            ///
            txtSoci.Text = informacion.lista[0];
            txRFC.Text = informacion.lista[1];
            txtFolio.Text = informacion.lista[2];
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void BtImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font tipo_texto = new Font("Arial", 18,FontStyle.Bold);
            e.Graphics.DrawString(Socio.Text, tipo_texto, Brushes.Black, 15, 100);
            e.Graphics.DrawString(txtSoci.Text,tipo_texto, Brushes.Black, 150, 100);
            e.Graphics.DrawString(RFC.Text, tipo_texto, Brushes.Black, 15, 200);
            e.Graphics.DrawString(txRFC.Text,tipo_texto, Brushes.Black, 150, 200);
            e.Graphics.DrawString(Folio.Text, tipo_texto, Brushes.Black, 15, 300);
            e.Graphics.DrawString(txtFolio.Text, tipo_texto, Brushes.Black, 150, 300);
            e.Graphics.DrawString(Fecha.Text, tipo_texto, Brushes.Black, 15, 400);
            e.Graphics.DrawString(Tiempo.Text, tipo_texto, Brushes.Black, 270, 400);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
