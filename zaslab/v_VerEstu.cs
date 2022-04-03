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
            dtgv_verest.Columns.Add("","");
            dtgv_verest.Columns[0].HeaderText = "Nombre";
            dtgv_verest.Rows.Add();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            v_EdiEliEst mensaje2 = new v_EdiEliEst();
            mensaje2.ShowDialog();

            if (mensaje2.DialogResult == DialogResult.OK)
            {
                //nombrec = mensaje2.nombreca;
                // cedulacli = mensaje2.cedulaclia;
                MessageBox.Show("asdasd" + mensaje2.DialogResult.ToString());

            }

        }
    }
}
