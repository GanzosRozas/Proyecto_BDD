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
    public partial class Form_InicioAdmin : MaterialForm
    {
        public Form_InicioAdmin()
        {
            InitializeComponent();
            //skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }
        MaterialSkinManager skinManager = MaterialSkinManager.Instance;
        private void Form_InicioAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cmdAcceder_Click(object sender, EventArgs e)
        {
            Form_Inicio_Sesion FIS = new Form_Inicio_Sesion();
            FIS.ShowDialog();

        }
    }
}
