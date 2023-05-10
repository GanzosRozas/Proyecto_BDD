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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public struct Datos
        {
            public string Nombre;
            public string Apellidos;
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
            info.Apellidos = txtapellidos.Text;
            info.Ciudad = txtciudad.Text;
            info.Correo_electronico = txtcorreo.Text;
            info.Telefono = Convert.ToInt32(txttelefono.Text);
            info.rfc = txtrfc.Text;
            info.Fecha_Ingreso = txtingreso.Text;
            MessageBox.Show("Sus datos han quedado capturados, Gracias por ser nuevo miembro");
            info.lista = new List<string>(new string[] { txtnombre.Text, txtapellidos.Text,txtrfc.Text,txtcorreo.Text,txtingreso.Text,txttelefono.Text,txtciudad.Text}) ;
            Form4 obj = new Form4(info);
                obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtapellidos.Clear();
            txtciudad.Clear();
            txtcorreo.Clear();
            txtingreso.Clear();
            txtnombre.Clear();
            txtrfc.Clear();
            txttelefono.Clear();
        }
    }
}
