using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Suma : Form
    {

        decimal num1;
        decimal num2;
        decimal res = 0;

        public Suma()
        {
            InitializeComponent();
        }

        private void BtRes_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(TxtNum1.Text);
            num2 = Convert.ToInt32(TxtNum2.Text);

            res = num1 + num2;

            TxtRes.Text = res.ToString();
        }
    }
}
            
            

        
        

           





