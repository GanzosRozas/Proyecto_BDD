using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Dis_Folio
{
    public partial class Form_Recibo : MaterialForm
    {
        public Form_Recibo(Form_NuevoSocio.DatosSocio infos)
        {
            InitializeComponent();
            //txtSocio.Text=(infos.Nombres+" "+infos.Apellido_PA+" "+infos.Apellido_MA);
            //TxtRfC.Text = infos.RfC;
            ////
            txtSocio.Text = (infos.listaSocio1[0] + "" + infos.listaSocio1[1] + "" + infos.listaSocio1[2]);
            //txtSocio.Text = infos.listaSocio1[1];
            TxtRfC.Text = infos.listaSocio1[3];
            ///Aqui agarra del form 1 
        }
        public Form_Recibo(Form_Inicio_Sesion.DatosSocio1 infoSocio)
        {
            InitializeComponent();
            txtSocio.Text = infoSocio.socio;
            TxtRfC.Text = infoSocio.RFC;
            ///
            txtSocio.Text = infoSocio.listaSocio[0];
            TxtRfC.Text = infoSocio.listaSocio[1];

        }
        public struct Folio 
        {
            public string Socios;
            public string RFC;
            public int folio;

            public List<string> lista;
        }

   

        private void bt_Recibo_Click(object sender, EventArgs e)
        {
            Folio informacion;
            informacion.Socios = txtSocio.Text;
            informacion.RFC = TxtRfC.Text;
            Random rnd = new Random();
            int folio = rnd.Next(123123, 12312314);
            informacion.folio = folio;
            informacion.lista = new List<string>(new string[] { txtSocio.Text, TxtRfC.Text, Convert.ToString(folio)});
            Form6 obj = new Form6(informacion);
            obj.ShowDialog();
        }

        private void BtSalir_1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
