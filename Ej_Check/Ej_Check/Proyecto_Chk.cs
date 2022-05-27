using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_Check
{
    public partial class Proyecto_Chk : Form
    {
        public Proyecto_Chk()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (chkHombre.Checked && chkHombre.Checked == true )
            {
                lbRes.Text = "Error - Debe seleccionar una de las opciones";
            }
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            lbRes.Text = null;
        }
    }
}
