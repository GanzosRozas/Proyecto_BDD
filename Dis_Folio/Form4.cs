using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dis_Folio
{
    public partial class Form4 : Form
    {
        public Form4(form_Registro.Datos info)
        {
            InitializeComponent();
            /// Toma los datos del nuevo socio  los pone en el registro del forms 4 
            txtnombre.Text = info.Nombre;
            txtapellido.Text = info.Apellidos;
            txtTel.Text = Convert.ToString(info.Telefono);
            txtRfc.Text = Convert.ToString(info.rfc);
            txtCorreoEle.Text = info.Correo_electronico;
            Ciudad.Text = info.Ciudad;
            txtFechaIngre.Text = info.Fecha_Ingreso;
            /// Aqui empieza lista
            txtnombre.Text = info.lista[0];
            txtapellido.Text = info.lista[1];
            txtTel.Text = info.lista[2];
            txtRfc.Text = info.lista[3];
            Ciudad.Text = info.lista[4];
            txtCorreoEle.Text = info.lista[5];
            txtFechaIngre.Text = info.lista[6];
        }
        public struct DatosSocio
        {
            public string Nombres;
            public string Apellido;
            public string RfC;
            public List<string> listaSocio1;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAcept_Click(object sender, EventArgs e)
        {
            DatosSocio infos;
            infos.Nombres = txtnombre.Text;
            infos.Apellido = txtapellido.Text;
            infos.RfC = txtRfc.Text;
            infos.listaSocio1 = new List<string>(new string[] { txtnombre.Text, txtapellido.Text, txtRfc.Text });
            Form5 obj = new Form5(infos);
            obj.ShowDialog();
        }
    }
}
