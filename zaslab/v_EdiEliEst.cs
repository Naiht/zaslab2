using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaslab
{
    public partial class v_EdiEliEst : Form
    {
        public v_EdiEliEst()
        {
            InitializeComponent();
        }

        private void v_EdiEliEst_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
