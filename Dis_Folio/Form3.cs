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
    public partial class form_Registro : MaterialForm
    {
        public form_Registro()
        {
            InitializeComponent();
        }
        public struct Datos
        {
            public string Nombre;
            public string Apellido_P;
            public string Apellido_M;
            public int Telefono;
            public string Correo_electronico;
            public string Ciudad;
            public string rfc;
            public string Fecha_Ingreso;
            public List<string> lista;
        }

        private void Btenviar_Click(object sender, EventArgs e)
        {
            Datos info;
            info.Nombre = txtnombre.Text;
            info.Apellido_P = txtApellido_P.Text;
            info.Apellido_M = txtApellido_M.Text;
            info.Ciudad = txtciudad.Text;
            info.Correo_electronico = txtcorreo.Text;
            info.Telefono = Convert.ToInt32(txttelefono.Text);
            info.rfc = txtrfc.Text;
            info.Fecha_Ingreso = txtingreso.Text;
            MessageBox.Show("Sus datos han quedado capturados, Gracias por ser nuevo miembro");
            info.lista = new List<string>(new string[] { txtnombre.Text, txtApellido_P.Text,txtApellido_M.Text,txtrfc.Text,txtcorreo.Text,txtingreso.Text,txttelefono.Text,txtciudad.Text}); ;
            Form4 obj = new Form4(info);
                obj.ShowDialog();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //} Cierra todo el programa, no queremos eso




        private void bt_Limpiar_Click(object sender, EventArgs e)
        {
            txtApellido_P.Clear();
            txtApellido_M.Clear();
            txtciudad.Clear();
            txtcorreo.Clear();
            txtingreso.Clear();
            txtnombre.Clear();
            txtrfc.Clear();
            txttelefono.Clear();
        }

        private void bt_regregar_Click(object sender, EventArgs e)
        {
            form_Registro sd = new form_Registro();
            sd.Close();
            
        }
    }
}
