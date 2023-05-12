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
    public partial class Form_Inicio_Secion : MaterialForm
    {
        public Form_Inicio_Secion()
        {
            InitializeComponent();
        }
        public struct DatosSocio1
        {
            public string socio;
            public string RFC;
            public List<string> listaSocio;
        }
        private void Bt_Aceptar_Click(object sender, EventArgs e)
        {
            DatosSocio1 infoSocio;
            infoSocio.socio = txtSocio.Text;
            infoSocio.RFC = txtRFC.Text;
            MessageBox.Show("Datos confirmados, Bienvenido" );
            infoSocio.listaSocio = new List<string>(new string[] {  txtSocio.Text,txtRFC.Text });
            Form_Recibo obj = new Form_Recibo(infoSocio);
            obj.ShowDialog();
        }

        private void Bt_ayuda_Click(object sender, EventArgs e)
        {
        MessageBox.Show("Clave RFC son las unicas letras de su rfc");
        }


        private void Bt_RegistroNuevo_Click(object sender, EventArgs e)
        {
            Form_Registro obj = new Form_Registro();
            obj.ShowDialog();
        }
    }
}
