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
    public partial class Form1 : MaterialForm
    {
        public Form1()
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
            infoSocio.listaSocio = new List<string>(new string[] { txtRFC.Text, txtSocio.Text });
            Form5 obj = new Form5(infoSocio);
            obj.ShowDialog();
        }

        private void Bt_Salir_Click(object sender, EventArgs e)
        {
            form_Registro obj = new form_Registro();
            obj.ShowDialog();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private void Bt_ayuda_Click(object sender, EventArgs e)
        {
        MessageBox.Show("Clave RFC son las unicas letras de su rfc");
        }
    }
}
