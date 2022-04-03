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
    public partial class v_VerEstu : Form
    {
        public v_VerEstu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            v_EdiEliEst mensaje2 = new v_EdiEliEst();
            mensaje2.ShowDialog();

            if (mensaje2.DialogResult == DialogResult.OK)
            {
                //nombrec = mensaje2.nombreca;
                // cedulacli = mensaje2.cedulaclia;
                //this.DialogResult = DialogResult.OK;
                MessageBox.Show("" + mensaje2.DialogResult.ToString());

                this.Close();
            }

        }
    }
}
