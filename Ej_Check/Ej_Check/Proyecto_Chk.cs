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
            if (chkHombre.Checked && chkMujer.Checked == true )
            {
                lbRes.Text = "Error - Debe seleccionar una de las opciones";
            }
            if (chkHombre.Checked == true)
            {
                lbRes.Text = "Ha seleccionado Hombre, ingrese sus datos personales";
            }
            if (chkMujer.Checked == true)
            {
                lbRes.Text = "Ha seleccionado Mujer, ingrese sus datos personales";
            }
            if (chkHombre.Checked == true && chkMujer.Checked == false)
            {
                lbRes.Text = "Ha seleccionado Hombre";
            }
            if (chkMujer.Checked == false && chkHombre.Checked == true)
            {
                lbRes.Text = "Ha seleccionado Mujer";
            }
          
           
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            lbRes.Text = null;
        }
        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

   
    }
}
