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
    public partial class Form_NuevoSocio : MaterialForm
    {
        public Form_NuevoSocio(Form_Registro.Datos info)
        {
            InitializeComponent();
            /// Toma los datos del registro y los ponemos en la la forma nuevo socio
            txtnombre.Text = info.Nombre;
            txtApellido_P.Text = info.Apellido_P;
            txtApellido_M.Text = info.Apellido_M;
            txtTel.Text = Convert.ToString(info.Telefono);
            txtRfc.Text = Convert.ToString(info.rfc);
            txtCorreoEle.Text = info.Correo_electronico;
            txtCiudad.Text = info.Ciudad;
            txtFechaIngre.Text = info.Fecha_Ingreso;
            /// Aqui empieza lista
            txtnombre.Text = info.lista[0];
            txtApellido_P.Text = info.lista[1];
            txtApellido_M.Text = info.lista[2];
            txtRfc.Text = info.lista[3];
            txtCorreoEle.Text = info.lista[4];
            txtFechaIngre.Text = info.lista[5];
            txtTel.Text = info.lista[6];
            txtCiudad.Text = info.lista[7];
           
           
        }
        public struct DatosSocio
        {
            public string Nombres;
            public string Apellido_PA;
            public string Apellido_MA;
            public string RfC;
            public List<string> listaSocio1;
        }


        private void BtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btAcept_Click(object sender, EventArgs e)
        {
            DatosSocio infos;
            infos.Nombres = txtnombre.Text;
            infos.Apellido_PA = txtApellido_P.Text;
            infos.Apellido_MA = txtApellido_M.Text;
            infos.RfC = txtRfc.Text;
            infos.listaSocio1 = new List<string>(new string[] { txtnombre.Text, txtApellido_P.Text, txtApellido_M.Text, txtRfc.Text });
            Form_Recibo obj = new Form_Recibo(infos);
            obj.ShowDialog();
        }


    }
}
